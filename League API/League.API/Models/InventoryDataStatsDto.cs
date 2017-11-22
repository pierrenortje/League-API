using Newtonsoft.Json;

namespace League.API.Models
{
    public class InventoryDataStatsDto
    {
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

        [JsonProperty(PropertyName = "FlatCritDamageMod")]
        public double FlatCritDamageMod { get; set; }

        [JsonProperty(PropertyName = "FlatEnergyPoolMod")]
        public double FlatEnergyPoolMod { get; set; }

        [JsonProperty(PropertyName = "PercentLifeStealMod")]
        public double PercentLifeStealMod { get; set; }

        [JsonProperty(PropertyName = "FlatMPPoolMod")]
        public double FlatMPPoolMod { get; set; }

        [JsonProperty(PropertyName = "FlatMovementSpeedMod")]
        public double FlatMovementSpeedMod { get; set; }

        [JsonProperty(PropertyName = "PercentAttackSpeedMod")]
        public double PercentAttackSpeedMod { get; set; }

        [JsonProperty(PropertyName = "FlatBlockMod")]
        public double FlatBlockMod { get; set; }

        [JsonProperty(PropertyName = "PercentBlockMod")]
        public double PercentBlockMod { get; set; }

        [JsonProperty(PropertyName = "FlatEnergyRegenMod")]
        public double FlatEnergyRegenMod { get; set; }

        [JsonProperty(PropertyName = "PercentSpellVampMod")]
        public double PercentSpellVampMod { get; set; }

        [JsonProperty(PropertyName = "FlatMPRegenMod")]
        public double FlatMPRegenMod { get; set; }

        [JsonProperty(PropertyName = "PercentDodgeMod")]
        public double PercentDodgeMod { get; set; }

        [JsonProperty(PropertyName = "FlatAttackSpeedMod")]
        public double FlatAttackSpeedMod { get; set; }

        [JsonProperty(PropertyName = "FlatArmorMod")]
        public double FlatArmorMod { get; set; }

        [JsonProperty(PropertyName = "FlatHPRegenMod")]
        public double FlatHPRegenMod { get; set; }

        [JsonProperty(PropertyName = "PercentMagicDamageMod")]
        public double PercentMagicDamageMod { get; set; }

        [JsonProperty(PropertyName = "PercentMPPoolMod")]
        public double PercentMPPoolMod { get; set; }

        [JsonProperty(PropertyName = "FlatMagicDamageMod")]
        public double FlatMagicDamageMod { get; set; }

        [JsonProperty(PropertyName = "PercentMPRegenMod")]
        public double PercentMPRegenMod { get; set; }

        [JsonProperty(PropertyName = "PercentPhysicalDamageMod")]
        public double PercentPhysicalDamageMod { get; set; }

        [JsonProperty(PropertyName = "FlatPhysicalDamageMod")]
        public double FlatPhysicalDamageMod { get; set; }

        [JsonProperty(PropertyName = "PercentHPPoolMod")]
        public double PercentHPPoolMod { get; set; }

        [JsonProperty(PropertyName = "PercentArmorMod")]
        public double PercentArmorMod { get; set; }

        [JsonProperty(PropertyName = "PercentCritChanceMod")]
        public double PercentCritChanceMod { get; set; }

        [JsonProperty(PropertyName = "PercentEXPBonus")]
        public double PercentEXPBonus { get; set; }

        [JsonProperty(PropertyName = "FlatHPPoolMod")]
        public double FlatHPPoolMod { get; set; }

        [JsonProperty(PropertyName = "FlatCritChanceMod")]
        public double FlatCritChanceMod { get; set; }

        [JsonProperty(PropertyName = "FlatEXPBonus")]
        public double FlatEXPBonus { get; set; }
    }
}
