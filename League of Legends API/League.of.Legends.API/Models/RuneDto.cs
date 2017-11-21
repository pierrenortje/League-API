using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class RuneDto
    {
        [JsonProperty(PropertyName = "stats")]
        public RuneStatsDto Stats { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public List<string> Tags { get; set; }

        [JsonProperty(PropertyName = "image")]
        public ImageDto Image { get; set; }

        [JsonProperty(PropertyName = "sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty(PropertyName = "rune")]
        public MetaDataDto RuneData { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
