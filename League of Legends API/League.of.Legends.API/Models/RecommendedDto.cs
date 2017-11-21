using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class RecommendedDto
    {
        [JsonProperty(PropertyName = "map")]
        public string Map { get; set; }

        [JsonProperty(PropertyName = "blocks")]
        public BlockDtoList Blocks { get; set; }

        [JsonProperty(PropertyName = "champion")]
        public string Champion { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "priority")]
        public bool Priority { get; set; }

        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
    public class RecommendedDtoList : List<RecommendedDto> { }
}
