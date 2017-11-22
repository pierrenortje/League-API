using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.API.Models
{
    public class Incident
    {
        [DeserializeAs(Name = "active")]
        public bool Active { get; set; }

        [DeserializeAs(Name = "created_at")]
        public string CreatedAt { get; set; }

        [DeserializeAs(Name = "id")]
        public long ID { get; set; }

        [DeserializeAs(Name = "updates")]
        public Messages Updates { get; set; }
    }
    public class Incidents : List<Incident> { }
}
