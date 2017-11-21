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
}
