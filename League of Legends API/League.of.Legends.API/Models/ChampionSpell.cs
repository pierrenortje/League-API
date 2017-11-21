using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class ChampionSpell
    {
        [JsonProperty(PropertyName = "cooldownBurn")]
        public string CooldownBurn { get; set; }

        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        [JsonProperty(PropertyName = "leveltip")]
        public LevelTipDto Leveltip { get; set; }

        [JsonProperty(PropertyName = "vars")]
        public SpellVarsDtoList Vars { get; set; }

        [JsonProperty(PropertyName = "costType")]
        public string CostType { get; set; }

        [JsonProperty(PropertyName = "image")]
        public ImageDto Image { get; set; }

        [JsonProperty(PropertyName = "sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty(PropertyName = "sanitizedTooltip")]
        public string SanitizedTooltip { get; set; }

        [JsonProperty(PropertyName = "effect")]
        public List<double> Effect { get; set; }

        [JsonProperty(PropertyName = "tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty(PropertyName = "maxrank")]
        public int Maxrank { get; set; }

        [JsonProperty(PropertyName = "costBurn")]
        public string CostBurn { get; set; }

        [JsonProperty(PropertyName = "rangeBurn")]
        public string RangeBurn { get; set; }

        [JsonProperty(PropertyName = "range")]
        public object Range { get; set; }

        [JsonProperty(PropertyName = "cooldown")]
        public List<double> Cooldown { get; set; }

        [JsonProperty(PropertyName = "cost")]
        public List<int> Cost { get; set; }

        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "effectBurn")]
        public List<string> EffectBurn { get; set; }

        [JsonProperty(PropertyName = "altimages")]
        public ImageDtoList Altimages { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
    public class ChampionSpells : List<ChampionSpell> { }
}
