using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.API.Models
{
    public class ItemTreeDto
    {
        [JsonProperty(PropertyName = "header")]
        public string Header { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public List<string> Tags { get; set; }
    }
    public class ItemTreeDtoList : List<ItemTreeDto> { }
}
