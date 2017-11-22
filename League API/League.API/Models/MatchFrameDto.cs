using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.API.Models
{
    public class MatchFrameDto
    {
        [DeserializeAs(Name = "timestamp")]
        public long Timestamp { get; set; }

        [DeserializeAs(Name = "participantFrames")]
        public Dictionary<int, MatchParticipantFrameDto> ParticipantFrames { get; set; }

        [DeserializeAs(Name = "events")]
        public MatchEventDtoList Events { get; set; }
    }
    public class MatchFrameDtoList : List<MatchFrameDto> { }
}
