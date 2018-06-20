/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loqui;
using Noggog;
using Noggog.Notifying;
using Mutagen.Bethesda.Oblivion.Internals;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using Noggog.Xml;
using Loqui.Xml;
using Loqui.Internal;
using System.Diagnostics;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Internals;

namespace Mutagen.Bethesda.Oblivion
{
    #region Class
    public abstract partial class ScriptReference : IScriptReference, ILoquiObject<ScriptReference>, ILoquiObjectSetter, IEquatable<ScriptReference>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ScriptReference_Registration.Instance;
        public static ScriptReference_Registration Registration => ScriptReference_Registration.Instance;

        #region Ctor
        public ScriptReference()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion


        #region Loqui Getter Interface

        protected virtual object GetNthObject(ushort index) => ScriptReferenceCommon.GetNthObject(index, this);
        object ILoquiObjectGetter.GetNthObject(ushort index) => this.GetNthObject(index);

        protected virtual bool GetNthObjectHasBeenSet(ushort index) => ScriptReferenceCommon.GetNthObjectHasBeenSet(index, this);
        bool ILoquiObjectGetter.GetNthObjectHasBeenSet(ushort index) => this.GetNthObjectHasBeenSet(index);

        protected virtual void UnsetNthObject(ushort index, NotifyingUnsetParameters cmds) => ScriptReferenceCommon.UnsetNthObject(index, this, cmds);
        void ILoquiObjectSetter.UnsetNthObject(ushort index, NotifyingUnsetParameters cmds) => this.UnsetNthObject(index, cmds);

        #endregion

        #region Loqui Interface
        protected virtual void SetNthObjectHasBeenSet(ushort index, bool on)
        {
            ScriptReferenceCommon.SetNthObjectHasBeenSet(index, on, this);
        }
        void ILoquiObjectSetter.SetNthObjectHasBeenSet(ushort index, bool on) => this.SetNthObjectHasBeenSet(index, on);

        #endregion

        IMask<bool> IEqualsMask<ScriptReference>.GetEqualsMask(ScriptReference rhs) => ScriptReferenceCommon.GetEqualsMask(this, rhs);
        IMask<bool> IEqualsMask<IScriptReferenceGetter>.GetEqualsMask(IScriptReferenceGetter rhs) => ScriptReferenceCommon.GetEqualsMask(this, rhs);
        #region To String
        public override string ToString()
        {
            return ScriptReferenceCommon.ToString(this, printMask: null);
        }

        public string ToString(
            string name = null,
            ScriptReference_Mask<bool> printMask = null)
        {
            return ScriptReferenceCommon.ToString(this, name: name, printMask: printMask);
        }

        public virtual void ToString(
            FileGeneration fg,
            string name = null)
        {
            ScriptReferenceCommon.ToString(this, fg, name: name, printMask: null);
        }

        #endregion

        IMask<bool> ILoquiObjectGetter.GetHasBeenSetMask() => this.GetHasBeenSetMask();
        public ScriptReference_Mask<bool> GetHasBeenSetMask()
        {
            return ScriptReferenceCommon.GetHasBeenSetMask(this);
        }
        #region Equals and Hash
        public override bool Equals(object obj)
        {
            if (!(obj is ScriptReference rhs)) return false;
            return Equals(rhs);
        }

        public bool Equals(ScriptReference rhs)
        {
            if (rhs == null) return false;
            return true;
        }

        public override int GetHashCode()
        {
            int ret = 0;
            return ret;
        }

        #endregion


        #region XML Translation
        #region XML Copy In
        public virtual void CopyIn_XML(
            XElement root,
            NotifyingFireParameters cmds = null)
        {
            LoquiXmlTranslation<ScriptReference>.Instance.CopyIn(
                root: root,
                item: this,
                skipProtected: true,
                errorMask: null,
                cmds: cmds);
        }

        public virtual void CopyIn_XML(
            XElement root,
            out ScriptReference_ErrorMask errorMask,
            NotifyingFireParameters cmds = null)
        {
            ErrorMaskBuilder errorMaskBuilder = new ErrorMaskBuilder();
            LoquiXmlTranslation<ScriptReference>.Instance.CopyIn(
                root: root,
                item: this,
                skipProtected: true,
                errorMask: errorMaskBuilder,
                cmds: cmds);
            errorMask = ScriptReference_ErrorMask.Factory(errorMaskBuilder);
        }

        public void CopyIn_XML(
            string path,
            NotifyingFireParameters cmds = null)
        {
            var root = XDocument.Load(path).Root;
            this.CopyIn_XML(
                root: root,
                cmds: cmds);
        }

        public void CopyIn_XML(
            string path,
            out ScriptReference_ErrorMask errorMask,
            NotifyingFireParameters cmds = null)
        {
            var root = XDocument.Load(path).Root;
            this.CopyIn_XML(
                root: root,
                errorMask: out errorMask,
                cmds: cmds);
        }

        public void CopyIn_XML(
            Stream stream,
            NotifyingFireParameters cmds = null)
        {
            var root = XDocument.Load(stream).Root;
            this.CopyIn_XML(
                root: root,
                cmds: cmds);
        }

        public void CopyIn_XML(
            Stream stream,
            out ScriptReference_ErrorMask errorMask,
            NotifyingFireParameters cmds = null)
        {
            var root = XDocument.Load(stream).Root;
            this.CopyIn_XML(
                root: root,
                errorMask: out errorMask,
                cmds: cmds);
        }

        #endregion

        #region XML Write
        public virtual void Write_XML(
            XElement node,
            out ScriptReference_ErrorMask errorMask,
            bool doMasks = true,
            string name = null)
        {
            errorMask = this.Write_XML_Internal(
                node: node,
                name: name,
                doMasks: doMasks) as ScriptReference_ErrorMask;
        }

        public virtual void Write_XML(
            string path,
            out ScriptReference_ErrorMask errorMask,
            bool doMasks = true,
            string name = null)
        {
            XElement topNode = new XElement("topnode");
            Write_XML(
                node: topNode,
                name: name,
                errorMask: out errorMask,
                doMasks: doMasks);
            topNode.Elements().First().Save(path);
        }

        public virtual void Write_XML(
            Stream stream,
            out ScriptReference_ErrorMask errorMask,
            bool doMasks = true,
            string name = null)
        {
            XElement topNode = new XElement("topnode");
            Write_XML(
                node: topNode,
                name: name,
                errorMask: out errorMask,
                doMasks: doMasks);
            topNode.Elements().First().Save(stream);
        }

        public abstract void Write_XML(
            XElement node,
            string name = null);
        public abstract void Write_XML(
            string path,
            string name = null);
        public abstract void Write_XML(
            Stream stream,
            string name = null);

        protected virtual object Write_XML_Internal(
            XElement node,
            bool doMasks,
            string name = null)
        {
            ScriptReferenceCommon.Write_XML(
                item: this,
                doMasks: doMasks,
                node: node,
                name: name,
                errorMask: out var errorMask);
            return errorMask;
        }
        #endregion

        protected static void Fill_XML_Internal(
            ScriptReference item,
            XElement root,
            string name,
            ErrorMaskBuilder errorMask)
        {
            switch (name)
            {
                default:
                    break;
            }
        }

        #endregion

        #region Binary Translation
        #region Binary Write
        public virtual void Write_Binary(
            MutagenWriter writer,
            out ScriptReference_ErrorMask errorMask,
            bool doMasks = true)
        {
            errorMask = this.Write_Binary_Internal(
                writer: writer,
                recordTypeConverter: null,
                doMasks: doMasks) as ScriptReference_ErrorMask;
        }

        public virtual void Write_Binary(
            string path,
            out ScriptReference_ErrorMask errorMask,
            bool doMasks = true)
        {
            using (var writer = new MutagenWriter(path))
            {
                Write_Binary(
                    writer: writer,
                    errorMask: out errorMask,
                    doMasks: doMasks);
            }
        }

        public virtual void Write_Binary(
            Stream stream,
            out ScriptReference_ErrorMask errorMask,
            bool doMasks = true)
        {
            using (var writer = new MutagenWriter(stream))
            {
                Write_Binary(
                    writer: writer,
                    errorMask: out errorMask,
                    doMasks: doMasks);
            }
        }

        public abstract void Write_Binary(MutagenWriter writer);
        public abstract void Write_Binary(string path);
        public abstract void Write_Binary(Stream stream);

        protected virtual object Write_Binary_Internal(
            MutagenWriter writer,
            RecordTypeConverter recordTypeConverter,
            bool doMasks)
        {
            ScriptReferenceCommon.Write_Binary(
                item: this,
                doMasks: doMasks,
                writer: writer,
                recordTypeConverter: recordTypeConverter,
                errorMask: out var errorMask);
            return errorMask;
        }
        #endregion

        #endregion

        public ScriptReference Copy(
            ScriptReference_CopyMask copyMask = null,
            IScriptReferenceGetter def = null)
        {
            return ScriptReference.Copy(
                this,
                copyMask: copyMask,
                def: def);
        }

        public static ScriptReference Copy(
            IScriptReference item,
            ScriptReference_CopyMask copyMask = null,
            IScriptReferenceGetter def = null)
        {
            ScriptReference ret = (ScriptReference)System.Activator.CreateInstance(item.GetType());
            ret.CopyFieldsFrom(
                item,
                copyMask: copyMask,
                def: def);
            return ret;
        }

        public static ScriptReference Copy_ToLoqui(
            IScriptReferenceGetter item,
            ScriptReference_CopyMask copyMask = null,
            IScriptReferenceGetter def = null)
        {
            ScriptReference ret = (ScriptReference)System.Activator.CreateInstance(item.GetType());
            ret.CopyFieldsFrom(
                item,
                copyMask: copyMask,
                def: def);
            return ret;
        }

        public void CopyFieldsFrom(
            IScriptReferenceGetter rhs,
            NotifyingFireParameters cmds = null)
        {
            this.CopyFieldsFrom(
                rhs: rhs,
                def: null,
                doMasks: false,
                errorMask: out var errMask,
                copyMask: null,
                cmds: cmds);
        }

        public void CopyFieldsFrom(
            IScriptReferenceGetter rhs,
            ScriptReference_CopyMask copyMask,
            IScriptReferenceGetter def = null,
            NotifyingFireParameters cmds = null)
        {
            this.CopyFieldsFrom(
                rhs: rhs,
                def: def,
                doMasks: false,
                errorMask: out var errMask,
                copyMask: copyMask,
                cmds: cmds);
        }

        public void CopyFieldsFrom(
            IScriptReferenceGetter rhs,
            out ScriptReference_ErrorMask errorMask,
            ScriptReference_CopyMask copyMask = null,
            IScriptReferenceGetter def = null,
            NotifyingFireParameters cmds = null,
            bool doMasks = true)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ScriptReferenceCommon.CopyFieldsFrom(
                item: this,
                rhs: rhs,
                def: def,
                errorMask: errorMaskBuilder,
                copyMask: copyMask,
                cmds: cmds);
            errorMask = ScriptReference_ErrorMask.Factory(errorMaskBuilder);
        }

        public void CopyFieldsFrom(
            IScriptReferenceGetter rhs,
            ErrorMaskBuilder errorMask,
            ScriptReference_CopyMask copyMask = null,
            IScriptReferenceGetter def = null,
            NotifyingFireParameters cmds = null,
            bool doMasks = true)
        {
            ScriptReferenceCommon.CopyFieldsFrom(
                item: this,
                rhs: rhs,
                def: def,
                errorMask: errorMask,
                copyMask: copyMask,
                cmds: cmds);
        }

        void ILoquiObjectSetter.SetNthObject(ushort index, object obj, NotifyingFireParameters cmds) => this.SetNthObject(index, obj, cmds);
        protected virtual void SetNthObject(ushort index, object obj, NotifyingFireParameters cmds = null)
        {
            ScriptReference_FieldIndex enu = (ScriptReference_FieldIndex)index;
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index}");
            }
        }

        partial void ClearPartial(NotifyingUnsetParameters cmds);

        protected void CallClearPartial_Internal(NotifyingUnsetParameters cmds)
        {
            ClearPartial(cmds);
        }

        public virtual void Clear(NotifyingUnsetParameters cmds = null)
        {
            CallClearPartial_Internal(cmds);
            ScriptReferenceCommon.Clear(this, cmds);
        }


        protected static void CopyInInternal_ScriptReference(ScriptReference obj, KeyValuePair<ushort, object> pair)
        {
            if (!EnumExt.TryParse(pair.Key, out ScriptReference_FieldIndex enu))
            {
                throw new ArgumentException($"Unknown index: {pair.Key}");
            }
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Unknown enum type: {enu}");
            }
        }
        public static void CopyIn(IEnumerable<KeyValuePair<ushort, object>> fields, ScriptReference obj)
        {
            ILoquiObjectExt.CopyFieldsIn(obj, fields, def: null, skipProtected: false, cmds: null);
        }

    }
    #endregion

    #region Interface
    public partial interface IScriptReference : IScriptReferenceGetter, ILoquiClass<IScriptReference, IScriptReferenceGetter>, ILoquiClass<ScriptReference, IScriptReferenceGetter>
    {
    }

    public partial interface IScriptReferenceGetter : ILoquiObject
    {

    }

    #endregion

}

namespace Mutagen.Bethesda.Oblivion.Internals
{
    #region Field Index
    public enum ScriptReference_FieldIndex
    {
    }
    #endregion

    #region Registration
    public class ScriptReference_Registration : ILoquiRegistration
    {
        public static readonly ScriptReference_Registration Instance = new ScriptReference_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Oblivion.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Oblivion.ProtocolKey,
            msgID: 50,
            version: 0);

        public const string GUID = "5eb6ddcc-5ba8-4da7-87f5-99b6038a61c7";

        public const ushort FieldCount = 0;

        public static readonly Type MaskType = typeof(ScriptReference_Mask<>);

        public static readonly Type ErrorMaskType = typeof(ScriptReference_ErrorMask);

        public static readonly Type ClassType = typeof(ScriptReference);

        public static readonly Type GetterType = typeof(IScriptReferenceGetter);

        public static readonly Type SetterType = typeof(IScriptReference);

        public static readonly Type CommonType = typeof(ScriptReferenceCommon);

        public const string FullName = "Mutagen.Bethesda.Oblivion.ScriptReference";

        public const string Name = "ScriptReference";

        public const string Namespace = "Mutagen.Bethesda.Oblivion";

        public const byte GenericCount = 0;

        public static readonly Type GenericRegistrationType = null;

        public static ushort? GetNameIndex(StringCaseAgnostic str)
        {
            switch (str.Upper)
            {
                default:
                    return null;
            }
        }

        public static bool GetNthIsEnumerable(ushort index)
        {
            ScriptReference_FieldIndex enu = (ScriptReference_FieldIndex)index;
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index}");
            }
        }

        public static bool GetNthIsLoqui(ushort index)
        {
            ScriptReference_FieldIndex enu = (ScriptReference_FieldIndex)index;
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index}");
            }
        }

        public static bool GetNthIsSingleton(ushort index)
        {
            ScriptReference_FieldIndex enu = (ScriptReference_FieldIndex)index;
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index}");
            }
        }

        public static string GetNthName(ushort index)
        {
            ScriptReference_FieldIndex enu = (ScriptReference_FieldIndex)index;
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index}");
            }
        }

        public static bool IsNthDerivative(ushort index)
        {
            ScriptReference_FieldIndex enu = (ScriptReference_FieldIndex)index;
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index}");
            }
        }

        public static bool IsProtected(ushort index)
        {
            ScriptReference_FieldIndex enu = (ScriptReference_FieldIndex)index;
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index}");
            }
        }

        public static Type GetNthType(ushort index)
        {
            ScriptReference_FieldIndex enu = (ScriptReference_FieldIndex)index;
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index}");
            }
        }

        public static readonly RecordType SCRV_HEADER = new RecordType("SCRV");
        public static readonly RecordType SCRO_HEADER = new RecordType("SCRO");
        public static ICollectionGetter<RecordType> TriggeringRecordTypes => _TriggeringRecordTypes.Value;
        private static readonly Lazy<ICollectionGetter<RecordType>> _TriggeringRecordTypes = new Lazy<ICollectionGetter<RecordType>>(() =>
        {
            return new CollectionGetterWrapper<RecordType>(
                new HashSet<RecordType>(
                    new RecordType[]
                    {
                        SCRV_HEADER,
                        SCRO_HEADER
                    })
            );
        });
        public const int NumStructFields = 0;
        public const int NumTypedFields = 0;
        #region Interface
        ProtocolKey ILoquiRegistration.ProtocolKey => ProtocolKey;
        ObjectKey ILoquiRegistration.ObjectKey => ObjectKey;
        string ILoquiRegistration.GUID => GUID;
        int ILoquiRegistration.FieldCount => FieldCount;
        Type ILoquiRegistration.MaskType => MaskType;
        Type ILoquiRegistration.ErrorMaskType => ErrorMaskType;
        Type ILoquiRegistration.ClassType => ClassType;
        Type ILoquiRegistration.SetterType => SetterType;
        Type ILoquiRegistration.GetterType => GetterType;
        Type ILoquiRegistration.CommonType => CommonType;
        string ILoquiRegistration.FullName => FullName;
        string ILoquiRegistration.Name => Name;
        string ILoquiRegistration.Namespace => Namespace;
        byte ILoquiRegistration.GenericCount => GenericCount;
        Type ILoquiRegistration.GenericRegistrationType => GenericRegistrationType;
        ushort? ILoquiRegistration.GetNameIndex(StringCaseAgnostic name) => GetNameIndex(name);
        bool ILoquiRegistration.GetNthIsEnumerable(ushort index) => GetNthIsEnumerable(index);
        bool ILoquiRegistration.GetNthIsLoqui(ushort index) => GetNthIsLoqui(index);
        bool ILoquiRegistration.GetNthIsSingleton(ushort index) => GetNthIsSingleton(index);
        string ILoquiRegistration.GetNthName(ushort index) => GetNthName(index);
        bool ILoquiRegistration.IsNthDerivative(ushort index) => IsNthDerivative(index);
        bool ILoquiRegistration.IsProtected(ushort index) => IsProtected(index);
        Type ILoquiRegistration.GetNthType(ushort index) => GetNthType(index);
        #endregion

    }
    #endregion

    #region Extensions
    public static partial class ScriptReferenceCommon
    {
        #region Copy Fields From
        public static void CopyFieldsFrom(
            IScriptReference item,
            IScriptReferenceGetter rhs,
            IScriptReferenceGetter def,
            ErrorMaskBuilder errorMask,
            ScriptReference_CopyMask copyMask,
            NotifyingFireParameters cmds = null)
        {
        }

        #endregion

        public static void SetNthObjectHasBeenSet(
            ushort index,
            bool on,
            IScriptReference obj,
            NotifyingFireParameters cmds = null)
        {
            ScriptReference_FieldIndex enu = (ScriptReference_FieldIndex)index;
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index}");
            }
        }

        public static void UnsetNthObject(
            ushort index,
            IScriptReference obj,
            NotifyingUnsetParameters cmds = null)
        {
            ScriptReference_FieldIndex enu = (ScriptReference_FieldIndex)index;
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index}");
            }
        }

        public static bool GetNthObjectHasBeenSet(
            ushort index,
            IScriptReference obj)
        {
            ScriptReference_FieldIndex enu = (ScriptReference_FieldIndex)index;
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index}");
            }
        }

        public static object GetNthObject(
            ushort index,
            IScriptReferenceGetter obj)
        {
            ScriptReference_FieldIndex enu = (ScriptReference_FieldIndex)index;
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index}");
            }
        }

        public static void Clear(
            IScriptReference item,
            NotifyingUnsetParameters cmds = null)
        {
        }

        public static ScriptReference_Mask<bool> GetEqualsMask(
            this IScriptReferenceGetter item,
            IScriptReferenceGetter rhs)
        {
            var ret = new ScriptReference_Mask<bool>();
            FillEqualsMask(item, rhs, ret);
            return ret;
        }

        public static void FillEqualsMask(
            IScriptReferenceGetter item,
            IScriptReferenceGetter rhs,
            ScriptReference_Mask<bool> ret)
        {
            if (rhs == null) return;
        }

        public static string ToString(
            this IScriptReferenceGetter item,
            string name = null,
            ScriptReference_Mask<bool> printMask = null)
        {
            var fg = new FileGeneration();
            item.ToString(fg, name, printMask);
            return fg.ToString();
        }

        public static void ToString(
            this IScriptReferenceGetter item,
            FileGeneration fg,
            string name = null,
            ScriptReference_Mask<bool> printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"{nameof(ScriptReference)} =>");
            }
            else
            {
                fg.AppendLine($"{name} ({nameof(ScriptReference)}) =>");
            }
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
            }
            fg.AppendLine("]");
        }

        public static bool HasBeenSet(
            this IScriptReferenceGetter item,
            ScriptReference_Mask<bool?> checkMask)
        {
            return true;
        }

        public static ScriptReference_Mask<bool> GetHasBeenSetMask(IScriptReferenceGetter item)
        {
            var ret = new ScriptReference_Mask<bool>();
            return ret;
        }

        #region XML Translation
        #region XML Write
        public static void Write_XML(
            XElement node,
            IScriptReferenceGetter item,
            bool doMasks,
            out ScriptReference_ErrorMask errorMask,
            string name = null)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            Write_XML_Internal(
                node: node,
                name: name,
                item: item,
                errorMask: errorMaskBuilder);
            errorMask = ScriptReference_ErrorMask.Factory(errorMaskBuilder);
        }

        private static void Write_XML_Internal(
            XElement node,
            IScriptReferenceGetter item,
            ErrorMaskBuilder errorMask,
            string name = null)
        {
            var elem = new XElement(name ?? "Mutagen.Bethesda.Oblivion.ScriptReference");
            node.Add(elem);
            if (name != null)
            {
                elem.SetAttributeValue("type", "Mutagen.Bethesda.Oblivion.ScriptReference");
            }
        }
        #endregion

        #endregion

        #region Binary Translation
        #region Binary Write
        public static void Write_Binary(
            MutagenWriter writer,
            ScriptReference item,
            RecordTypeConverter recordTypeConverter,
            bool doMasks,
            out ScriptReference_ErrorMask errorMask)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            Write_Binary_Internal(
                writer: writer,
                item: item,
                recordTypeConverter: recordTypeConverter,
                errorMask: errorMaskBuilder);
            errorMask = ScriptReference_ErrorMask.Factory(errorMaskBuilder);
        }

        private static void Write_Binary_Internal(
            MutagenWriter writer,
            ScriptReference item,
            RecordTypeConverter recordTypeConverter,
            ErrorMaskBuilder errorMask)
        {
        }
        #endregion

        #endregion

    }
    #endregion

    #region Modules

    #region Mask
    public class ScriptReference_Mask<T> : IMask<T>, IEquatable<ScriptReference_Mask<T>>
    {
        #region Ctors
        public ScriptReference_Mask()
        {
        }

        public ScriptReference_Mask(T initialValue)
        {
        }
        #endregion

        #region Equals
        public override bool Equals(object obj)
        {
            if (!(obj is ScriptReference_Mask<T> rhs)) return false;
            return Equals(rhs);
        }

        public bool Equals(ScriptReference_Mask<T> rhs)
        {
            if (rhs == null) return false;
            return true;
        }
        public override int GetHashCode()
        {
            int ret = 0;
            return ret;
        }

        #endregion

        #region All Equal
        public virtual bool AllEqual(Func<T, bool> eval)
        {
            return true;
        }
        #endregion

        #region Translate
        public ScriptReference_Mask<R> Translate<R>(Func<T, R> eval)
        {
            var ret = new ScriptReference_Mask<R>();
            this.Translate_InternalFill(ret, eval);
            return ret;
        }

        protected void Translate_InternalFill<R>(ScriptReference_Mask<R> obj, Func<T, R> eval)
        {
        }
        #endregion

        #region Clear Enumerables
        public virtual void ClearEnumerables()
        {
        }
        #endregion

        #region To String
        public override string ToString()
        {
            return ToString(printMask: null);
        }

        public string ToString(ScriptReference_Mask<bool> printMask = null)
        {
            var fg = new FileGeneration();
            ToString(fg, printMask);
            return fg.ToString();
        }

        public void ToString(FileGeneration fg, ScriptReference_Mask<bool> printMask = null)
        {
            fg.AppendLine($"{nameof(ScriptReference_Mask<T>)} =>");
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
            }
            fg.AppendLine("]");
        }
        #endregion

    }

    public class ScriptReference_ErrorMask : IErrorMask, IErrorMask<ScriptReference_ErrorMask>
    {
        #region Members
        public Exception Overall { get; set; }
        private List<string> _warnings;
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
        #endregion

        #region IErrorMask
        public virtual object GetNthMask(int index)
        {
            ScriptReference_FieldIndex enu = (ScriptReference_FieldIndex)index;
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index}");
            }
        }

        public virtual void SetNthException(int index, Exception ex)
        {
            ScriptReference_FieldIndex enu = (ScriptReference_FieldIndex)index;
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index}");
            }
        }

        public virtual void SetNthMask(int index, object obj)
        {
            ScriptReference_FieldIndex enu = (ScriptReference_FieldIndex)index;
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index}");
            }
        }

        public virtual bool IsInError()
        {
            if (Overall != null) return true;
            return false;
        }
        #endregion

        #region To String
        public override string ToString()
        {
            var fg = new FileGeneration();
            ToString(fg);
            return fg.ToString();
        }

        public virtual void ToString(FileGeneration fg)
        {
            fg.AppendLine("ScriptReference_ErrorMask =>");
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
        protected virtual void ToString_FillInternal(FileGeneration fg)
        {
        }
        #endregion

        #region Combine
        public ScriptReference_ErrorMask Combine(ScriptReference_ErrorMask rhs)
        {
            var ret = new ScriptReference_ErrorMask();
            return ret;
        }
        public static ScriptReference_ErrorMask Combine(ScriptReference_ErrorMask lhs, ScriptReference_ErrorMask rhs)
        {
            if (lhs != null && rhs != null) return lhs.Combine(rhs);
            return lhs ?? rhs;
        }
        #endregion

        #region Factory
        public static ScriptReference_ErrorMask Factory(ErrorMaskBuilder errorMask)
        {
            if (errorMask?.Empty ?? true) return null;
            throw new NotImplementedException();
        }
        #endregion

    }
    public class ScriptReference_CopyMask
    {
    }
    #endregion




    #endregion

}
