using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class LevelTipDto
    {
        [JsonProperty(PropertyName = "effect")]
        public List<string> Effect { get; set; }

        [JsonProperty(PropertyName = "label")]
        public List<string> Label { get; set; }
    }
}
