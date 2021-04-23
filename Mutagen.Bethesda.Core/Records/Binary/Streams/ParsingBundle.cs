using Mutagen.Bethesda.Records.Binary.Utility;
using Mutagen.Bethesda.Records.Constants;
using Mutagen.Bethesda.Strings;

namespace Mutagen.Bethesda.Records.Binary.Streams
{
    /// <summary>
    /// Class containing all the extra meta bits for parsing
    /// </summary>
    public class ParsingBundle
    {
        /// <summary>
        /// Game constants meta object to reference for header length measurements
        /// </summary>
        public GameConstants Constants { get; }

        /// <summary>
        /// MasterReferenceReader to reference while reading
        /// </summary>
        public MasterReferenceReader MasterReferences { get; }

        /// <summary>
        /// Optional RecordInfoCache to reference while reading
        /// </summary>
        public RecordInfoCache? RecordInfoCache { get; set; }

        /// <summary>
        /// Optional strings lookup to reference while reading
        /// </summary>
        public IStringsFolderLookup? StringsLookup { get; set; }

        /// <summary>
        /// Whether to do parallel work when possible
        /// </summary>
        public bool Parallel { get; set; }

        /// <summary>
        /// Tracker of whether within worldspace data section
        /// </summary>
        public bool InWorldspace { get; set; }

        /// <summary>
        /// Tracker of current major record version
        /// </summary>
        public ushort? FormVersion { get; set; }

        /// <summary>
        /// ModKey of the mod being parsed
        /// </summary>
        public ModKey ModKey { get; set; }

        public ParsingBundle(GameConstants constants, MasterReferenceReader masterReferences)
        {
            this.Constants = constants;
            this.MasterReferences = masterReferences;
        }

        public static implicit operator GameConstants(ParsingBundle bundle)
        {
            return bundle.Constants;
        }

        public void ReportIssue(RecordType? recordType, string note)
        {
            // Nothing for now.  Need to implement
        }
    }
}
