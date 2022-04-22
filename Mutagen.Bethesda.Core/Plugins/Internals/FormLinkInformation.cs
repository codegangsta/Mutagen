using System;
using System.Diagnostics.CodeAnalysis;
using Mutagen.Bethesda.Plugins.Cache;
using Mutagen.Bethesda.Plugins.Records;

namespace Mutagen.Bethesda.Plugins.Internals;

public record FormLinkInformation(FormKey FormKey, Type Type) : IFormLinkGetter
{
    public FormKey? FormKeyNullable => this.FormKey;

    public bool IsNull => this.FormKey.IsNull;

    public override string ToString()
    {
        return $"({Type}) => {FormKey}";
    }

    public static FormLinkInformation Factory<TMajorGetter>(IFormLinkGetter<TMajorGetter> link)
        where TMajorGetter : class, IMajorRecordGetter
    {
        return new FormLinkInformation(link.FormKey, typeof(TMajorGetter));
    }

    public static bool TryFactory<TMajorGetter>(IFormLinkNullableGetter<TMajorGetter> link, [MaybeNullWhen(false)] out FormLinkInformation info)
        where TMajorGetter : class, IMajorRecordGetter
    {
        if (link.FormKeyNullable == null)
        {
            info = null;
            return false;
        }
        info = new FormLinkInformation(link.FormKey, typeof(TMajorGetter));
        return true;
    }

    public static FormLinkInformation Factory<TMajorGetter>(IFormLinkNullableGetter<TMajorGetter> link)
        where TMajorGetter : class, IMajorRecordGetter
    {
        return new FormLinkInformation(link.FormKey, typeof(TMajorGetter));
    }

    public static FormLinkInformation Factory(IMajorRecordGetter majorRec)
    {
        return new FormLinkInformation(majorRec.FormKey, majorRec.Registration.GetterType);
    }

    public static IFormLinkGetter Factory(IFormLinkGetter rhs) => rhs;

    public bool TryGetModKey([MaybeNullWhen(false)] out ModKey modKey)
    {
        modKey = this.FormKey.ModKey;
        return true;
    }

    public bool TryResolveFormKey(ILinkCache cache, out FormKey formKey)
    {
        formKey = this.FormKey;
        return true;
    }

    public bool TryResolveCommon(ILinkCache cache, [MaybeNullWhen(false)] out IMajorRecordGetter majorRecord)
    {
        return cache.TryResolve<IMajorRecordGetter>(this.FormKey, out majorRecord);
    }
}