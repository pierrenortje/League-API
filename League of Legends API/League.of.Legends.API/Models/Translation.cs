using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
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
