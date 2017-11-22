using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.API.Models
{
    public class ImageDto
    {
        [JsonProperty(PropertyName = "full")]
        public string Full { get; set; }

        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        [JsonProperty(PropertyName = "sprite")]
        public string Sprite { get; set; }

        [JsonProperty(PropertyName = "h")]
        public int H { get; set; }

        [JsonProperty(PropertyName = "w")]
        public int W { get; set; }

        [JsonProperty(PropertyName = "y")]
        public int Y { get; set; }

        [JsonProperty(PropertyName = "x")]
        public int X { get; set; }
    }
    public class ImageDtoList : List<ImageDto> { }
}
