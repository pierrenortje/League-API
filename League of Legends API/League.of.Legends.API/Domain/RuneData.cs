using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.of.Legends.API.Domain
{
    public class RuneData
    {
        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, Rune> Data { get; set; }

        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }

    public class Rune
    {
        [JsonProperty(PropertyName = "stats")]
        public RuneStats Stats { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public List<string> Tags { get; set; }

        [JsonProperty(PropertyName = "image")]
        public Image Image { get; set; }

        [JsonProperty(PropertyName = "sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty(PropertyName = "rune")]
        public MetaData RuneData { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class RuneStats
    {
        [JsonProperty(PropertyName = "PercentTimeDeadModPerLevel")]
        public double PercentTimeDeadModPerLevel { get; set; }

        [JsonProperty(PropertyName = "PercentArmorPenetrationModPerLevel")]
        public double PercentArmorPenetrationModPerLevel { get; set; }

        [JsonProperty(PropertyName = "PercentCritDamageMod")]
        public double PercentCritDamageMod { get; set; }

        [JsonProperty(PropertyName = "PercentSpellBlockMod")]
        public double PercentSpellBlockMod { get; set; }

        [JsonProperty(PropertyName = "PercentHPRegenMod")]
        public double PercentHPRegenMod { get; set; }

        [JsonProperty(PropertyName = "PercentMovementSpeedMod")]
        public double PercentMovementSpeedMod { get; set; }

        [JsonProperty(PropertyName = "FlatSpellBlockMod")]
        public double FlatSpellBlockMod { get; set; }

        [JsonProperty(PropertyName = "FlatEnergyRegenModPerLevel")]
        public double FlatEnergyRegenModPerLevel { get; set; }

        [JsonProperty(PropertyName = "FlatEnergyPoolMod")]
        public double FlatEnergyPoolMod { get; set; }

        [JsonProperty(PropertyName = "FlatMagicPenetrationModPerLevel")]
        public double FlatMagicPenetrationModPerLevel { get; set; }

        [JsonProperty(PropertyName = "PercentLifeStealMod")]
        public double PercentLifeStealMod { get; set; }

        [JsonProperty(PropertyName = "FlatMPPoolMod")]
        public double FlatMPPoolMod { get; set; }

        [JsonProperty(PropertyName = "PercentCooldownMod")]
        public double PercentCooldownMod { get; set; }

        [JsonProperty(PropertyName = "PercentMagicPenetrationMod")]
        public double PercentMagicPenetrationMod { get; set; }

        [JsonProperty(PropertyName = "FlatArmorPenetrationModPerLevel")]
        public double FlatArmorPenetrationModPerLevel { get; set; }

        [JsonProperty(PropertyName = "FlatMovementSpeedMod")]
        public double FlatMovementSpeedMod { get; set; }

        [JsonProperty(PropertyName = "FlatTimeDeadModPerLevel")]
        public double FlatTimeDeadModPerLevel { get; set; }

        [JsonProperty(PropertyName = "FlatArmorModPerLevel")]
        public double FlatArmorModPerLevel { get; set; }

        [JsonProperty(PropertyName = "PercentAttackSpeedMod")]
        public double PercentAttackSpeedMod { get; set; }

        [JsonProperty(PropertyName = "FlatDodgeModPerLevel")]
        public double FlatDodgeModPerLevel { get; set; }

        [JsonProperty(PropertyName = "PercentMagicDamageMod")]
        public double PercentMagicDamageMod { get; set; }

        [JsonProperty(PropertyName = "PercentBlockMod")]
        public double PercentBlockMod { get; set; }

        [JsonProperty(PropertyName = "FlatDodgeMod")]
        public double FlatDodgeMod { get; set; }

        [JsonProperty(PropertyName = "FlatEnergyRegenMod")]
        public double FlatEnergyRegenMod { get; set; }

        [JsonProperty(PropertyName = "FlatHPModPerLevel")]
        public double FlatHPModPerLevel { get; set; }

        [JsonProperty(PropertyName = "PercentAttackSpeedModPerLevel")]
        public double PercentAttackSpeedModPerLevel { get; set; }

        [JsonProperty(PropertyName = "PercentSpellVampMod")]
        public double PercentSpellVampMod { get; set; }

        [JsonProperty(PropertyName = "FlatMPRegenMod")]
        public double FlatMPRegenMod { get; set; }

        [JsonProperty(PropertyName = "PercentHPPoolMod")]
        public double PercentHPPoolMod { get; set; }

        [JsonProperty(PropertyName = "PercentDodgeMod")]
        public double PercentDodgeMod { get; set; }

        [JsonProperty(PropertyName = "FlatAttackSpeedMod")]
        public double FlatAttackSpeedMod { get; set; }

        [JsonProperty(PropertyName = "FlatArmorMod")]
        public double FlatArmorMod { get; set; }

        [JsonProperty(PropertyName = "FlatMagicDamageModPerLevel")]
        public double FlatMagicDamageModPerLevel { get; set; }

        [JsonProperty(PropertyName = "FlatHPRegenMod")]
        public double FlatHPRegenMod { get; set; }

        [JsonProperty(PropertyName = "PercentPhysicalDamageMod")]
        public double PercentPhysicalDamageMod { get; set; }

        [JsonProperty(PropertyName = "FlatCritChanceModPerLevel")]
        public double FlatCritChanceModPerLevel { get; set; }

        [JsonProperty(PropertyName = "FlatSpellBlockModPerLevel")]
        public double FlatSpellBlockModPerLevel { get; set; }

        [JsonProperty(PropertyName = "PercentTimeDeadMod")]
        public double PercentTimeDeadMod { get; set; }

        [JsonProperty(PropertyName = "FlatBlockMod")]
        public double FlatBlockMod { get; set; }

        [JsonProperty(PropertyName = "PercentMPPoolMod")]
        public double PercentMPPoolMod { get; set; }

        [JsonProperty(PropertyName = "FlatMagicDamageMod")]
        public double FlatMagicDamageMod { get; set; }

        [JsonProperty(PropertyName = "PercentMPRegenMod")]
        public double PercentMPRegenMod { get; set; }

        [JsonProperty(PropertyName = "PercentMovementSpeedModPerLevel")]
        public double PercentMovementSpeedModPerLevel { get; set; }

        [JsonProperty(PropertyName = "PercentCooldownModPerLevel")]
        public double PercentCooldownModPerLevel { get; set; }

        [JsonProperty(PropertyName = "FlatMPModPerLevel")]
        public double FlatMPModPerLevel { get; set; }

        [JsonProperty(PropertyName = "FlatEnergyModPerLevel")]
        public double FlatEnergyModPerLevel { get; set; }

        [JsonProperty(PropertyName = "FlatPhysicalDamageMod")]
        public double FlatPhysicalDamageMod { get; set; }

        [JsonProperty(PropertyName = "FlatHPRegenModPerLevel")]
        public double FlatHPRegenModPerLevel { get; set; }

        [JsonProperty(PropertyName = "FlatCritDamageMod")]
        public double FlatCritDamageMod { get; set; }

        [JsonProperty(PropertyName = "PercentArmorMod")]
        public double PercentArmorMod { get; set; }

        [JsonProperty(PropertyName = "FlatMagicPenetrationMod")]
        public double FlatMagicPenetrationMod { get; set; }

        [JsonProperty(PropertyName = "PercentCritChanceMod")]
        public double PercentCritChanceMod { get; set; }

        [JsonProperty(PropertyName = "FlatPhysicalDamageModPerLevel")]
        public double FlatPhysicalDamageModPerLevel { get; set; }

        [JsonProperty(PropertyName = "PercentArmorPenetrationMod")]
        public double PercentArmorPenetrationMod { get; set; }

        [JsonProperty(PropertyName = "PercentEXPBonus")]
        public double PercentEXPBonus { get; set; }

        [JsonProperty(PropertyName = "FlatMPRegenModPerLevel")]
        public double FlatMPRegenModPerLevel { get; set; }

        [JsonProperty(PropertyName = "PercentMagicPenetrationModPerLevel")]
        public double PercentMagicPenetrationModPerLevel { get; set; }

        [JsonProperty(PropertyName = "FlatTimeDeadMod")]
        public double FlatTimeDeadMod { get; set; }

        [JsonProperty(PropertyName = "FlatMovementSpeedModPerLevel")]
        public double FlatMovementSpeedModPerLevel { get; set; }

        [JsonProperty(PropertyName = "FlatGoldPer10Mod")]
        public double FlatGoldPer10Mod { get; set; }

        [JsonProperty(PropertyName = "FlatArmorPenetrationMod")]
        public double FlatArmorPenetrationMod { get; set; }

        [JsonProperty(PropertyName = "FlatCritDamageModPerLevel")]
        public double FlatCritDamageModPerLevel { get; set; }

        [JsonProperty(PropertyName = "FlatHPPoolMod")]
        public double FlatHPPoolMod { get; set; }

        [JsonProperty(PropertyName = "FlatCritChanceMod")]
        public double FlatCritChanceMod { get; set; }

        [JsonProperty(PropertyName = "FlatEXPBonus")]
        public double FlatEXPBonus { get; set; }
    }

    public class MetaData
    {
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "isRune")]
        public bool IsRune { get; set; }
    }
}
