using RestSharp.Deserializers;

namespace League.API.Models
{
    public class MatchParticipantFrameDto
    {
        [DeserializeAs(Name = "totalGold")]
        public int TotalGold { get; set; }

        [DeserializeAs(Name = "teamScore")]
        public int TeamScore { get; set; }

        [DeserializeAs(Name = "participantId")]
        public int ParticipantId { get; set; }

        [DeserializeAs(Name = "level")]
        public int Level { get; set; }

        [DeserializeAs(Name = "currentGold")]
        public int CurrentGold { get; set; }

        [DeserializeAs(Name = "minionsKilled")]
        public int MinionsKilled { get; set; }

        [DeserializeAs(Name = "dominionScore")]
        public int DominionScore { get; set; }

        [DeserializeAs(Name = "position")]
        public MatchPositionDto Position { get; set; }

        [DeserializeAs(Name = "xp")]
        public int XP { get; set; }

        [DeserializeAs(Name = "jungleMinionsKilled")]
        public int JungleMinionsKilled { get; set; }
    }
}
