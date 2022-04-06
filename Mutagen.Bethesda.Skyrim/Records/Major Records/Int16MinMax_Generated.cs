/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Skyrim.Internals;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using RecordTypeInts = Mutagen.Bethesda.Skyrim.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Skyrim.Internals.RecordTypes;
using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public partial class Int16MinMax :
        IEquatable<IInt16MinMaxGetter>,
        IInt16MinMax,
        ILoquiObjectSetter<Int16MinMax>
    {
        #region Ctor
        public Int16MinMax()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Min
        public Int16 Min { get; set; } = default;
        #endregion
        #region Max
        public Int16 Max { get; set; } = default;
        #endregion

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            Int16MinMaxMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IInt16MinMaxGetter rhs) return false;
            return ((Int16MinMaxCommon)((IInt16MinMaxGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IInt16MinMaxGetter? obj)
        {
            return ((Int16MinMaxCommon)((IInt16MinMaxGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((Int16MinMaxCommon)((IInt16MinMaxGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.Min = initialValue;
                this.Max = initialValue;
            }

            public Mask(
                TItem Min,
                TItem Max)
            {
                this.Min = Min;
                this.Max = Max;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Min;
            public TItem Max;
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
                if (!object.Equals(this.Min, rhs.Min)) return false;
                if (!object.Equals(this.Max, rhs.Max)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Min);
                hash.Add(this.Max);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.Min)) return false;
                if (!eval(this.Max)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.Min)) return true;
                if (eval(this.Max)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new Int16MinMax.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.Min = eval(this.Min);
                obj.Max = eval(this.Max);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(Int16MinMax.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, Int16MinMax.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(Int16MinMax.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.Min ?? true)
                    {
                        fg.AppendItem(Min, "Min");
                    }
                    if (printMask?.Max ?? true)
                    {
                        fg.AppendItem(Max, "Max");
                    }
                }
                fg.AppendLine("]");
            }
            #endregion

        }

        public class ErrorMask :
            IErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Overall { get; set; }
            private List<string>? _warnings;
            public List<string> Warnings
            {
                get
                {
                    if (_warnings == null)
                    {
                        _warnings = new List<string>();
                    }
                    return _warnings;
                }
            }
            public Exception? Min;
            public Exception? Max;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                Int16MinMax_FieldIndex enu = (Int16MinMax_FieldIndex)index;
                switch (enu)
                {
                    case Int16MinMax_FieldIndex.Min:
                        return Min;
                    case Int16MinMax_FieldIndex.Max:
                        return Max;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                Int16MinMax_FieldIndex enu = (Int16MinMax_FieldIndex)index;
                switch (enu)
                {
                    case Int16MinMax_FieldIndex.Min:
                        this.Min = ex;
                        break;
                    case Int16MinMax_FieldIndex.Max:
                        this.Max = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                Int16MinMax_FieldIndex enu = (Int16MinMax_FieldIndex)index;
                switch (enu)
                {
                    case Int16MinMax_FieldIndex.Min:
                        this.Min = (Exception?)obj;
                        break;
                    case Int16MinMax_FieldIndex.Max:
                        this.Max = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (Min != null) return true;
                if (Max != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString()
            {
                var fg = new FileGeneration();
                ToString(fg, null);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, string? name = null)
            {
                fg.AppendLine($"{(name ?? "ErrorMask")} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (this.Overall != null)
                    {
                        fg.AppendLine("Overall =>");
                        fg.AppendLine("[");
                        using (new DepthWrapper(fg))
                        {
                            fg.AppendLine($"{this.Overall}");
                        }
                        fg.AppendLine("]");
                    }
                    ToString_FillInternal(fg);
                }
                fg.AppendLine("]");
            }
            protected void ToString_FillInternal(FileGeneration fg)
            {
                fg.AppendItem(Min, "Min");
                fg.AppendItem(Max, "Max");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Min = this.Min.Combine(rhs.Min);
                ret.Max = this.Max.Combine(rhs.Max);
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public class TranslationMask : ITranslationMask
        {
            #region Members
            private TranslationCrystal? _crystal;
            public readonly bool DefaultOn;
            public bool OnOverall;
            public bool Min;
            public bool Max;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.Min = defaultOn;
                this.Max = defaultOn;
            }

            #endregion

            public TranslationCrystal GetCrystal()
            {
                if (_crystal != null) return _crystal;
                var ret = new List<(bool On, TranslationCrystal? SubCrystal)>();
                GetCrystal(ret);
                _crystal = new TranslationCrystal(ret.ToArray());
                return _crystal;
            }

            protected void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                ret.Add((Min, null));
                ret.Add((Max, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => Int16MinMaxBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((Int16MinMaxBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public static Int16MinMax CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            var ret = new Int16MinMax();
            ((Int16MinMaxSetterCommon)((IInt16MinMaxGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out Int16MinMax item,
            TypedParseParams? translationParams = null)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(
                frame: frame,
                translationParams: translationParams);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((Int16MinMaxSetterCommon)((IInt16MinMaxGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static Int16MinMax GetNew()
        {
            return new Int16MinMax();
        }

    }
    #endregion

    #region Interface
    public partial interface IInt16MinMax :
        IInt16MinMaxGetter,
        ILoquiObjectSetter<IInt16MinMax>
    {
        new Int16 Min { get; set; }
        new Int16 Max { get; set; }
    }

    public partial interface IInt16MinMaxGetter :
        ILoquiObject,
        IBinaryItem,
        ILoquiObject<IInt16MinMaxGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration StaticRegistration => Int16MinMax_Registration.Instance;
        Int16 Min { get; }
        Int16 Max { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class Int16MinMaxMixIn
    {
        public static void Clear(this IInt16MinMax item)
        {
            ((Int16MinMaxSetterCommon)((IInt16MinMaxGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static Int16MinMax.Mask<bool> GetEqualsMask(
            this IInt16MinMaxGetter item,
            IInt16MinMaxGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((Int16MinMaxCommon)((IInt16MinMaxGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IInt16MinMaxGetter item,
            string? name = null,
            Int16MinMax.Mask<bool>? printMask = null)
        {
            return ((Int16MinMaxCommon)((IInt16MinMaxGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IInt16MinMaxGetter item,
            FileGeneration fg,
            string? name = null,
            Int16MinMax.Mask<bool>? printMask = null)
        {
            ((Int16MinMaxCommon)((IInt16MinMaxGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IInt16MinMaxGetter item,
            IInt16MinMaxGetter rhs,
            Int16MinMax.TranslationMask? equalsMask = null)
        {
            return ((Int16MinMaxCommon)((IInt16MinMaxGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IInt16MinMax lhs,
            IInt16MinMaxGetter rhs)
        {
            ((Int16MinMaxSetterTranslationCommon)((IInt16MinMaxGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IInt16MinMax lhs,
            IInt16MinMaxGetter rhs,
            Int16MinMax.TranslationMask? copyMask = null)
        {
            ((Int16MinMaxSetterTranslationCommon)((IInt16MinMaxGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IInt16MinMax lhs,
            IInt16MinMaxGetter rhs,
            out Int16MinMax.ErrorMask errorMask,
            Int16MinMax.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((Int16MinMaxSetterTranslationCommon)((IInt16MinMaxGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = Int16MinMax.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IInt16MinMax lhs,
            IInt16MinMaxGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((Int16MinMaxSetterTranslationCommon)((IInt16MinMaxGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static Int16MinMax DeepCopy(
            this IInt16MinMaxGetter item,
            Int16MinMax.TranslationMask? copyMask = null)
        {
            return ((Int16MinMaxSetterTranslationCommon)((IInt16MinMaxGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static Int16MinMax DeepCopy(
            this IInt16MinMaxGetter item,
            out Int16MinMax.ErrorMask errorMask,
            Int16MinMax.TranslationMask? copyMask = null)
        {
            return ((Int16MinMaxSetterTranslationCommon)((IInt16MinMaxGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static Int16MinMax DeepCopy(
            this IInt16MinMaxGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((Int16MinMaxSetterTranslationCommon)((IInt16MinMaxGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IInt16MinMax item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            ((Int16MinMaxSetterCommon)((IInt16MinMaxGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    internal enum Int16MinMax_FieldIndex
    {
        Min = 0,
        Max = 1,
    }
    #endregion

    #region Registration
    internal partial class Int16MinMax_Registration : ILoquiRegistration
    {
        public static readonly Int16MinMax_Registration Instance = new Int16MinMax_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 400,
            version: 0);

        public const string GUID = "9995601d-590f-4c49-ab44-b7adcff80f3d";

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(Int16MinMax.Mask<>);

        public static readonly Type ErrorMaskType = typeof(Int16MinMax.ErrorMask);

        public static readonly Type ClassType = typeof(Int16MinMax);

        public static readonly Type GetterType = typeof(IInt16MinMaxGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IInt16MinMax);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.Int16MinMax";

        public const string Name = "Int16MinMax";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(Int16MinMaxBinaryWriteTranslation);
        #region Interface
        ProtocolKey ILoquiRegistration.ProtocolKey => ProtocolKey;
        ObjectKey ILoquiRegistration.ObjectKey => ObjectKey;
        string ILoquiRegistration.GUID => GUID;
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
    internal partial class Int16MinMaxSetterCommon
    {
        public static readonly Int16MinMaxSetterCommon Instance = new Int16MinMaxSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IInt16MinMax item)
        {
            ClearPartial();
            item.Min = default;
            item.Max = default;
        }
        
        #region Mutagen
        public void RemapLinks(IInt16MinMax obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IInt16MinMax item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: Int16MinMaxBinaryCreateTranslation.FillBinaryStructs);
        }
        
        #endregion
        
    }
    internal partial class Int16MinMaxCommon
    {
        public static readonly Int16MinMaxCommon Instance = new Int16MinMaxCommon();

        public Int16MinMax.Mask<bool> GetEqualsMask(
            IInt16MinMaxGetter item,
            IInt16MinMaxGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new Int16MinMax.Mask<bool>(false);
            ((Int16MinMaxCommon)((IInt16MinMaxGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IInt16MinMaxGetter item,
            IInt16MinMaxGetter rhs,
            Int16MinMax.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Min = item.Min == rhs.Min;
            ret.Max = item.Max == rhs.Max;
        }
        
        public string ToString(
            IInt16MinMaxGetter item,
            string? name = null,
            Int16MinMax.Mask<bool>? printMask = null)
        {
            var fg = new FileGeneration();
            ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
            return fg.ToString();
        }
        
        public void ToString(
            IInt16MinMaxGetter item,
            FileGeneration fg,
            string? name = null,
            Int16MinMax.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"Int16MinMax =>");
            }
            else
            {
                fg.AppendLine($"{name} (Int16MinMax) =>");
            }
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
                ToStringFields(
                    item: item,
                    fg: fg,
                    printMask: printMask);
            }
            fg.AppendLine("]");
        }
        
        protected static void ToStringFields(
            IInt16MinMaxGetter item,
            FileGeneration fg,
            Int16MinMax.Mask<bool>? printMask = null)
        {
            if (printMask?.Min ?? true)
            {
                fg.AppendItem(item.Min, "Min");
            }
            if (printMask?.Max ?? true)
            {
                fg.AppendItem(item.Max, "Max");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IInt16MinMaxGetter? lhs,
            IInt16MinMaxGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if ((crystal?.GetShouldTranslate((int)Int16MinMax_FieldIndex.Min) ?? true))
            {
                if (lhs.Min != rhs.Min) return false;
            }
            if ((crystal?.GetShouldTranslate((int)Int16MinMax_FieldIndex.Max) ?? true))
            {
                if (lhs.Max != rhs.Max) return false;
            }
            return true;
        }
        
        public virtual int GetHashCode(IInt16MinMaxGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Min);
            hash.Add(item.Max);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return Int16MinMax.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> GetContainedFormLinks(IInt16MinMaxGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    internal partial class Int16MinMaxSetterTranslationCommon
    {
        public static readonly Int16MinMaxSetterTranslationCommon Instance = new Int16MinMaxSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IInt16MinMax item,
            IInt16MinMaxGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)Int16MinMax_FieldIndex.Min) ?? true))
            {
                item.Min = rhs.Min;
            }
            if ((copyMask?.GetShouldTranslate((int)Int16MinMax_FieldIndex.Max) ?? true))
            {
                item.Max = rhs.Max;
            }
        }
        
        #endregion
        
        public Int16MinMax DeepCopy(
            IInt16MinMaxGetter item,
            Int16MinMax.TranslationMask? copyMask = null)
        {
            Int16MinMax ret = (Int16MinMax)((Int16MinMaxCommon)((IInt16MinMaxGetter)item).CommonInstance()!).GetNew();
            ((Int16MinMaxSetterTranslationCommon)((IInt16MinMaxGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public Int16MinMax DeepCopy(
            IInt16MinMaxGetter item,
            out Int16MinMax.ErrorMask errorMask,
            Int16MinMax.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            Int16MinMax ret = (Int16MinMax)((Int16MinMaxCommon)((IInt16MinMaxGetter)item).CommonInstance()!).GetNew();
            ((Int16MinMaxSetterTranslationCommon)((IInt16MinMaxGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = Int16MinMax.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public Int16MinMax DeepCopy(
            IInt16MinMaxGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            Int16MinMax ret = (Int16MinMax)((Int16MinMaxCommon)((IInt16MinMaxGetter)item).CommonInstance()!).GetNew();
            ((Int16MinMaxSetterTranslationCommon)((IInt16MinMaxGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class Int16MinMax
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => Int16MinMax_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => Int16MinMax_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => Int16MinMaxCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return Int16MinMaxSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => Int16MinMaxSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IInt16MinMaxGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IInt16MinMaxGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IInt16MinMaxGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim
{
    public partial class Int16MinMaxBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static Int16MinMaxBinaryWriteTranslation Instance = new Int16MinMaxBinaryWriteTranslation();

        public static void WriteEmbedded(
            IInt16MinMaxGetter item,
            MutagenWriter writer)
        {
            writer.Write(item.Min);
            writer.Write(item.Max);
        }

        public void Write(
            MutagenWriter writer,
            IInt16MinMaxGetter item,
            TypedWriteParams? translationParams = null)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (IInt16MinMaxGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class Int16MinMaxBinaryCreateTranslation
    {
        public readonly static Int16MinMaxBinaryCreateTranslation Instance = new Int16MinMaxBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IInt16MinMax item,
            MutagenFrame frame)
        {
            item.Min = frame.ReadInt16();
            item.Max = frame.ReadInt16();
        }

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class Int16MinMaxBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IInt16MinMaxGetter item,
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((Int16MinMaxBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                translationParams: translationParams);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim
{
    internal partial class Int16MinMaxBinaryOverlay :
        PluginBinaryOverlay,
        IInt16MinMaxGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => Int16MinMax_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => Int16MinMax_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => Int16MinMaxCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => Int16MinMaxSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IInt16MinMaxGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IInt16MinMaxGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IInt16MinMaxGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => Int16MinMaxBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((Int16MinMaxBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public Int16 Min => BinaryPrimitives.ReadInt16LittleEndian(_data.Slice(0x0, 0x2));
        public Int16 Max => BinaryPrimitives.ReadInt16LittleEndian(_data.Slice(0x2, 0x2));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected Int16MinMaxBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static Int16MinMaxBinaryOverlay Int16MinMaxFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? parseParams = null)
        {
            var ret = new Int16MinMaxBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x4),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x4;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static Int16MinMaxBinaryOverlay Int16MinMaxFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? parseParams = null)
        {
            return Int16MinMaxFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                parseParams: parseParams);
        }

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            Int16MinMaxMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IInt16MinMaxGetter rhs) return false;
            return ((Int16MinMaxCommon)((IInt16MinMaxGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IInt16MinMaxGetter? obj)
        {
            return ((Int16MinMaxCommon)((IInt16MinMaxGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((Int16MinMaxCommon)((IInt16MinMaxGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

