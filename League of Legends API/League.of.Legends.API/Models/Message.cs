using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
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
}
