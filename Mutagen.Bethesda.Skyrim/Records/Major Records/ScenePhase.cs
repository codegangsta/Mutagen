using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Noggog;
using System.Collections.Generic;
using Mutagen.Bethesda.Skyrim.Internals;

namespace Mutagen.Bethesda.Skyrim;

partial class ScenePhaseBinaryCreateTranslation
{
    public static partial void FillBinaryStartConditionsCustom(MutagenFrame frame, IScenePhase item)
    {
        ConditionBinaryCreateTranslation.FillConditionsList(item.StartConditions, frame);
    }

    public static partial void FillBinaryCompletionConditionsCustom(MutagenFrame frame, IScenePhase item)
    {
        frame.ReadSubrecordFrame();
        ConditionBinaryCreateTranslation.FillConditionsList(item.CompletionConditions, frame);
    }
}

partial class ScenePhaseBinaryWriteTranslation
{
    public static partial void WriteBinaryStartConditionsCustom(MutagenWriter writer, IScenePhaseGetter item)
    {
        ConditionBinaryWriteTranslation.WriteConditionsList(item.StartConditions, writer);
    }

    public static partial void WriteBinaryCompletionConditionsCustom(MutagenWriter writer, IScenePhaseGetter item)
    {
        using (HeaderExport.Subrecord(writer, RecordTypes.NEXT)) { }
        ConditionBinaryWriteTranslation.WriteConditionsList(item.CompletionConditions, writer);
    }
}

partial class ScenePhaseBinaryOverlay
{
    public IReadOnlyList<IConditionGetter> StartConditions { get; private set; } = ListExt.Empty<IConditionGetter>();

    public IReadOnlyList<IConditionGetter> CompletionConditions { get; private set; } = ListExt.Empty<IConditionGetter>();

    partial void StartConditionsCustomParse(OverlayStream stream, long finalPos, int offset, RecordType type, PreviousParse lastParsed)
    {
        StartConditions = ConditionBinaryOverlay.ConstructBinayOverlayList(stream, _package);
    }

    partial void CompletionConditionsCustomParse(OverlayStream stream, long finalPos, int offset, RecordType type, PreviousParse lastParsed)
    {
        stream.ReadSubrecordFrame();
        CompletionConditions = ConditionBinaryOverlay.ConstructBinayOverlayList(stream, _package);
    }
}