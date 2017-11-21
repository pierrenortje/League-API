using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class ChampionListDto
    {
        [JsonProperty(PropertyName = "keys")]
        public Dictionary<string, string> Keys { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, ChampionDto> Data { get; set; }

        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }
    }

    public class ChampionDto
    {
        [JsonProperty(PropertyName = "info")]
        public InfoDto Info { get; set; }

        [JsonProperty(PropertyName = "enemytips")]
        public List<string> EnemyTips { get; set; }

        [JsonProperty(PropertyName = "stats")]
        public StatsDto Stats { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "image")]
        public ImageDto Image { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public List<string> Tags { get; set; }

        [JsonProperty(PropertyName = "partype")]
        public string ParType { get; set; }

        [JsonProperty(PropertyName = "skins")]
        public SkinDtoList Skins { get; set; }

        [JsonProperty(PropertyName = "passive")]
        public PassiveDto Passive { get; set; }

        [JsonProperty(PropertyName = "recommended")]
        public RecommendedDtoList RecommendedList { get; set; }

        [JsonProperty(PropertyName = "allytips")]
        public List<string> Allytips { get; set; }

        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        [JsonProperty(PropertyName = "lore")]
        public string Lore { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "blurb")]
        public string Blurb { get; set; }

        [JsonProperty(PropertyName = "spells")]
        public ChampionSpells Spells { get; set; }
    }
}
