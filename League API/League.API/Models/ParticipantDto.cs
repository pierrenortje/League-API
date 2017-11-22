using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.API.Models
{
    public class ParticipantDto
    {
        [DeserializeAs(Name = "stats")]
        public ParticipantStats Stats { get; set; }

        [DeserializeAs(Name = "participantId")]
        public int ParticipantId { get; set; }

        [DeserializeAs(Name = "runes")]
        public RuneItemList Runes { get; set; }

        [DeserializeAs(Name = "timeline")]
        public ParticipantTimelineDto Timeline { get; set; }

        [DeserializeAs(Name = "teamId")]
        public int TeamId { get; set; }

        [DeserializeAs(Name = "spell2Id")]
        public int Spell2Id { get; set; }

        [DeserializeAs(Name = "masteries")]
        public Masteries Masteries { get; set; }

        [DeserializeAs(Name = "highestAchievedSeasonTier")]
        public string HighestAchievedSeasonTier { get; set; }

        [DeserializeAs(Name = "spell1Id")]
        public int Spell1Id { get; set; }

        [DeserializeAs(Name = "championId")]
        public int ChampionId { get; set; }
    }
    public class ParticipantDtoList : List<ParticipantDto> { }
}
