using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class ShardStatus
    {
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "region_tag")]
        public string RegionTag { get; set; }

        [DeserializeAs(Name = "hostname")]
        public string Hostname { get; set; }

        [DeserializeAs(Name = "services")]
        public Services Services { get; set; }

        [DeserializeAs(Name = "slug")]
        public string Slug { get; set; }

        [DeserializeAs(Name = "locales")]
        public List<string> Locales { get; set; }
    }
}
