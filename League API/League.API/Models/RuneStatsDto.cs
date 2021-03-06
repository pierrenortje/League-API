﻿#region License
// Copyright (c) 2017 Pierre Nortje
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using Newtonsoft.Json;

namespace League.API.Models
{
    public class RuneStatsDto
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
}
