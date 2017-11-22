using Newtonsoft.Json;
using System.Collections.Generic;

namespace League.API.Models
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
