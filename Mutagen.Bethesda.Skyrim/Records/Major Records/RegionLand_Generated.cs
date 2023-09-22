/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Interfaces;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Aspects;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Skyrim.Internals;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Skyrim.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Skyrim.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public partial class RegionLand :
        RegionData,
        IEquatable<IRegionLandGetter>,
        ILoquiObjectSetter<RegionLand>,
        IRegionLand
    {
        #region Ctor
        public RegionLand()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion


        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            RegionLandMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IRegionLandGetter rhs) return false;
            return ((RegionLandCommon)((IRegionLandGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IRegionLandGetter? obj)
        {
            return ((RegionLandCommon)((IRegionLandGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((RegionLandCommon)((IRegionLandGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            RegionData.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
            }

            public Mask(
                TItem Flags,
                TItem Priority,
                TItem Icons)
            : base(
                Flags: Flags,
                Priority: Priority,
                Icons: Icons)
            {
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Equals
            public override bool Equals(object? obj)
            {
                if (!(obj is Mask<TItem> rhs)) return false;
                return Equals(rhs);
            }

            public bool Equals(Mask<TItem>? rhs)
            {
                if (rhs == null) return false;
                if (!base.Equals(rhs)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new RegionLand.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(RegionLand.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, RegionLand.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(RegionLand.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                }
            }
            #endregion

        }

        public new class ErrorMask :
            RegionData.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                RegionLand_FieldIndex enu = (RegionLand_FieldIndex)index;
                switch (enu)
                {
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                RegionLand_FieldIndex enu = (RegionLand_FieldIndex)index;
                switch (enu)
                {
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                RegionLand_FieldIndex enu = (RegionLand_FieldIndex)index;
                switch (enu)
                {
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public override void Print(StructuredStringBuilder sb, string? name = null)
            {
                sb.AppendLine($"{(name ?? "ErrorMask")} =>");
                using (sb.Brace())
                {
                    if (this.Overall != null)
                    {
                        sb.AppendLine("Overall =>");
                        using (sb.Brace())
                        {
                            sb.AppendLine($"{this.Overall}");
                        }
                    }
                    PrintFillInternal(sb);
                }
            }
            protected override void PrintFillInternal(StructuredStringBuilder sb)
            {
                base.PrintFillInternal(sb);
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static new ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public new class TranslationMask :
            RegionData.TranslationMask,
            ITranslationMask
        {
            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
            }

            #endregion

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => RegionLandBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((RegionLandBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static RegionLand CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new RegionLand();
            ((RegionLandSetterCommon)((IRegionLandGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out RegionLand item,
            TypedParseParams translationParams = default)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(
                frame: frame,
                translationParams: translationParams);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        void IClearable.Clear()
        {
            ((RegionLandSetterCommon)((IRegionLandGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new RegionLand GetNew()
        {
            return new RegionLand();
        }

    }
    #endregion

    #region Interface
    public partial interface IRegionLand :
        IHasIcons,
        ILoquiObjectSetter<IRegionLand>,
        IRegionData,
        IRegionLandGetter
    {
    }

    public partial interface IRegionLandGetter :
        IRegionDataGetter,
        IBinaryItem,
        IHasIconsGetter,
        ILoquiObject<IRegionLandGetter>
    {
        static new ILoquiRegistration StaticRegistration => RegionLand_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class RegionLandMixIn
    {
        public static void Clear(this IRegionLand item)
        {
            ((RegionLandSetterCommon)((IRegionLandGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static RegionLand.Mask<bool> GetEqualsMask(
            this IRegionLandGetter item,
            IRegionLandGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((RegionLandCommon)((IRegionLandGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IRegionLandGetter item,
            string? name = null,
            RegionLand.Mask<bool>? printMask = null)
        {
            return ((RegionLandCommon)((IRegionLandGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IRegionLandGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            RegionLand.Mask<bool>? printMask = null)
        {
            ((RegionLandCommon)((IRegionLandGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IRegionLandGetter item,
            IRegionLandGetter rhs,
            RegionLand.TranslationMask? equalsMask = null)
        {
            return ((RegionLandCommon)((IRegionLandGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IRegionLand lhs,
            IRegionLandGetter rhs,
            out RegionLand.ErrorMask errorMask,
            RegionLand.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((RegionLandSetterTranslationCommon)((IRegionLandGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = RegionLand.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IRegionLand lhs,
            IRegionLandGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((RegionLandSetterTranslationCommon)((IRegionLandGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static RegionLand DeepCopy(
            this IRegionLandGetter item,
            RegionLand.TranslationMask? copyMask = null)
        {
            return ((RegionLandSetterTranslationCommon)((IRegionLandGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static RegionLand DeepCopy(
            this IRegionLandGetter item,
            out RegionLand.ErrorMask errorMask,
            RegionLand.TranslationMask? copyMask = null)
        {
            return ((RegionLandSetterTranslationCommon)((IRegionLandGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static RegionLand DeepCopy(
            this IRegionLandGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((RegionLandSetterTranslationCommon)((IRegionLandGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IRegionLand item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((RegionLandSetterCommon)((IRegionLandGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim
{
    #region Field Index
    internal enum RegionLand_FieldIndex
    {
        Flags = 0,
        Priority = 1,
        Icons = 2,
    }
    #endregion

    #region Registration
    internal partial class RegionLand_Registration : ILoquiRegistration
    {
        public static readonly RegionLand_Registration Instance = new RegionLand_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 3;

        public static readonly Type MaskType = typeof(RegionLand.Mask<>);

        public static readonly Type ErrorMaskType = typeof(RegionLand.ErrorMask);

        public static readonly Type ClassType = typeof(RegionLand);

        public static readonly Type GetterType = typeof(IRegionLandGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IRegionLand);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.RegionLand";

        public const string Name = "RegionLand";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly RecordType TriggeringRecordType = RecordTypes.RDAT;
        public static RecordTriggerSpecs TriggerSpecs => _recordSpecs.Value;
        private static readonly Lazy<RecordTriggerSpecs> _recordSpecs = new Lazy<RecordTriggerSpecs>(() =>
        {
            var all = RecordCollection.Factory(RecordTypes.RDAT);
            return new RecordTriggerSpecs(allRecordTypes: all);
        });
        public static readonly Type BinaryWriteTranslation = typeof(RegionLandBinaryWriteTranslation);
        #region Interface
        ProtocolKey ILoquiRegistration.ProtocolKey => ProtocolKey;
        ushort ILoquiRegistration.FieldCount => FieldCount;
        ushort ILoquiRegistration.AdditionalFieldCount => AdditionalFieldCount;
        Type ILoquiRegistration.MaskType => MaskType;
        Type ILoquiRegistration.ErrorMaskType => ErrorMaskType;
        Type ILoquiRegistration.ClassType => ClassType;
        Type ILoquiRegistration.SetterType => SetterType;
        Type? ILoquiRegistration.InternalSetterType => InternalSetterType;
        Type ILoquiRegistration.GetterType => GetterType;
        Type? ILoquiRegistration.InternalGetterType => InternalGetterType;
        string ILoquiRegistration.FullName => FullName;
        string ILoquiRegistration.Name => Name;
        string ILoquiRegistration.Namespace => Namespace;
        byte ILoquiRegistration.GenericCount => GenericCount;
        Type? ILoquiRegistration.GenericRegistrationType => GenericRegistrationType;
        ushort? ILoquiRegistration.GetNameIndex(StringCaseAgnostic name) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsEnumerable(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsLoqui(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsSingleton(ushort index) => throw new NotImplementedException();
        string ILoquiRegistration.GetNthName(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsNthDerivative(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsProtected(ushort index) => throw new NotImplementedException();
        Type ILoquiRegistration.GetNthType(ushort index) => throw new NotImplementedException();
        #endregion

    }
    #endregion

    #region Common
    internal partial class RegionLandSetterCommon : RegionDataSetterCommon
    {
        public new static readonly RegionLandSetterCommon Instance = new RegionLandSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IRegionLand item)
        {
            ClearPartial();
            base.Clear(item);
        }
        
        public override void Clear(IRegionData item)
        {
            Clear(item: (IRegionLand)item);
        }
        
        #region Mutagen
        public void RemapLinks(IRegionLand obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IRegionLand item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: RegionLandBinaryCreateTranslation.FillBinaryStructs,
                fillTyped: RegionLandBinaryCreateTranslation.FillBinaryRecordTypes);
        }
        
        public override void CopyInFromBinary(
            IRegionData item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            CopyInFromBinary(
                item: (RegionLand)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class RegionLandCommon : RegionDataCommon
    {
        public new static readonly RegionLandCommon Instance = new RegionLandCommon();

        public RegionLand.Mask<bool> GetEqualsMask(
            IRegionLandGetter item,
            IRegionLandGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new RegionLand.Mask<bool>(false);
            ((RegionLandCommon)((IRegionLandGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IRegionLandGetter item,
            IRegionLandGetter rhs,
            RegionLand.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IRegionLandGetter item,
            string? name = null,
            RegionLand.Mask<bool>? printMask = null)
        {
            var sb = new StructuredStringBuilder();
            Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
            return sb.ToString();
        }
        
        public void Print(
            IRegionLandGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            RegionLand.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"RegionLand =>");
            }
            else
            {
                sb.AppendLine($"{name} (RegionLand) =>");
            }
            using (sb.Brace())
            {
                ToStringFields(
                    item: item,
                    sb: sb,
                    printMask: printMask);
            }
        }
        
        protected static void ToStringFields(
            IRegionLandGetter item,
            StructuredStringBuilder sb,
            RegionLand.Mask<bool>? printMask = null)
        {
            RegionDataCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
        }
        
        public static RegionLand_FieldIndex ConvertFieldIndex(RegionData_FieldIndex index)
        {
            switch (index)
            {
                case RegionData_FieldIndex.Flags:
                    return (RegionLand_FieldIndex)((int)index);
                case RegionData_FieldIndex.Priority:
                    return (RegionLand_FieldIndex)((int)index);
                case RegionData_FieldIndex.Icons:
                    return (RegionLand_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IRegionLandGetter? lhs,
            IRegionLandGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IRegionDataGetter)lhs, (IRegionDataGetter)rhs, equalsMask)) return false;
            return true;
        }
        
        public override bool Equals(
            IRegionDataGetter? lhs,
            IRegionDataGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            return Equals(
                lhs: (IRegionLandGetter?)lhs,
                rhs: rhs as IRegionLandGetter,
                equalsMask: equalsMask);
        }
        
        public virtual int GetHashCode(IRegionLandGetter item)
        {
            var hash = new HashCode();
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IRegionDataGetter item)
        {
            return GetHashCode(item: (IRegionLandGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return RegionLand.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IRegionLandGetter obj)
        {
            foreach (var item in base.EnumerateFormLinks(obj))
            {
                yield return item;
            }
            yield break;
        }
        
        #endregion
        
    }
    internal partial class RegionLandSetterTranslationCommon : RegionDataSetterTranslationCommon
    {
        public new static readonly RegionLandSetterTranslationCommon Instance = new RegionLandSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IRegionLand item,
            IRegionLandGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IRegionData)item,
                (IRegionDataGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
        }
        
        
        public override void DeepCopyIn(
            IRegionData item,
            IRegionDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IRegionLand)item,
                rhs: (IRegionLandGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public RegionLand DeepCopy(
            IRegionLandGetter item,
            RegionLand.TranslationMask? copyMask = null)
        {
            RegionLand ret = (RegionLand)((RegionLandCommon)((IRegionLandGetter)item).CommonInstance()!).GetNew();
            ((RegionLandSetterTranslationCommon)((IRegionLandGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public RegionLand DeepCopy(
            IRegionLandGetter item,
            out RegionLand.ErrorMask errorMask,
            RegionLand.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            RegionLand ret = (RegionLand)((RegionLandCommon)((IRegionLandGetter)item).CommonInstance()!).GetNew();
            ((RegionLandSetterTranslationCommon)((IRegionLandGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = RegionLand.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public RegionLand DeepCopy(
            IRegionLandGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            RegionLand ret = (RegionLand)((RegionLandCommon)((IRegionLandGetter)item).CommonInstance()!).GetNew();
            ((RegionLandSetterTranslationCommon)((IRegionLandGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: true);
            return ret;
        }
        
    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim
{
    public partial class RegionLand
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => RegionLand_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => RegionLand_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => RegionLandCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return RegionLandSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => RegionLandSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim
{
    public partial class RegionLandBinaryWriteTranslation :
        RegionDataBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new static readonly RegionLandBinaryWriteTranslation Instance = new();

        public void Write(
            MutagenWriter writer,
            IRegionLandGetter item,
            TypedWriteParams translationParams)
        {
            RegionDataBinaryWriteTranslation.WriteEmbedded(
                item: item,
                writer: writer);
            RegionDataBinaryWriteTranslation.WriteRecordTypes(
                item: item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (IRegionLandGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IRegionDataGetter item,
            TypedWriteParams translationParams)
        {
            Write(
                item: (IRegionLandGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class RegionLandBinaryCreateTranslation : RegionDataBinaryCreateTranslation
    {
        public new static readonly RegionLandBinaryCreateTranslation Instance = new RegionLandBinaryCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class RegionLandBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim
{
    internal partial class RegionLandBinaryOverlay :
        RegionDataBinaryOverlay,
        IRegionLandGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => RegionLand_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => RegionLand_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => RegionLandCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => RegionLandSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => RegionLandBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((RegionLandBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected RegionLandBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static IRegionLandGetter RegionLandFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractTypelessSubrecordRecordMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                memoryPair: out var memoryPair,
                offset: out var offset,
                finalPos: out var finalPos);
            var ret = new RegionLandBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            ret.FillTypelessSubrecordTypes(
                stream: stream,
                finalPos: stream.Length,
                offset: offset,
                translationParams: translationParams,
                fill: ret.FillRecordType);
            return ret;
        }

        public static IRegionLandGetter RegionLandFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return RegionLandFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            RegionLandMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IRegionLandGetter rhs) return false;
            return ((RegionLandCommon)((IRegionLandGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IRegionLandGetter? obj)
        {
            return ((RegionLandCommon)((IRegionLandGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((RegionLandCommon)((IRegionLandGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

