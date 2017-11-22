using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.API.Models
{
    public class MapDetailsDto
    {
        [JsonProperty(PropertyName = "mapName")]
        public string MapName { get; set; }

        [JsonProperty(PropertyName = "image")]
        public ImageDto Image { get; set; }

        [JsonProperty(PropertyName = "mapId")]
        public long MapId { get; set; }

        [JsonProperty(PropertyName = "unpurchasableItemList")]
        public List<long> UnpurchasableItemList { get; set; }
    }
}
