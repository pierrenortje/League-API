using RestSharp.Deserializers;

namespace League.API.Models
{
    public class MatchDto
    {
        [DeserializeAs(Name = "seasonId")]
        public int SeasonId { get; set; }

        [DeserializeAs(Name = "queueId")]
        public int QueueId { get; set; }

        [DeserializeAs(Name = "gameId")]
        public long GameId { get; set; }

        [DeserializeAs(Name = "participantIdentities")]
        public ParticipantIdentityDtoList ParticipantIdentities { get; set; }

        [DeserializeAs(Name = "gameVersion")]
        public string GameVersion { get; set; }

        [DeserializeAs(Name = "platformId")]
        public string PlatformId { get; set; }

        [DeserializeAs(Name = "gameMode")]
        public string GameMode { get; set; }

        [DeserializeAs(Name = "mapId")]
        public int MapId { get; set; }

        [DeserializeAs(Name = "gameType")]
        public string GameType { get; set; }

        [DeserializeAs(Name = "teams")]
        public TeamStatsDtoList Teams { get; set; }

        [DeserializeAs(Name = "participants")]
        public ParticipantDtoList Participants { get; set; }

        [DeserializeAs(Name = "gameDuration")]
        public long GameDuration { get; set; }

        [DeserializeAs(Name = "gameCreation")]
        public long GameCreation { get; set; }
    }
}
