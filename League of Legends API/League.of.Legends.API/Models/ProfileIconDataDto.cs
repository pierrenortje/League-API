using RestSharp.Deserializers;

namespace League.of.Legends.API.Models
{
    public class ProfileIconDataDto
    {
        [DeserializeAs(Name = "data")]
        public ProfileIconDetailsDto Data { get; set; }

        [DeserializeAs(Name = "type")]
        public string Type { get; set; }

        [DeserializeAs(Name = "version")]
        public string Version { get; set; }
    }
}
