using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.API.Models
{
    public class BlockDto
    {
        [JsonProperty(PropertyName = "items")]
        public BlockItemDtoList Items { get; set; }

        [JsonProperty(PropertyName = "recMath")]
        public bool RecMath { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
    public class BlockDtoList : List<BlockDto> { }
}
