using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.API.Models
{
    public class LanguageStringsDto
    {
        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, string> Data { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
    }
}
