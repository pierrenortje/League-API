using Newtonsoft.Json;
using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class MapDataDto
    {
        [DeserializeAs(Name = "data")]
        public MapDetailsDto Data { get; set; }

        [DeserializeAs(Name = "type")]
        public string Type { get; set; }

        [DeserializeAs(Name = "version")]
        public string Version { get; set; }
    }

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
