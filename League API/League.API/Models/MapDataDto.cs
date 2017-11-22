using RestSharp.Deserializers;

namespace League.API.Models
{
    public class MapDataDto
    {
        [DeserializeAs(Name = "data")]
        public MapDetailsDto Data { get; set; }

        [DeserializeAs(Name = "type")]
        public string Type { get; set; }

        [DeserializeAs(Name = "version")]
        public string Version { get; set; }
    }
}
