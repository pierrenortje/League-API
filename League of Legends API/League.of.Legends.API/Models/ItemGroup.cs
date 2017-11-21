using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class ItemGroup
    {
        [JsonProperty(PropertyName = "MaxGroupOwnable")]
        public string MaxGroupOwnable { get; set; }

        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
    }
    public class ItemGroups : List<ItemGroup> { }
}
