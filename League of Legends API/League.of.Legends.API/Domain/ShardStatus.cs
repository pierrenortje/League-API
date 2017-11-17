using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Domain
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

    public class Message
    {
        [DeserializeAs(Name = "severity")]
        public string Severity { get; set; }

        [DeserializeAs(Name = "author")]
        public string Author { get; set; }

        [DeserializeAs(Name = "created_at")]
        public string CreatedAt { get; set; }

        [DeserializeAs(Name = "translations")]
        public Translations Translations { get; set; }

        [DeserializeAs(Name = "updated_at")]
        public string UpdatedAt { get; set; }

        [DeserializeAs(Name = "content")]
        public string Content { get; set; }

        [DeserializeAs(Name = "id")]
        public string ID { get; set; }
    }
    public class Messages : List<Message> { }

    public class Translation
    {
        [DeserializeAs(Name = "locale")]
        public string Locale { get; set; }

        [DeserializeAs(Name = "content")]
        public string Content { get; set; }

        [DeserializeAs(Name = "updated_at")]
        public string UpdatedAt { get; set; }
    }
    public class Translations : List<Translation> { }
}
