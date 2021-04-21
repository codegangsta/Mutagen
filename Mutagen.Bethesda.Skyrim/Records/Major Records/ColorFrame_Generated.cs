/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Internals;
using Mutagen.Bethesda.Records;
using Mutagen.Bethesda.Records.Binary.Overlay;
using Mutagen.Bethesda.Records.Binary.Streams;
using Mutagen.Bethesda.Records.Binary.Translations;
using Mutagen.Bethesda.Skyrim.Internals;
using Noggog;
using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public partial class ColorFrame :
        IColorFrame,
        IEquatable<IColorFrameGetter>,
        ILoquiObjectSetter<ColorFrame>
    {
        #region Ctor
        public ColorFrame()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Time
        public Single Time { get; set; } = default;
        #endregion
        #region Color
        public Color Color { get; set; } = default;
        #endregion

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            ColorFrameMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IColorFrameGetter rhs) return false;
            return ((ColorFrameCommon)((IColorFrameGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IColorFrameGetter? obj)
        {
            return ((ColorFrameCommon)((IColorFrameGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((ColorFrameCommon)((IColorFrameGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.Time = initialValue;
                this.Color = initialValue;
            }

            public Mask(
                TItem Time,
                TItem Color)
            {
                this.Time = Time;
                this.Color = Color;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Time;
            public TItem Color;
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
                if (!object.Equals(this.Time, rhs.Time)) return false;
                if (!object.Equals(this.Color, rhs.Color)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Time);
                hash.Add(this.Color);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.Time)) return false;
                if (!eval(this.Color)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.Time)) return true;
                if (eval(this.Color)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new ColorFrame.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.Time = eval(this.Time);
                obj.Color = eval(this.Color);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(ColorFrame.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, ColorFrame.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(ColorFrame.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.Time ?? true)
                    {
                        fg.AppendItem(Time, "Time");
                    }
                    if (printMask?.Color ?? true)
                    {
                        fg.AppendItem(Color, "Color");
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
            public Exception? Time;
            public Exception? Color;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                ColorFrame_FieldIndex enu = (ColorFrame_FieldIndex)index;
                switch (enu)
                {
                    case ColorFrame_FieldIndex.Time:
                        return Time;
                    case ColorFrame_FieldIndex.Color:
                        return Color;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                ColorFrame_FieldIndex enu = (ColorFrame_FieldIndex)index;
                switch (enu)
                {
                    case ColorFrame_FieldIndex.Time:
                        this.Time = ex;
                        break;
                    case ColorFrame_FieldIndex.Color:
                        this.Color = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                ColorFrame_FieldIndex enu = (ColorFrame_FieldIndex)index;
                switch (enu)
                {
                    case ColorFrame_FieldIndex.Time:
                        this.Time = (Exception?)obj;
                        break;
                    case ColorFrame_FieldIndex.Color:
                        this.Color = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (Time != null) return true;
                if (Color != null) return true;
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
                fg.AppendItem(Time, "Time");
                fg.AppendItem(Color, "Color");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Time = this.Time.Combine(rhs.Time);
                ret.Color = this.Color.Combine(rhs.Color);
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
            public bool Time;
            public bool Color;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.Time = defaultOn;
                this.Color = defaultOn;
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
                ret.Add((Time, null));
                ret.Add((Color, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => ColorFrameBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ColorFrameBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #region Binary Create
        public static ColorFrame CreateFromBinary(
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new ColorFrame();
            ((ColorFrameSetterCommon)((IColorFrameGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out ColorFrame item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(frame, recordTypeConverter);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((ColorFrameSetterCommon)((IColorFrameGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static ColorFrame GetNew()
        {
            return new ColorFrame();
        }

    }
    #endregion

    #region Interface
    public partial interface IColorFrame :
        IColorFrameGetter,
        ILoquiObjectSetter<IColorFrame>
    {
        new Single Time { get; set; }
        new Color Color { get; set; }
    }

    public partial interface IColorFrameGetter :
        ILoquiObject,
        IBinaryItem,
        ILoquiObject<IColorFrameGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration Registration => ColorFrame_Registration.Instance;
        Single Time { get; }
        Color Color { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class ColorFrameMixIn
    {
        public static void Clear(this IColorFrame item)
        {
            ((ColorFrameSetterCommon)((IColorFrameGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static ColorFrame.Mask<bool> GetEqualsMask(
            this IColorFrameGetter item,
            IColorFrameGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((ColorFrameCommon)((IColorFrameGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IColorFrameGetter item,
            string? name = null,
            ColorFrame.Mask<bool>? printMask = null)
        {
            return ((ColorFrameCommon)((IColorFrameGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IColorFrameGetter item,
            FileGeneration fg,
            string? name = null,
            ColorFrame.Mask<bool>? printMask = null)
        {
            ((ColorFrameCommon)((IColorFrameGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IColorFrameGetter item,
            IColorFrameGetter rhs,
            ColorFrame.TranslationMask? equalsMask = null)
        {
            return ((ColorFrameCommon)((IColorFrameGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IColorFrame lhs,
            IColorFrameGetter rhs)
        {
            ((ColorFrameSetterTranslationCommon)((IColorFrameGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IColorFrame lhs,
            IColorFrameGetter rhs,
            ColorFrame.TranslationMask? copyMask = null)
        {
            ((ColorFrameSetterTranslationCommon)((IColorFrameGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IColorFrame lhs,
            IColorFrameGetter rhs,
            out ColorFrame.ErrorMask errorMask,
            ColorFrame.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((ColorFrameSetterTranslationCommon)((IColorFrameGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = ColorFrame.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IColorFrame lhs,
            IColorFrameGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((ColorFrameSetterTranslationCommon)((IColorFrameGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static ColorFrame DeepCopy(
            this IColorFrameGetter item,
            ColorFrame.TranslationMask? copyMask = null)
        {
            return ((ColorFrameSetterTranslationCommon)((IColorFrameGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static ColorFrame DeepCopy(
            this IColorFrameGetter item,
            out ColorFrame.ErrorMask errorMask,
            ColorFrame.TranslationMask? copyMask = null)
        {
            return ((ColorFrameSetterTranslationCommon)((IColorFrameGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static ColorFrame DeepCopy(
            this IColorFrameGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((ColorFrameSetterTranslationCommon)((IColorFrameGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IColorFrame item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ColorFrameSetterCommon)((IColorFrameGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim.Internals
{
    #region Field Index
    public enum ColorFrame_FieldIndex
    {
        Time = 0,
        Color = 1,
    }
    #endregion

    #region Registration
    public partial class ColorFrame_Registration : ILoquiRegistration
    {
        public static readonly ColorFrame_Registration Instance = new ColorFrame_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 411,
            version: 0);

        public const string GUID = "5e0778b8-259e-444a-9ff1-b0cdfaef88e1";

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(ColorFrame.Mask<>);

        public static readonly Type ErrorMaskType = typeof(ColorFrame.ErrorMask);

        public static readonly Type ClassType = typeof(ColorFrame);

        public static readonly Type GetterType = typeof(IColorFrameGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IColorFrame);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.ColorFrame";

        public const string Name = "ColorFrame";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(ColorFrameBinaryWriteTranslation);
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
    public partial class ColorFrameSetterCommon
    {
        public static readonly ColorFrameSetterCommon Instance = new ColorFrameSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IColorFrame item)
        {
            ClearPartial();
            item.Time = default;
            item.Color = default;
        }
        
        #region Mutagen
        public void RemapLinks(IColorFrame obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IColorFrame item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            UtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter,
                fillStructs: ColorFrameBinaryCreateTranslation.FillBinaryStructs);
        }
        
        #endregion
        
    }
    public partial class ColorFrameCommon
    {
        public static readonly ColorFrameCommon Instance = new ColorFrameCommon();

        public ColorFrame.Mask<bool> GetEqualsMask(
            IColorFrameGetter item,
            IColorFrameGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new ColorFrame.Mask<bool>(false);
            ((ColorFrameCommon)((IColorFrameGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IColorFrameGetter item,
            IColorFrameGetter rhs,
            ColorFrame.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Time = item.Time.EqualsWithin(rhs.Time);
            ret.Color = item.Color.ColorOnlyEquals(rhs.Color);
        }
        
        public string ToString(
            IColorFrameGetter item,
            string? name = null,
            ColorFrame.Mask<bool>? printMask = null)
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
            IColorFrameGetter item,
            FileGeneration fg,
            string? name = null,
            ColorFrame.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"ColorFrame =>");
            }
            else
            {
                fg.AppendLine($"{name} (ColorFrame) =>");
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
            IColorFrameGetter item,
            FileGeneration fg,
            ColorFrame.Mask<bool>? printMask = null)
        {
            if (printMask?.Time ?? true)
            {
                fg.AppendItem(item.Time, "Time");
            }
            if (printMask?.Color ?? true)
            {
                fg.AppendItem(item.Color, "Color");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IColorFrameGetter? lhs,
            IColorFrameGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if ((crystal?.GetShouldTranslate((int)ColorFrame_FieldIndex.Time) ?? true))
            {
                if (!lhs.Time.EqualsWithin(rhs.Time)) return false;
            }
            if ((crystal?.GetShouldTranslate((int)ColorFrame_FieldIndex.Color) ?? true))
            {
                if (!lhs.Color.ColorOnlyEquals(rhs.Color)) return false;
            }
            return true;
        }
        
        public virtual int GetHashCode(IColorFrameGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Time);
            hash.Add(item.Color);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return ColorFrame.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormLinkInformation> GetContainedFormLinks(IColorFrameGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    public partial class ColorFrameSetterTranslationCommon
    {
        public static readonly ColorFrameSetterTranslationCommon Instance = new ColorFrameSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IColorFrame item,
            IColorFrameGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)ColorFrame_FieldIndex.Time) ?? true))
            {
                item.Time = rhs.Time;
            }
            if ((copyMask?.GetShouldTranslate((int)ColorFrame_FieldIndex.Color) ?? true))
            {
                item.Color = rhs.Color;
            }
        }
        
        #endregion
        
        public ColorFrame DeepCopy(
            IColorFrameGetter item,
            ColorFrame.TranslationMask? copyMask = null)
        {
            ColorFrame ret = (ColorFrame)((ColorFrameCommon)((IColorFrameGetter)item).CommonInstance()!).GetNew();
            ((ColorFrameSetterTranslationCommon)((IColorFrameGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public ColorFrame DeepCopy(
            IColorFrameGetter item,
            out ColorFrame.ErrorMask errorMask,
            ColorFrame.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ColorFrame ret = (ColorFrame)((ColorFrameCommon)((IColorFrameGetter)item).CommonInstance()!).GetNew();
            ((ColorFrameSetterTranslationCommon)((IColorFrameGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = ColorFrame.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public ColorFrame DeepCopy(
            IColorFrameGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            ColorFrame ret = (ColorFrame)((ColorFrameCommon)((IColorFrameGetter)item).CommonInstance()!).GetNew();
            ((ColorFrameSetterTranslationCommon)((IColorFrameGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class ColorFrame
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ColorFrame_Registration.Instance;
        public static ColorFrame_Registration Registration => ColorFrame_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => ColorFrameCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return ColorFrameSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => ColorFrameSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IColorFrameGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IColorFrameGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IColorFrameGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class ColorFrameBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static ColorFrameBinaryWriteTranslation Instance = new ColorFrameBinaryWriteTranslation();

        public static void WriteEmbedded(
            IColorFrameGetter item,
            MutagenWriter writer)
        {
            Mutagen.Bethesda.Records.Binary.Translations.FloatBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Time);
            Mutagen.Bethesda.Records.Binary.Translations.ColorBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Color,
                binaryType: ColorBinaryType.AlphaFloat);
        }

        public void Write(
            MutagenWriter writer,
            IColorFrameGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IColorFrameGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class ColorFrameBinaryCreateTranslation
    {
        public readonly static ColorFrameBinaryCreateTranslation Instance = new ColorFrameBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IColorFrame item,
            MutagenFrame frame)
        {
            item.Time = Mutagen.Bethesda.Records.Binary.Translations.FloatBinaryTranslation.Instance.Parse(frame: frame);
            item.Color = frame.ReadColor(ColorBinaryType.AlphaFloat);
        }

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class ColorFrameBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IColorFrameGetter item,
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ColorFrameBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class ColorFrameBinaryOverlay :
        BinaryOverlay,
        IColorFrameGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ColorFrame_Registration.Instance;
        public static ColorFrame_Registration Registration => ColorFrame_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => ColorFrameCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => ColorFrameSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IColorFrameGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IColorFrameGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IColorFrameGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => ColorFrameBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ColorFrameBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public Single Time => _data.Slice(0x0, 0x4).Float();
        public Color Color => _data.Slice(0x4, 0x10).ReadColor(ColorBinaryType.AlphaFloat);
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected ColorFrameBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static ColorFrameBinaryOverlay ColorFrameFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new ColorFrameBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x14),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x14;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static ColorFrameBinaryOverlay ColorFrameFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            return ColorFrameFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                recordTypeConverter: recordTypeConverter);
        }

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            ColorFrameMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IColorFrameGetter rhs) return false;
            return ((ColorFrameCommon)((IColorFrameGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IColorFrameGetter? obj)
        {
            return ((ColorFrameCommon)((IColorFrameGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((ColorFrameCommon)((IColorFrameGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

