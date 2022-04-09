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

namespace Mutagen.Bethesda.Skyrim
{
    internal class SkyrimAspectInterfaceMapping : IInterfaceMapping
    {
        public IReadOnlyDictionary<Type, InterfaceMappingResult> InterfaceToObjectTypes { get; }

        public GameCategory GameCategory => GameCategory.Skyrim;

        public SkyrimAspectInterfaceMapping()
        {
            var dict = new Dictionary<Type, InterfaceMappingResult>();
            dict[typeof(IAmbientColorsCommon)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                AmbientColors_Registration.Instance,
                CellLighting_Registration.Instance,
                LightingTemplate_Registration.Instance,
            });
            dict[typeof(IAmbientColorsCommonGetter)] = dict[typeof(IAmbientColorsCommon)] with { Setter = false };
            dict[typeof(IHarvestable)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Tree_Registration.Instance,
            });
            dict[typeof(IHarvestableGetter)] = dict[typeof(IHarvestable)] with { Setter = false };
            dict[typeof(IHasIcons)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                AlchemicalApparatus_Registration.Instance,
                Ammunition_Registration.Instance,
                ArmorModel_Registration.Instance,
                Book_Registration.Instance,
                Ingestible_Registration.Instance,
                Ingredient_Registration.Instance,
                Key_Registration.Instance,
                Light_Registration.Instance,
                LoadScreen_Registration.Instance,
                MiscItem_Registration.Instance,
                Perk_Registration.Instance,
                RegionData_Registration.Instance,
                RegionGrasses_Registration.Instance,
                RegionLand_Registration.Instance,
                RegionMap_Registration.Instance,
                RegionObjects_Registration.Instance,
                RegionSounds_Registration.Instance,
                RegionWeather_Registration.Instance,
                SoulGem_Registration.Instance,
                Weapon_Registration.Instance,
            });
            dict[typeof(IHasIconsGetter)] = dict[typeof(IHasIcons)] with { Setter = false };
            dict[typeof(IKeywordCommon)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Keyword_Registration.Instance,
            });
            dict[typeof(IKeywordCommonGetter)] = dict[typeof(IKeywordCommon)] with { Setter = false };
            dict[typeof(IKeyworded<IKeywordGetter>)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                Ammunition_Registration.Instance,
                Armor_Registration.Instance,
                Book_Registration.Instance,
                Flora_Registration.Instance,
                Furniture_Registration.Instance,
                Ingestible_Registration.Instance,
                Ingredient_Registration.Instance,
                Key_Registration.Instance,
                Location_Registration.Instance,
                MagicEffect_Registration.Instance,
                MiscItem_Registration.Instance,
                Npc_Registration.Instance,
                QuestAlias_Registration.Instance,
                Race_Registration.Instance,
                Scroll_Registration.Instance,
                SoulGem_Registration.Instance,
                Spell_Registration.Instance,
                TalkingActivator_Registration.Instance,
                Weapon_Registration.Instance,
            });
            dict[typeof(IKeywordedGetter<IKeywordGetter>)] = dict[typeof(IKeyworded<IKeywordGetter>)] with { Setter = false };
            dict[typeof(IModeled)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                AddonNode_Registration.Instance,
                AlchemicalApparatus_Registration.Instance,
                Ammunition_Registration.Instance,
                AnimatedObject_Registration.Instance,
                ArmorModel_Registration.Instance,
                ArtObject_Registration.Instance,
                BodyData_Registration.Instance,
                BodyPartData_Registration.Instance,
                Book_Registration.Instance,
                CameraShot_Registration.Instance,
                Climate_Registration.Instance,
                Container_Registration.Instance,
                DestructionStage_Registration.Instance,
                Door_Registration.Instance,
                Explosion_Registration.Instance,
                Flora_Registration.Instance,
                Furniture_Registration.Instance,
                Grass_Registration.Instance,
                Hazard_Registration.Instance,
                HeadData_Registration.Instance,
                HeadPart_Registration.Instance,
                IdleMarker_Registration.Instance,
                Impact_Registration.Instance,
                Ingestible_Registration.Instance,
                Ingredient_Registration.Instance,
                Key_Registration.Instance,
                LeveledNpc_Registration.Instance,
                Light_Registration.Instance,
                MaterialObject_Registration.Instance,
                MiscItem_Registration.Instance,
                MoveableStatic_Registration.Instance,
                Projectile_Registration.Instance,
                Scroll_Registration.Instance,
                SoulGem_Registration.Instance,
                Static_Registration.Instance,
                TalkingActivator_Registration.Instance,
                Tree_Registration.Instance,
                Weapon_Registration.Instance,
            });
            dict[typeof(IModeledGetter)] = dict[typeof(IModeled)] with { Setter = false };
            dict[typeof(INamed)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                ActorValueInformation_Registration.Instance,
                AlchemicalApparatus_Registration.Instance,
                Ammunition_Registration.Instance,
                APackageData_Registration.Instance,
                Armor_Registration.Instance,
                Book_Registration.Instance,
                Cell_Registration.Instance,
                ColorRecord_Registration.Instance,
                Container_Registration.Instance,
                DialogTopic_Registration.Instance,
                Door_Registration.Instance,
                Explosion_Registration.Instance,
                Faction_Registration.Instance,
                Furniture_Registration.Instance,
                Hazard_Registration.Instance,
                HeadPart_Registration.Instance,
                Ingestible_Registration.Instance,
                Ingredient_Registration.Instance,
                Light_Registration.Instance,
                Location_Registration.Instance,
                MagicEffect_Registration.Instance,
                MapMarker_Registration.Instance,
                MaterialType_Registration.Instance,
                Message_Registration.Instance,
                MiscItem_Registration.Instance,
                MoveableStatic_Registration.Instance,
                MovementType_Registration.Instance,
                Npc_Registration.Instance,
                ObjectEffect_Registration.Instance,
                PackageDataBool_Registration.Instance,
                PackageDataFloat_Registration.Instance,
                PackageDataInt_Registration.Instance,
                PackageDataLocation_Registration.Instance,
                PackageDataObjectList_Registration.Instance,
                PackageDataTarget_Registration.Instance,
                PackageDataTopic_Registration.Instance,
                Perk_Registration.Instance,
                Projectile_Registration.Instance,
                Quest_Registration.Instance,
                QuestAlias_Registration.Instance,
                Race_Registration.Instance,
                RegionMap_Registration.Instance,
                SceneAction_Registration.Instance,
                ScenePhase_Registration.Instance,
                Scroll_Registration.Instance,
                Shout_Registration.Instance,
                SoulGem_Registration.Instance,
                SoundCategory_Registration.Instance,
                Spell_Registration.Instance,
                TalkingActivator_Registration.Instance,
                Tree_Registration.Instance,
                Water_Registration.Instance,
                Weapon_Registration.Instance,
                WordOfPower_Registration.Instance,
                Worldspace_Registration.Instance,
            });
            dict[typeof(INamedGetter)] = dict[typeof(INamed)] with { Setter = false };
            dict[typeof(INamedRequired)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                ActorValueInformation_Registration.Instance,
                AlchemicalApparatus_Registration.Instance,
                AlternateTexture_Registration.Instance,
                Ammunition_Registration.Instance,
                APackageData_Registration.Instance,
                Armor_Registration.Instance,
                BodyPart_Registration.Instance,
                Book_Registration.Instance,
                Cell_Registration.Instance,
                Class_Registration.Instance,
                CollisionLayer_Registration.Instance,
                ColorRecord_Registration.Instance,
                Container_Registration.Instance,
                DialogTopic_Registration.Instance,
                Door_Registration.Instance,
                Explosion_Registration.Instance,
                Eyes_Registration.Instance,
                Faction_Registration.Instance,
                Flora_Registration.Instance,
                Furniture_Registration.Instance,
                Hazard_Registration.Instance,
                HeadPart_Registration.Instance,
                Ingestible_Registration.Instance,
                Ingredient_Registration.Instance,
                Key_Registration.Instance,
                Light_Registration.Instance,
                Location_Registration.Instance,
                MagicEffect_Registration.Instance,
                MapMarker_Registration.Instance,
                MaterialType_Registration.Instance,
                Message_Registration.Instance,
                MiscItem_Registration.Instance,
                MoveableStatic_Registration.Instance,
                MovementType_Registration.Instance,
                Npc_Registration.Instance,
                ObjectEffect_Registration.Instance,
                PackageDataBool_Registration.Instance,
                PackageDataFloat_Registration.Instance,
                PackageDataInt_Registration.Instance,
                PackageDataLocation_Registration.Instance,
                PackageDataObjectList_Registration.Instance,
                PackageDataTarget_Registration.Instance,
                PackageDataTopic_Registration.Instance,
                Perk_Registration.Instance,
                Phoneme_Registration.Instance,
                Projectile_Registration.Instance,
                Quest_Registration.Instance,
                QuestAlias_Registration.Instance,
                Race_Registration.Instance,
                RegionMap_Registration.Instance,
                SceneAction_Registration.Instance,
                ScenePhase_Registration.Instance,
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
                Scroll_Registration.Instance,
                Shout_Registration.Instance,
                SoulGem_Registration.Instance,
                SoundCategory_Registration.Instance,
                Spell_Registration.Instance,
                TalkingActivator_Registration.Instance,
                Tree_Registration.Instance,
                Water_Registration.Instance,
                Weapon_Registration.Instance,
                WordOfPower_Registration.Instance,
                Worldspace_Registration.Instance,
            });
            dict[typeof(INamedRequiredGetter)] = dict[typeof(INamedRequired)] with { Setter = false };
            dict[typeof(ITranslatedNamed)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                ActorValueInformation_Registration.Instance,
                AlchemicalApparatus_Registration.Instance,
                Ammunition_Registration.Instance,
                Armor_Registration.Instance,
                Book_Registration.Instance,
                Cell_Registration.Instance,
                ColorRecord_Registration.Instance,
                Container_Registration.Instance,
                DialogTopic_Registration.Instance,
                Door_Registration.Instance,
                Explosion_Registration.Instance,
                Faction_Registration.Instance,
                Furniture_Registration.Instance,
                Hazard_Registration.Instance,
                HeadPart_Registration.Instance,
                Ingestible_Registration.Instance,
                Ingredient_Registration.Instance,
                Light_Registration.Instance,
                Location_Registration.Instance,
                MagicEffect_Registration.Instance,
                MapMarker_Registration.Instance,
                Message_Registration.Instance,
                MiscItem_Registration.Instance,
                MoveableStatic_Registration.Instance,
                Npc_Registration.Instance,
                ObjectEffect_Registration.Instance,
                Perk_Registration.Instance,
                Projectile_Registration.Instance,
                Quest_Registration.Instance,
                Race_Registration.Instance,
                RegionMap_Registration.Instance,
                Scroll_Registration.Instance,
                Shout_Registration.Instance,
                SoulGem_Registration.Instance,
                SoundCategory_Registration.Instance,
                Spell_Registration.Instance,
                TalkingActivator_Registration.Instance,
                Tree_Registration.Instance,
                Water_Registration.Instance,
                Weapon_Registration.Instance,
                WordOfPower_Registration.Instance,
                Worldspace_Registration.Instance,
            });
            dict[typeof(ITranslatedNamedGetter)] = dict[typeof(ITranslatedNamed)] with { Setter = false };
            dict[typeof(ITranslatedNamedRequired)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                ActorValueInformation_Registration.Instance,
                AlchemicalApparatus_Registration.Instance,
                Ammunition_Registration.Instance,
                Armor_Registration.Instance,
                BodyPart_Registration.Instance,
                Book_Registration.Instance,
                Cell_Registration.Instance,
                Class_Registration.Instance,
                ColorRecord_Registration.Instance,
                Container_Registration.Instance,
                DialogTopic_Registration.Instance,
                Door_Registration.Instance,
                Explosion_Registration.Instance,
                Eyes_Registration.Instance,
                Faction_Registration.Instance,
                Flora_Registration.Instance,
                Furniture_Registration.Instance,
                Hazard_Registration.Instance,
                HeadPart_Registration.Instance,
                Ingestible_Registration.Instance,
                Ingredient_Registration.Instance,
                Key_Registration.Instance,
                Light_Registration.Instance,
                Location_Registration.Instance,
                MagicEffect_Registration.Instance,
                MapMarker_Registration.Instance,
                Message_Registration.Instance,
                MiscItem_Registration.Instance,
                MoveableStatic_Registration.Instance,
                Npc_Registration.Instance,
                ObjectEffect_Registration.Instance,
                Perk_Registration.Instance,
                Projectile_Registration.Instance,
                Quest_Registration.Instance,
                Race_Registration.Instance,
                RegionMap_Registration.Instance,
                Scroll_Registration.Instance,
                Shout_Registration.Instance,
                SoulGem_Registration.Instance,
                SoundCategory_Registration.Instance,
                Spell_Registration.Instance,
                TalkingActivator_Registration.Instance,
                Tree_Registration.Instance,
                Water_Registration.Instance,
                Weapon_Registration.Instance,
                WordOfPower_Registration.Instance,
                Worldspace_Registration.Instance,
            });
            dict[typeof(ITranslatedNamedRequiredGetter)] = dict[typeof(ITranslatedNamedRequired)] with { Setter = false };
            dict[typeof(IObjectBounded)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                AcousticSpace_Registration.Instance,
                Activator_Registration.Instance,
                AddonNode_Registration.Instance,
                AlchemicalApparatus_Registration.Instance,
                Ammunition_Registration.Instance,
                Armor_Registration.Instance,
                ArtObject_Registration.Instance,
                Book_Registration.Instance,
                Container_Registration.Instance,
                Door_Registration.Instance,
                DualCastData_Registration.Instance,
                Explosion_Registration.Instance,
                Flora_Registration.Instance,
                Furniture_Registration.Instance,
                Grass_Registration.Instance,
                Hazard_Registration.Instance,
                IdleMarker_Registration.Instance,
                Ingestible_Registration.Instance,
                Ingredient_Registration.Instance,
                Key_Registration.Instance,
                LeveledItem_Registration.Instance,
                LeveledNpc_Registration.Instance,
                LeveledSpell_Registration.Instance,
                Light_Registration.Instance,
                MiscItem_Registration.Instance,
                MoveableStatic_Registration.Instance,
                Npc_Registration.Instance,
                ObjectEffect_Registration.Instance,
                Projectile_Registration.Instance,
                Scroll_Registration.Instance,
                SoundMarker_Registration.Instance,
                Spell_Registration.Instance,
                Static_Registration.Instance,
                TalkingActivator_Registration.Instance,
                TextureSet_Registration.Instance,
                Tree_Registration.Instance,
                Weapon_Registration.Instance,
            });
            dict[typeof(IObjectBoundedGetter)] = dict[typeof(IObjectBounded)] with { Setter = false };
            dict[typeof(IObjectBoundedOptional)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                SoulGem_Registration.Instance,
            });
            dict[typeof(IObjectBoundedOptionalGetter)] = dict[typeof(IObjectBoundedOptional)] with { Setter = false };
            dict[typeof(IPositionRotation)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Placement_Registration.Instance,
                TeleportDestination_Registration.Instance,
            });
            dict[typeof(IPositionRotationGetter)] = dict[typeof(IPositionRotation)] with { Setter = false };
            dict[typeof(IScripted)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                AlchemicalApparatus_Registration.Instance,
                APlacedTrap_Registration.Instance,
                Armor_Registration.Instance,
                Book_Registration.Instance,
                Container_Registration.Instance,
                Door_Registration.Instance,
                Explosion_Registration.Instance,
                Flora_Registration.Instance,
                Furniture_Registration.Instance,
                Ingredient_Registration.Instance,
                Key_Registration.Instance,
                Light_Registration.Instance,
                MagicEffect_Registration.Instance,
                MiscItem_Registration.Instance,
                Npc_Registration.Instance,
                PlacedArrow_Registration.Instance,
                PlacedBarrier_Registration.Instance,
                PlacedBeam_Registration.Instance,
                PlacedCone_Registration.Instance,
                PlacedFlame_Registration.Instance,
                PlacedHazard_Registration.Instance,
                PlacedMissile_Registration.Instance,
                PlacedNpc_Registration.Instance,
                PlacedObject_Registration.Instance,
                PlacedTrap_Registration.Instance,
                TalkingActivator_Registration.Instance,
                Tree_Registration.Instance,
                Weapon_Registration.Instance,
            });
            dict[typeof(IScriptedGetter)] = dict[typeof(IScripted)] with { Setter = false };
            dict[typeof(IWeightValue)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                AlchemicalApparatus_Registration.Instance,
                Ammunition_Registration.Instance,
                Armor_Registration.Instance,
                Book_Registration.Instance,
                Ingestible_Registration.Instance,
                Ingredient_Registration.Instance,
                Key_Registration.Instance,
                Light_Registration.Instance,
                MiscItem_Registration.Instance,
                Scroll_Registration.Instance,
                SoulGem_Registration.Instance,
                WeaponBasicStats_Registration.Instance,
            });
            dict[typeof(IWeightValueGetter)] = dict[typeof(IWeightValue)] with { Setter = false };
            InterfaceToObjectTypes = dict;
        }
    }
}

