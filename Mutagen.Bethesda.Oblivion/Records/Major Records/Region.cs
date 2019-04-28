using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Oblivion.Internals;

namespace Mutagen.Bethesda.Oblivion
{
    public partial class Region
    {
        public static readonly int RDAT_LEN = 14;
        public static readonly RecordType RDOT = new RecordType("RDOT");
        public static readonly RecordType RDWT = new RecordType("RDWT");
        public static readonly RecordType RDMP = new RecordType("RDMP");
        public static readonly RecordType ICON = new RecordType("ICON");
        public static readonly RecordType RDGS = new RecordType("RDGS");
        public static readonly RecordType RDSD = new RecordType("RDSD");
        public static readonly RecordType RDMD = new RecordType("RDMD");

        static partial void FillBinary_RegionAreaLogic_Custom(MutagenFrame frame, Region item, MasterReferences masterReferences, ErrorMaskBuilder errorMask)
        {
            var rdat = HeaderTranslation.GetNextSubRecordType(frame.Reader, out var rdatType);
            while (rdat.Equals(Region_Registration.RDAT_HEADER))
            {
                ParseRegionData(frame, item, masterReferences, errorMask);
                if (frame.Complete) break;
                rdat = HeaderTranslation.GetNextSubRecordType(frame.Reader, out rdatType);
            }
        }

        static void ParseRegionData(MutagenFrame frame, Region item, MasterReferences masterReferences, ErrorMaskBuilder errorMask)
        {
            RegionData.RegionDataType dataType = (RegionData.RegionDataType)frame.Reader.GetUInt32(offset: 6);
            var recType = HeaderTranslation.GetNextSubRecordType(
                frame.Reader,
                out var len,
                offset: 14);
            switch (dataType)
            {
                case RegionData.RegionDataType.Objects:
                    if (!recType.Equals(RDOT))
                    {
                        len = -6;
                    }
                    break;
                case RegionData.RegionDataType.Weather:
                    if (!recType.Equals(RDWT))
                    {
                        len = -6;
                    }
                    break;
                case RegionData.RegionDataType.MapName:
                    if (!recType.Equals(RDMP))
                    {
                        len = -6;
                    }
                    break;
                case RegionData.RegionDataType.Icon:
                    if (!recType.Equals(ICON))
                    {
                        len = -6;
                    }
                    break;
                case RegionData.RegionDataType.Grasses:
                    if (!recType.Equals(RDGS))
                    {
                        len = -6;
                    }
                    break;
                case RegionData.RegionDataType.Sounds:
                    if (!recType.Equals(RDSD) && !recType.Equals(RDMD))
                    {
                        len = -6;
                    }
                    break;
                default:
                    break;
            }
            len += RDAT_LEN + 6;
            switch (dataType)
            {
                case RegionData.RegionDataType.Objects:
                    item.Objects = RegionDataObjects.Create_Binary(frame.SpawnWithLength(len, checkFraming: false), masterReferences);
                    break;
                case RegionData.RegionDataType.MapName:
                    item.MapName = RegionDataMapName.Create_Binary(frame.SpawnWithLength(len, checkFraming: false), masterReferences);
                    break;
                case RegionData.RegionDataType.Grasses:
                    item.Grasses = RegionDataGrasses.Create_Binary(frame.SpawnWithLength(len, checkFraming: false), masterReferences);
                    break;
                case RegionData.RegionDataType.Sounds:
                    var nextRec = HeaderTranslation.GetNextSubRecordType(frame.Reader, out var nextLen, offset: len);
                    if (nextRec.Equals(RDSD) || nextRec.Equals(RDMD))
                    {
                        len += nextLen + 6;
                    }
                    item.Sounds = RegionDataSounds.Create_Binary(frame.SpawnWithLength(len, checkFraming: false), masterReferences);
                    break;
                case RegionData.RegionDataType.Weather:
                    item.Weather = RegionDataWeather.Create_Binary(frame.SpawnWithLength(len, checkFraming: false), masterReferences);
                    break;
                case RegionData.RegionDataType.Icon:
                    frame.Position += 6 + RDAT_LEN;
                    len = len - 6 - RDAT_LEN;
                    if (StringBinaryTranslation.Instance.Parse(
                        frame.SpawnWithLength(len, checkFraming: false),
                        out var iconVal))
                    {
                        item.Icon = iconVal;
                    }
                    else
                    {
                        item.Icon_Unset();
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        static partial void WriteBinary_RegionAreaLogic_Custom(MutagenWriter writer, Region item, MasterReferences masterReferences, ErrorMaskBuilder errorMask)
        {
            if (item.Objects_IsSet)
            {
                item.Objects.Write_Binary(writer, masterReferences);
            }
            if (item.Weather_IsSet)
            {
                item.Weather.Write_Binary(writer, masterReferences);
            }
            if (item.MapName_IsSet)
            {
                item.MapName.Write_Binary(writer, masterReferences);
            }
            if (item.Grasses_IsSet)
            {
                item.Grasses.Write_Binary(writer, masterReferences);
            }
            if (item.Sounds_IsSet)
            {
                item.Sounds.Write_Binary(writer, masterReferences);
            }
        }
    }
}
