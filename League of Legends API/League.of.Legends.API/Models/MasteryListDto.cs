using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class MasteryListDto
    {
        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, ItemDto> Data { get; set; }

        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "tree")]
        public ItemTreeDtoList Trees { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
