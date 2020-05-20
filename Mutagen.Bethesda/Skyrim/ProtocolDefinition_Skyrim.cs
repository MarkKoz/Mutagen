using Loqui;
using Mutagen.Bethesda.Skyrim;

namespace Loqui
{
    public class ProtocolDefinition_Skyrim : IProtocolRegistration
    {
        public readonly static ProtocolKey ProtocolKey = new ProtocolKey("Skyrim");
        void IProtocolRegistration.Register() => Register();
        public static void Register()
        {
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GameSetting_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GameSettingInt_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GameSettingFloat_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GameSettingString_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Global_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GlobalInt_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GlobalShort_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GlobalFloat_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GameSettingBool_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Keyword_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LocationReferenceType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ActionRecord_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ObjectBounds_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.TextureSet_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Decal_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Class_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Relation_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Faction_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.FormList_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Outfit_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.PlacedObject_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Rank_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.VendorValues_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Location_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Condition_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ConditionGlobal_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ConditionFloat_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.FunctionConditionData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GetEventData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ConditionData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Model_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.AlternateTexture_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.HeadPart_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Part_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Hair_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Eyes_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Armor_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Race_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.BodyTemplate_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SkillBoost_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.VoiceType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ColorRecord_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Attack_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.AttackData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.BodyData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.BodyPartData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Group_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ModHeader_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ModStats_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SkyrimMajorRecord_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SkyrimMod_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.RaceMovementType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SpeedOverrides_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.EquipType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.FaceFxPhonemes_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Phoneme_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.HeadData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.HeadPartReference_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.AvailableMorphs_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Npc_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.TintAssets_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.TintPreset_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ArtObject_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ImpactDataSet_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MaterialType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MovementType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SoundDescriptor_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SimpleModel_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Morph_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SoundMarker_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ReverbParameters_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Region_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.AcousticSpace_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.VirtualMachineAdapter_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptEntry_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptObjectProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptStringProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptIntProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptFloatProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptBoolProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptObjectListProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptIntListProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptFloatListProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptBoolListProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Static_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.EffectShader_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Light_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Explosion_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectLightArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Projectile_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.DualCastData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ImageSpaceAdapter_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Perk_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Spell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectSound_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectBoundArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectNpcArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectSpellArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectWerewolfArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectEnchantmentArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectKeywordArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Hazard_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectGuideArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectSpawnHazardArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectVampireArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ObjectEffect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Grass_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LandscapeTexture_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.CrimeValues_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Effect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.EffectData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Destructible_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Scroll_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.DestructionStage_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.DestructionStageData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Debris_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Activator_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ASpell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LeveledSpell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Shout_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Water_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.DestructableData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.TalkingActivator_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ArmorModel_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ArmorAddon_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Book_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.BookTeachTarget_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.BookSkill_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.BookSpell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.BookTeachesNothing_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Container_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.AlchemicalApparatus_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Ammunition_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Ingestible_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Ingredient_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Key_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LeveledItem_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MiscItem_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SoulGem_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Weapon_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ContainerEntry_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ContainerItem_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ExtraData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.OwnerTarget_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.NpcOwner_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.FactionOwner_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.NoOwner_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Door_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MaterialObject_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Lod_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MoveableStatic_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Tree_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SeasonalIngredientProduction_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Flora_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Furniture_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.WorkbenchData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.FurnitureMarker_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.EntryPoints_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.WeaponBasicStats_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.WeaponData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.CriticalData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LeveledNpc_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.NpcConfiguration_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ANpcLevel_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.NpcLevel_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.PcLevelMult_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.RankPlacement_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.PerkPlacement_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.AIData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.CombatStyle_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.PlayerSkills_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ANpcSoundDefinition_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.NpcInheritSound_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.NpcSoundTypes_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.NpcSoundType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.NpcSound_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Package_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.NpcFaceMorph_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.NpcFaceParts_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.TintLayer_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ALocationTarget_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LocationReference_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.PlacedNpc_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LocationCell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LocationObjectId_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Cell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.IdleMarker_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LocationObjectType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LocationKeyword_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LocationFallback_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Icons_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MountData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.IdleAnimation_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ConstructibleObject_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.CollisionLayer_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LeveledItemEntry_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LeveledItemEntryData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LeveledNpcEntry_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LeveledNpcEntryData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.AmbientColors_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LensFlare_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ShaderParticleGeometry_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.VisualEffect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.VolumetricLighting_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Weather_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.CloudLayer_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.WeatherColor_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.WeatherAlpha_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.WeatherSound_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.WeatherImageSpaces_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.WeatherVolumetricLighting_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.WeatherAmbientColors_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Climate_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.WeatherType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Music_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.RegionArea_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.RegionData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.RegionDataHeader_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.RegionSounds_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.RegionSound_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.RegionMap_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.RegionObjects_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.RegionObject_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.RegionWeather_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Worldspace_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.RegionGrasses_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.RegionGrass_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.RegionLand_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.NavigationMesh_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.NavigationMeshInfoMap_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.NavigationMapInfo_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LinkedDoor_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.IslandData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.PreferredPathing_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.NavmeshSet_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.NavmeshNode_Registration.Instance);
        }
    }
}
