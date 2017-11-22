using RestSharp.Deserializers;

namespace League.API.Models
{
    public class MatchlistDto
    {
        [DeserializeAs(Name = "matches")]
        public MatchReferenceDtoList Matches { get; set; }

        [DeserializeAs(Name = "totalGames")]
        public int TotalGames { get; set; }

        [DeserializeAs(Name = "startIndex")]
        public int StartIndex { get; set; }

        [DeserializeAs(Name = "endIndex")]
        public int EndIndex { get; set; }
    }
}
