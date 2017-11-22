using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.API.Models
{
    public class MasteryDto
    {
        [JsonProperty(PropertyName = "prereq")]
        public string Prereq { get; set; }

        [JsonProperty(PropertyName = "masteryTree")]
        public string MasteryTree { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "ranks")]
        public int Ranks { get; set; }

        [JsonProperty(PropertyName = "image")]
        public ImageDto Image { get; set; }

        [JsonProperty(PropertyName = "sanitizedDescription")]
        public List<string> SanitizedDescription { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "description")]
        public List<string> description { get; set; }
    }
}
