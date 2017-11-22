using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.API.Models
{
    public class MatchReferenceDto
    {
        [DeserializeAs(Name = "lane")]
        public string Lane { get; set; }

        [DeserializeAs(Name = "gameId")]
        public long GameId { get; set; }

        [DeserializeAs(Name = "champion")]
        public int Champion { get; set; }

        [DeserializeAs(Name = "platformId")]
        public string PlatformId { get; set; }

        [DeserializeAs(Name = "season")]
        public int Season { get; set; }

        [DeserializeAs(Name = "queue")]
        public int Queue { get; set; }

        [DeserializeAs(Name = "role")]
        public string Role { get; set; }

        [DeserializeAs(Name = "timestamp")]
        public long Timestamp { get; set; }
    }
    public class MatchReferenceDtoList : List<MatchReferenceDto> { }
}
