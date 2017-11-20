using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class SummonerSpellListDto
    {
        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, RuneDto> Data { get; set; }

        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }

    public class SummonerSpellDto
    {
        [JsonProperty(PropertyName = "vars")]
        public SpellVarsDtoList Vars { get; set; }

        [JsonProperty(PropertyName = "image")]
        public ImageDto Image { get; set; }

        [JsonProperty(PropertyName = "costBurn")]
        public string CostBurn { get; set; }

        [JsonProperty(PropertyName = "cooldown")]
        public List<double> Cooldown { get; set; }

        [JsonProperty(PropertyName = "effectBurn")]
        public List<string> EffectBurn { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "cooldownBurn")]
        public string CooldownBurn { get; set; }

        [JsonProperty(PropertyName = "tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty(PropertyName = "maxrank")]
        public int Maxrank { get; set; }

        [JsonProperty(PropertyName = "rangeBurn")]
        public string RangeBurn { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// This field is a List of List of Double.
        /// </summary>
        [JsonProperty(PropertyName = "effect")]
        public List<object> Effect { get; set; }

        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        [JsonProperty(PropertyName = "leveltip")]
        public LevelTipDto Leveltip { get; set; }

        [JsonProperty(PropertyName = "modes")]
        public List<string> Modes { get; set; }

        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "costType")]
        public string CostType { get; set; }

        [JsonProperty(PropertyName = "sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty(PropertyName = "sanitizedTooltip")]
        public string SanitizedTooltip { get; set; }

        /// <summary>
        /// This field is either a List of Integer or the String
        /// 'self' for spells that target one's own champion.
        /// </summary>
        [JsonProperty(PropertyName = "range")]
        public object Range { get; set; }

        [JsonProperty(PropertyName = "cost")]
        public List<int> Cost { get; set; }

        [JsonProperty(PropertyName = "summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}
