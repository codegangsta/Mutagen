using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Utility;
using System.Text;
using Mutagen.Bethesda.Plugins.Analysis;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Meta;

namespace Mutagen.Bethesda.Plugins.Binary.Processing;

/// <summary>
/// A static class with logic on how to decompress mod bytes without leveraging autogenerated records
/// </summary>
public static class ModDecompressor
{
    /// <summary>
    /// Decompresses mod stream into an output
    /// </summary>
    /// <param name="streamCreator">A func to create an input stream</param>
    /// <param name="outputStream">Stream to write output to</param>
    /// <param name="interest">Optional specification of which record types to process</param>
    public static void Decompress(
        Func<IMutagenReadStream> streamCreator,
        Stream outputStream,
        RecordInterest? interest = null)
    {
        using var inputStream = streamCreator();
        using var inputStreamJumpback = streamCreator();
        using var writer = new BinaryWriter(outputStream, Encoding.Default, leaveOpen: true);

        long runningDiff = 0;
        var fileLocs = RecordLocator.GetLocations(
            inputStream,
            interest: interest,
            additionalCriteria: (stream, recType, len) =>
            {
                return stream.GetMajorRecordHeader().IsCompressed;
            });

        // Construct group length container for later use
        var grupMeta = new Dictionary<long, (uint Length, long Offset)>();
        inputStream.Position = 0;
        while (!inputStream.Complete)
        {
            // Import until next listed major record
            long noRecordLength;
            if (fileLocs.ListedRecords.TryGetInDirection(
                    inputStream.Position,
                    higher: true,
                    result: out var nextRec))
            {
                var recordLocation = fileLocs.ListedRecords.Keys[nextRec.Key];
                noRecordLength = recordLocation - inputStream.Position;
            }
            else
            {
                noRecordLength = inputStream.Length - inputStream.Position;
            }
            inputStream.WriteTo(outputStream, (int)noRecordLength);

            // If complete overall, return
            if (inputStream.Complete) break;
            var majorMeta = inputStream.ReadMajorRecordHeader(readSafe: true);
            var len = majorMeta.ContentLength;
            using var frame = MutagenFrame.ByLength(
                reader: inputStream,
                length: len);
            
            // Decompress
            var decompressed = frame.Decompress();
            var decompressedLen = decompressed.TotalLength;
            var lengthDiff = decompressedLen - len;
            var majorMetaSpan = majorMeta.HeaderData.ToArray();

            // Write major Meta
            var writableMajorMeta = inputStream.MetaData.Constants.MajorRecordHeaderWritable(majorMetaSpan.AsSpan());
            writableMajorMeta.IsCompressed = false;
            writableMajorMeta.ContentLength = (uint)(len + lengthDiff);
            writer.Write(majorMetaSpan);
            writer.Write(decompressed.ReadRemainingSpan(readSafe: false));

            // If no difference in lengths, move on
            if (lengthDiff == 0) continue;

            // Modify parent group lengths
            foreach (var grupLoc in fileLocs.GetContainingGroupLocations(nextRec.Value.FormKey))
            {
                if (!grupMeta.TryGetValue(grupLoc, out var loc))
                {
                    loc.Offset = runningDiff;
                    inputStreamJumpback.Position = grupLoc + 4;
                    loc.Length = inputStreamJumpback.ReadUInt32();
                }
                grupMeta[grupLoc] = ((uint)(loc.Length + lengthDiff), loc.Offset);
            }
            runningDiff += lengthDiff;
        }

        foreach (var item in grupMeta)
        {
            var grupLoc = item.Key;
            outputStream.Position = grupLoc + 4 + item.Value.Offset;
            writer.Write(item.Value.Length);
        }
    }
}