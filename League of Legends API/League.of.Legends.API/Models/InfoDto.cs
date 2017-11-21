using Newtonsoft.Json;

namespace League.of.Legends.API.Models
{
    public class InfoDto
    {
        [JsonProperty(PropertyName = "difficulty")]
        public int Difficulty { get; set; }

        [JsonProperty(PropertyName = "attack")]
        public int Attack { get; set; }

        [JsonProperty(PropertyName = "defense")]
        public int Defense { get; set; }

        [JsonProperty(PropertyName = "magic")]
        public int Magic { get; set; }
    }
}
