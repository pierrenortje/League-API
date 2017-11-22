using Newtonsoft.Json;

namespace League.API.Models
{
    public class MetaDataDto
    {
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "isRune")]
        public bool IsRune { get; set; }
    }
}
