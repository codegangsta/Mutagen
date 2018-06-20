﻿using Loqui.Internal;
using Loqui.Xml;
using Noggog.Notifying;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mutagen.Bethesda
{
    public class FormIDXmlTranslation : PrimitiveXmlTranslation<FormID>
    {
        public readonly static FormIDXmlTranslation Instance = new FormIDXmlTranslation();

        public void ParseInto<T>(XElement root, int fieldIndex, FormIDSetLink<T> item, ErrorMaskBuilder errorMask)
            where T : MajorRecord
        {
            try
            {
                errorMask?.PushIndex(fieldIndex);

                if (Parse(root, out FormID val, errorMask))
                {
                    item.Set(val);
                }
                else
                {
                    item.Unset();
                }
            }
            catch (Exception ex)
            when (errorMask != null)
            {
                errorMask.ReportException(ex);
            }
            finally
            {
                errorMask?.PopIndex();
            }
        }

        public void ParseInto<T>(XElement root, int fieldIndex, FormIDLink<T> item, ErrorMaskBuilder errorMask)
            where T : MajorRecord
        {
            try
            {
                errorMask?.PushIndex(fieldIndex);

                if (Parse(root, out FormID val, errorMask))
                {
                    item.Set(val);
                }
                else
                {
                    item.Unset();
                }
            }
            catch (Exception ex)
            when (errorMask != null)
            {
                errorMask.ReportException(ex);
            }
            finally
            {
                errorMask?.PopIndex();
            }
        }

        public void ParseInto<T>(XElement root, int fieldIndex, EDIDLink<T> item, ErrorMaskBuilder errorMask)
            where T : MajorRecord
        {
            try
            {
                errorMask?.PushIndex(fieldIndex);

                if (Parse(root, out FormID val, errorMask))
                {
                    item.Set(val);
                }
                else
                {
                    item.Unset();
                }
            }
            catch (Exception ex)
            when (errorMask != null)
            {
                errorMask.ReportException(ex);
            }
            finally
            {
                errorMask?.PopIndex();
            }
        }

        public void ParseInto<T>(XElement root, int fieldIndex, EDIDSetLink<T> item, ErrorMaskBuilder errorMask)
            where T : MajorRecord
        {
            try
            {
                errorMask?.PushIndex(fieldIndex);

                if (Parse(root, out FormID val, errorMask))
                {
                    item.Set(val);
                }
                else
                {
                    item.Unset();
                }
            }
            catch (Exception ex)
            when (errorMask != null)
            {
                errorMask.ReportException(ex);
            }
            finally
            {
                errorMask?.PopIndex();
            }
        }

        public bool Parse<T>(XElement root, out FormIDLink<T> item, ErrorMaskBuilder errorMask)
            where T : MajorRecord
        {
            if (Parse(root, out FormID id, errorMask))
            {
                item = new FormIDLink<T>(id);
                return true;
            }
            item = new FormIDLink<T>();
            return false;
        }

        public bool Parse<T>(XElement root, out FormIDSetLink<T> item, ErrorMaskBuilder errorMask)
            where T : MajorRecord
        {
            if (Parse(root, out FormID id, errorMask))
            {
                item = new FormIDSetLink<T>(id);
                return true;
            }
            item = new FormIDSetLink<T>();
            return false;
        }

        public bool Parse<T>(XElement root, out EDIDLink<T> item, ErrorMaskBuilder errorMask)
            where T : MajorRecord
        {
            if (Parse(root, out FormID id, errorMask))
            {
                item = new EDIDLink<T>(id);
                return true;
            }
            item = new EDIDLink<T>();
            return false;
        }

        public bool Parse<T>(XElement root, out EDIDSetLink<T> item, ErrorMaskBuilder errorMask)
            where T : MajorRecord
        {
            if (Parse(root, out FormID id, errorMask))
            {
                item = new EDIDSetLink<T>(id);
                return true;
            }
            item = new EDIDSetLink<T>();
            return false;
        }

        protected override bool ParseNonNullString(string str, out FormID value, ErrorMaskBuilder errorMask)
        {
            if (FormID.TryFactory(str, out FormID parsed))
            {
                value = parsed;
                return true;
            }
            errorMask.ReportExceptionOrThrow(
                new ArgumentException($"Could not convert to {NullableName}"));
            value = FormID.NULL;
            return false;
        }
    }
}
