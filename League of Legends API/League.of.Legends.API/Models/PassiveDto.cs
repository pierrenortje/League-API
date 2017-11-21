using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class PassiveDto
    {
        [JsonProperty(PropertyName = "image")]
        public ImageDto Image { get; set; }

        [JsonProperty(PropertyName = "sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
