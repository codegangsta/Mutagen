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
using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Fallout4.Internals;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Cache;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Fallout4.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Fallout4.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Fallout4
{
    #region Class
    public partial class BookPerk :
        BookTeachTarget,
        IBookPerk,
        IEquatable<IBookPerkGetter>,
        ILoquiObjectSetter<BookPerk>
    {
        #region Ctor
        public BookPerk()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Perk
        private readonly IFormLink<IPerkGetter> _Perk = new FormLink<IPerkGetter>();
        public IFormLink<IPerkGetter> Perk
        {
            get => _Perk;
            set => _Perk.SetTo(value);
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IFormLinkGetter<IPerkGetter> IBookPerkGetter.Perk => this.Perk;
        #endregion

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            BookPerkMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IBookPerkGetter rhs) return false;
            return ((BookPerkCommon)((IBookPerkGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IBookPerkGetter? obj)
        {
            return ((BookPerkCommon)((IBookPerkGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((BookPerkCommon)((IBookPerkGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            BookTeachTarget.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem Perk)
            : base()
            {
                this.Perk = Perk;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Perk;
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
                if (!object.Equals(this.Perk, rhs.Perk)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Perk);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Perk)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Perk)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new BookPerk.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Perk = eval(this.Perk);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(BookPerk.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, BookPerk.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(BookPerk.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.Perk ?? true)
                    {
                        sb.AppendItem(Perk, "Perk");
                    }
                }
            }
            #endregion

        }

        public new class ErrorMask :
            BookTeachTarget.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Perk;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                BookPerk_FieldIndex enu = (BookPerk_FieldIndex)index;
                switch (enu)
                {
                    case BookPerk_FieldIndex.Perk:
                        return Perk;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                BookPerk_FieldIndex enu = (BookPerk_FieldIndex)index;
                switch (enu)
                {
                    case BookPerk_FieldIndex.Perk:
                        this.Perk = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                BookPerk_FieldIndex enu = (BookPerk_FieldIndex)index;
                switch (enu)
                {
                    case BookPerk_FieldIndex.Perk:
                        this.Perk = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Perk != null) return true;
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
                {
                    sb.AppendItem(Perk, "Perk");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Perk = this.Perk.Combine(rhs.Perk);
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
            BookTeachTarget.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Perk;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.Perk = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Perk, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public override IEnumerable<IFormLinkGetter> EnumerateFormLinks() => BookPerkCommon.Instance.EnumerateFormLinks(this);
        public override void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => BookPerkSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => BookPerkBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((BookPerkBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static BookPerk CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new BookPerk();
            ((BookPerkSetterCommon)((IBookPerkGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out BookPerk item,
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
            ((BookPerkSetterCommon)((IBookPerkGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new BookPerk GetNew()
        {
            return new BookPerk();
        }

    }
    #endregion

    #region Interface
    public partial interface IBookPerk :
        IBookPerkGetter,
        IBookTeachTarget,
        IFormLinkContainer,
        ILoquiObjectSetter<IBookPerk>
    {
        new IFormLink<IPerkGetter> Perk { get; set; }
    }

    public partial interface IBookPerkGetter :
        IBookTeachTargetGetter,
        IBinaryItem,
        IFormLinkContainerGetter,
        ILoquiObject<IBookPerkGetter>
    {
        static new ILoquiRegistration StaticRegistration => BookPerk_Registration.Instance;
        IFormLinkGetter<IPerkGetter> Perk { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class BookPerkMixIn
    {
        public static void Clear(this IBookPerk item)
        {
            ((BookPerkSetterCommon)((IBookPerkGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static BookPerk.Mask<bool> GetEqualsMask(
            this IBookPerkGetter item,
            IBookPerkGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((BookPerkCommon)((IBookPerkGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IBookPerkGetter item,
            string? name = null,
            BookPerk.Mask<bool>? printMask = null)
        {
            return ((BookPerkCommon)((IBookPerkGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IBookPerkGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            BookPerk.Mask<bool>? printMask = null)
        {
            ((BookPerkCommon)((IBookPerkGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IBookPerkGetter item,
            IBookPerkGetter rhs,
            BookPerk.TranslationMask? equalsMask = null)
        {
            return ((BookPerkCommon)((IBookPerkGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IBookPerk lhs,
            IBookPerkGetter rhs,
            out BookPerk.ErrorMask errorMask,
            BookPerk.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((BookPerkSetterTranslationCommon)((IBookPerkGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = BookPerk.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IBookPerk lhs,
            IBookPerkGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((BookPerkSetterTranslationCommon)((IBookPerkGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static BookPerk DeepCopy(
            this IBookPerkGetter item,
            BookPerk.TranslationMask? copyMask = null)
        {
            return ((BookPerkSetterTranslationCommon)((IBookPerkGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static BookPerk DeepCopy(
            this IBookPerkGetter item,
            out BookPerk.ErrorMask errorMask,
            BookPerk.TranslationMask? copyMask = null)
        {
            return ((BookPerkSetterTranslationCommon)((IBookPerkGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static BookPerk DeepCopy(
            this IBookPerkGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((BookPerkSetterTranslationCommon)((IBookPerkGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IBookPerk item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((BookPerkSetterCommon)((IBookPerkGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Fallout4
{
    #region Field Index
    internal enum BookPerk_FieldIndex
    {
        Perk = 0,
    }
    #endregion

    #region Registration
    internal partial class BookPerk_Registration : ILoquiRegistration
    {
        public static readonly BookPerk_Registration Instance = new BookPerk_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Fallout4.ProtocolKey;

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(BookPerk.Mask<>);

        public static readonly Type ErrorMaskType = typeof(BookPerk.ErrorMask);

        public static readonly Type ClassType = typeof(BookPerk);

        public static readonly Type GetterType = typeof(IBookPerkGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IBookPerk);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Fallout4.BookPerk";

        public const string Name = "BookPerk";

        public const string Namespace = "Mutagen.Bethesda.Fallout4";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(BookPerkBinaryWriteTranslation);
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
    internal partial class BookPerkSetterCommon : BookTeachTargetSetterCommon
    {
        public new static readonly BookPerkSetterCommon Instance = new BookPerkSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IBookPerk item)
        {
            ClearPartial();
            item.Perk.Clear();
            base.Clear(item);
        }
        
        public override void Clear(IBookTeachTarget item)
        {
            Clear(item: (IBookPerk)item);
        }
        
        #region Mutagen
        public void RemapLinks(IBookPerk obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
            obj.Perk.Relink(mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IBookPerk item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: BookPerkBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IBookTeachTarget item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            CopyInFromBinary(
                item: (BookPerk)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class BookPerkCommon : BookTeachTargetCommon
    {
        public new static readonly BookPerkCommon Instance = new BookPerkCommon();

        public BookPerk.Mask<bool> GetEqualsMask(
            IBookPerkGetter item,
            IBookPerkGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new BookPerk.Mask<bool>(false);
            ((BookPerkCommon)((IBookPerkGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IBookPerkGetter item,
            IBookPerkGetter rhs,
            BookPerk.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            ret.Perk = item.Perk.Equals(rhs.Perk);
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IBookPerkGetter item,
            string? name = null,
            BookPerk.Mask<bool>? printMask = null)
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
            IBookPerkGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            BookPerk.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"BookPerk =>");
            }
            else
            {
                sb.AppendLine($"{name} (BookPerk) =>");
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
            IBookPerkGetter item,
            StructuredStringBuilder sb,
            BookPerk.Mask<bool>? printMask = null)
        {
            BookTeachTargetCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
            if (printMask?.Perk ?? true)
            {
                sb.AppendItem(item.Perk.FormKey, "Perk");
            }
        }
        
        public static BookPerk_FieldIndex ConvertFieldIndex(BookTeachTarget_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IBookPerkGetter? lhs,
            IBookPerkGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IBookTeachTargetGetter)lhs, (IBookTeachTargetGetter)rhs, equalsMask)) return false;
            if ((equalsMask?.GetShouldTranslate((int)BookPerk_FieldIndex.Perk) ?? true))
            {
                if (!lhs.Perk.Equals(rhs.Perk)) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IBookTeachTargetGetter? lhs,
            IBookTeachTargetGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            return Equals(
                lhs: (IBookPerkGetter?)lhs,
                rhs: rhs as IBookPerkGetter,
                equalsMask: equalsMask);
        }
        
        public virtual int GetHashCode(IBookPerkGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Perk);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IBookTeachTargetGetter item)
        {
            return GetHashCode(item: (IBookPerkGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return BookPerk.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IBookPerkGetter obj)
        {
            foreach (var item in base.EnumerateFormLinks(obj))
            {
                yield return item;
            }
            yield return FormLinkInformation.Factory(obj.Perk);
            yield break;
        }
        
        #endregion
        
    }
    internal partial class BookPerkSetterTranslationCommon : BookTeachTargetSetterTranslationCommon
    {
        public new static readonly BookPerkSetterTranslationCommon Instance = new BookPerkSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IBookPerk item,
            IBookPerkGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IBookTeachTarget)item,
                (IBookTeachTargetGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)BookPerk_FieldIndex.Perk) ?? true))
            {
                item.Perk.SetTo(rhs.Perk.FormKey);
            }
        }
        
        
        public override void DeepCopyIn(
            IBookTeachTarget item,
            IBookTeachTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IBookPerk)item,
                rhs: (IBookPerkGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public BookPerk DeepCopy(
            IBookPerkGetter item,
            BookPerk.TranslationMask? copyMask = null)
        {
            BookPerk ret = (BookPerk)((BookPerkCommon)((IBookPerkGetter)item).CommonInstance()!).GetNew();
            ((BookPerkSetterTranslationCommon)((IBookPerkGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public BookPerk DeepCopy(
            IBookPerkGetter item,
            out BookPerk.ErrorMask errorMask,
            BookPerk.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            BookPerk ret = (BookPerk)((BookPerkCommon)((IBookPerkGetter)item).CommonInstance()!).GetNew();
            ((BookPerkSetterTranslationCommon)((IBookPerkGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = BookPerk.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public BookPerk DeepCopy(
            IBookPerkGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            BookPerk ret = (BookPerk)((BookPerkCommon)((IBookPerkGetter)item).CommonInstance()!).GetNew();
            ((BookPerkSetterTranslationCommon)((IBookPerkGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Fallout4
{
    public partial class BookPerk
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => BookPerk_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => BookPerk_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => BookPerkCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return BookPerkSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => BookPerkSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Fallout4
{
    public partial class BookPerkBinaryWriteTranslation :
        BookTeachTargetBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new static readonly BookPerkBinaryWriteTranslation Instance = new();

        public static void WriteEmbedded(
            IBookPerkGetter item,
            MutagenWriter writer)
        {
            FormLinkBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Perk);
        }

        public void Write(
            MutagenWriter writer,
            IBookPerkGetter item,
            TypedWriteParams translationParams)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (IBookPerkGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IBookTeachTargetGetter item,
            TypedWriteParams translationParams)
        {
            Write(
                item: (IBookPerkGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class BookPerkBinaryCreateTranslation : BookTeachTargetBinaryCreateTranslation
    {
        public new static readonly BookPerkBinaryCreateTranslation Instance = new BookPerkBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IBookPerk item,
            MutagenFrame frame)
        {
            item.Perk.SetTo(FormLinkBinaryTranslation.Instance.Parse(reader: frame));
        }

    }

}
namespace Mutagen.Bethesda.Fallout4
{
    #region Binary Write Mixins
    public static class BookPerkBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Fallout4
{
    internal partial class BookPerkBinaryOverlay :
        BookTeachTargetBinaryOverlay,
        IBookPerkGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => BookPerk_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => BookPerk_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => BookPerkCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => BookPerkSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        public override IEnumerable<IFormLinkGetter> EnumerateFormLinks() => BookPerkCommon.Instance.EnumerateFormLinks(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => BookPerkBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((BookPerkBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public IFormLinkGetter<IPerkGetter> Perk => new FormLink<IPerkGetter>(FormKey.Factory(_package.MetaData.MasterReferences!, BinaryPrimitives.ReadUInt32LittleEndian(_structData.Span.Slice(0x0, 0x4))));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected BookPerkBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static IBookPerkGetter BookPerkFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractTypelessSubrecordStructMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                length: 0x4,
                memoryPair: out var memoryPair,
                offset: out var offset);
            var ret = new BookPerkBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            stream.Position += 0x4;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static IBookPerkGetter BookPerkFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return BookPerkFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            BookPerkMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IBookPerkGetter rhs) return false;
            return ((BookPerkCommon)((IBookPerkGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IBookPerkGetter? obj)
        {
            return ((BookPerkCommon)((IBookPerkGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((BookPerkCommon)((IBookPerkGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

