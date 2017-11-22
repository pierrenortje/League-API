using Newtonsoft.Json;

namespace League.API.Models
{
    public class GoldDto
    {
        [JsonProperty(PropertyName = "sell")]
        public int Sell { get; set; }

        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }

        [JsonProperty(PropertyName = "base")]
        public int Base { get; set; }

        [JsonProperty(PropertyName = "purchasable")]
        public bool Purchasable { get; set; }
    }
}
