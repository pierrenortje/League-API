using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.API.Models
{
    public class BlockItemDto
    {
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }
    }
    public class BlockItemDtoList : List<BlockItemDto> { }
}
