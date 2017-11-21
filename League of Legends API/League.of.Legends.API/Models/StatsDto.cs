using Newtonsoft.Json;

namespace League.of.Legends.API.Models
{
    public class StatsDto
    {
        [JsonProperty(PropertyName = "armorperlevel")]
        public double ArmorPerLevel { get; set; }

        [JsonProperty(PropertyName = "hpperlevel")]
        public double HPPerLevel { get; set; }

        [JsonProperty(PropertyName = "attackdamage")]
        public double AttackDamage { get; set; }

        [JsonProperty(PropertyName = "mpperlevel")]
        public double MPPerLevel { get; set; }

        [JsonProperty(PropertyName = "attackspeedoffset")]
        public double AttackSpeedOffset { get; set; }

        [JsonProperty(PropertyName = "armor")]
        public double Armor { get; set; }

        [JsonProperty(PropertyName = "hp")]
        public double HP { get; set; }

        [JsonProperty(PropertyName = "hpregenperlevel")]
        public double HPRegenPerLevel { get; set; }

        [JsonProperty(PropertyName = "spellblock")]
        public double SpellBlock { get; set; }

        [JsonProperty(PropertyName = "attackrange")]
        public double AttackRange { get; set; }

        [JsonProperty(PropertyName = "movespeed")]
        public double MoveSpeed { get; set; }

        [JsonProperty(PropertyName = "attackdamageperlevel")]
        public double AttackDamagePerLevel { get; set; }

        [JsonProperty(PropertyName = "mpregenperlevel")]
        public double MPRegenPerLevel { get; set; }

        [JsonProperty(PropertyName = "mp")]
        public double MP { get; set; }

        [JsonProperty(PropertyName = "spellblockperlevel")]
        public double SpellblockPerLevel { get; set; }

        [JsonProperty(PropertyName = "crit")]
        public double Crit { get; set; }

        [JsonProperty(PropertyName = "mpregen")]
        public double MPRegen { get; set; }

        [JsonProperty(PropertyName = "attackspeedperlevel")]
        public double AttackSpeedPerLevel { get; set; }

        [JsonProperty(PropertyName = "hpregen")]
        public double HPRegen { get; set; }

        [JsonProperty(PropertyName = "critperlevel")]
        public double CritPerLevel { get; set; }
    }
}
