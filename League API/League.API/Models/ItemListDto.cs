using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.API.Models
{
    public class ItemListDto
    {
        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, ItemDto> Data { get; set; }

        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "tree")]
        public ItemTreeDtoList Trees { get; set; }

        [JsonProperty(PropertyName = "groups")]
        public ItemGroups Groups { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
