using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class SkinDto
    {
        [JsonProperty(PropertyName = "num")]
        public string Num { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string ID { get; set; }
    }
    public class SkinDtoList : List<SkinDto> { }
}
