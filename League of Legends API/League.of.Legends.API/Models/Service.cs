using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class Service
    {
        [DeserializeAs(Name = "status")]
        public string Status { get; set; }

        [DeserializeAs(Name = "incidents")]
        public Incidents Incidents { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "slug")]
        public string Slug { get; set; }
    }
    public class Services : List<Service> { }
}
