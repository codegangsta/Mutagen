/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
using System;
using System.Collections.Generic;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Plugins.Aspects;
using Loqui;

namespace Mutagen.Bethesda.Starfield
{
    internal class StarfieldAspectInterfaceMapping : IInterfaceMapping
    {
        public IReadOnlyDictionary<Type, InterfaceMappingResult> InterfaceToObjectTypes { get; }

        public GameCategory GameCategory => GameCategory.Starfield;

        public StarfieldAspectInterfaceMapping()
        {
            var dict = new Dictionary<Type, InterfaceMappingResult>();
            dict[typeof(IHaveVirtualMachineAdapterGetter)] = new InterfaceMappingResult(false, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                LeveledItem_Registration.Instance,
                MagicEffect_Registration.Instance,
            });
            dict[typeof(IKeywordCommon)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Keyword_Registration.Instance,
            });
            dict[typeof(IKeywordCommonGetter)] = dict[typeof(IKeywordCommon)] with { Setter = false };
            dict[typeof(IKeyworded<IKeywordGetter>)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                KeywordFormComponent_Registration.Instance,
                MagicEffect_Registration.Instance,
                Race_Registration.Instance,
                SoundMarker_Registration.Instance,
                Spell_Registration.Instance,
                Weather_Registration.Instance,
            });
            dict[typeof(IKeywordedGetter<IKeywordGetter>)] = dict[typeof(IKeyworded<IKeywordGetter>)] with { Setter = false };
            dict[typeof(IModeled)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                AnimatedObject_Registration.Instance,
                BodyData_Registration.Instance,
                DestructionStage_Registration.Instance,
                HeadPart_Registration.Instance,
                LegendaryItem_Registration.Instance,
                LeveledItem_Registration.Instance,
                ModelComponent_Registration.Instance,
                PlanetModelComponent_Registration.Instance,
                SkeletalModel_Registration.Instance,
                StaticCollection_Registration.Instance,
                Weapon_Registration.Instance,
            });
            dict[typeof(IModeledGetter)] = dict[typeof(IModeled)] with { Setter = false };
            dict[typeof(INamed)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                Activity_Registration.Instance,
                Class_Registration.Instance,
                DamageType_Registration.Instance,
                FaceMorphItem_Registration.Instance,
                Faction_Registration.Instance,
                FormList_Registration.Instance,
                FullNameComponent_Registration.Instance,
                HeadPart_Registration.Instance,
                Keyword_Registration.Instance,
                MagicEffect_Registration.Instance,
                MorphGroup_Registration.Instance,
                ObjectEffect_Registration.Instance,
                Planet_Registration.Instance,
                ProgressionEvaluatorArgument_Registration.Instance,
                Race_Registration.Instance,
                Spell_Registration.Instance,
                StaticCollection_Registration.Instance,
            });
            dict[typeof(INamedGetter)] = dict[typeof(INamed)] with { Setter = false };
            dict[typeof(INamedRequired)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                Activity_Registration.Instance,
                ActorValueModulation_Registration.Instance,
                BipedObjectData_Registration.Instance,
                Class_Registration.Instance,
                DamageType_Registration.Instance,
                FaceMorphItem_Registration.Instance,
                Faction_Registration.Instance,
                FormList_Registration.Instance,
                FullNameComponent_Registration.Instance,
                HeadPart_Registration.Instance,
                Keyword_Registration.Instance,
                MagicEffect_Registration.Instance,
                MorphGroup_Registration.Instance,
                ObjectEffect_Registration.Instance,
                Planet_Registration.Instance,
                ProgressionEvaluatorArgument_Registration.Instance,
                Race_Registration.Instance,
                ScriptBoolListProperty_Registration.Instance,
                ScriptBoolProperty_Registration.Instance,
                ScriptEntry_Registration.Instance,
                ScriptFloatListProperty_Registration.Instance,
                ScriptFloatProperty_Registration.Instance,
                ScriptIntListProperty_Registration.Instance,
                ScriptIntProperty_Registration.Instance,
                ScriptObjectListProperty_Registration.Instance,
                ScriptObjectProperty_Registration.Instance,
                ScriptProperty_Registration.Instance,
                ScriptStringListProperty_Registration.Instance,
                ScriptStringProperty_Registration.Instance,
                ScriptStructListProperty_Registration.Instance,
                ScriptStructProperty_Registration.Instance,
                ScriptVariableListProperty_Registration.Instance,
                ScriptVariableProperty_Registration.Instance,
                Spell_Registration.Instance,
                StaticCollection_Registration.Instance,
            });
            dict[typeof(INamedRequiredGetter)] = dict[typeof(INamedRequired)] with { Setter = false };
            dict[typeof(ITranslatedNamed)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                Activity_Registration.Instance,
                Class_Registration.Instance,
                DamageType_Registration.Instance,
                FaceMorphItem_Registration.Instance,
                Faction_Registration.Instance,
                FormList_Registration.Instance,
                FullNameComponent_Registration.Instance,
                HeadPart_Registration.Instance,
                Keyword_Registration.Instance,
                MagicEffect_Registration.Instance,
                ObjectEffect_Registration.Instance,
                Race_Registration.Instance,
                Spell_Registration.Instance,
                StaticCollection_Registration.Instance,
            });
            dict[typeof(ITranslatedNamedGetter)] = dict[typeof(ITranslatedNamed)] with { Setter = false };
            dict[typeof(ITranslatedNamedRequired)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                Activity_Registration.Instance,
                Class_Registration.Instance,
                DamageType_Registration.Instance,
                FaceMorphItem_Registration.Instance,
                Faction_Registration.Instance,
                FormList_Registration.Instance,
                FullNameComponent_Registration.Instance,
                HeadPart_Registration.Instance,
                Keyword_Registration.Instance,
                MagicEffect_Registration.Instance,
                ObjectEffect_Registration.Instance,
                Race_Registration.Instance,
                Spell_Registration.Instance,
                StaticCollection_Registration.Instance,
            });
            dict[typeof(ITranslatedNamedRequiredGetter)] = dict[typeof(ITranslatedNamedRequired)] with { Setter = false };
            dict[typeof(IObjectBounded)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                AcousticSpace_Registration.Instance,
                Activator_Registration.Instance,
                AudioOcclusionPrimitive_Registration.Instance,
                LeveledItem_Registration.Instance,
                ObjectEffect_Registration.Instance,
                ProjectedDecal_Registration.Instance,
                SoundEchoMarker_Registration.Instance,
                SoundMarker_Registration.Instance,
                Spell_Registration.Instance,
                StaticCollection_Registration.Instance,
                TextureSet_Registration.Instance,
            });
            dict[typeof(IObjectBoundedGetter)] = dict[typeof(IObjectBounded)] with { Setter = false };
            dict[typeof(IObjectBoundedOptional)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                BendableSpline_Registration.Instance,
                LegendaryItem_Registration.Instance,
            });
            dict[typeof(IObjectBoundedOptionalGetter)] = dict[typeof(IObjectBoundedOptional)] with { Setter = false };
            dict[typeof(IPositionRotation)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                StaticPlacement_Registration.Instance,
                Transform_Registration.Instance,
            });
            dict[typeof(IPositionRotationGetter)] = dict[typeof(IPositionRotation)] with { Setter = false };
            dict[typeof(IScripted)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                LeveledItem_Registration.Instance,
                MagicEffect_Registration.Instance,
            });
            dict[typeof(IScriptedGetter)] = dict[typeof(IScripted)] with { Setter = false };
            InterfaceToObjectTypes = dict;
        }
    }
}

