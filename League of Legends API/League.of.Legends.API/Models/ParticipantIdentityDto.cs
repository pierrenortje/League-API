using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class ParticipantIdentityDto
    {
        [DeserializeAs(Name = "player")]
        public PlayerDto Player { get; set; }

        [DeserializeAs(Name = "participantId")]
        public int ParticipantId { get; set; }
    }
    public class ParticipantIdentityDtoList : List<ParticipantIdentityDto> { }
}
