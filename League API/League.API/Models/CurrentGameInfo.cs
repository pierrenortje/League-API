using RestSharp.Deserializers;

namespace League.API.Models
{
    public class CurrentGameInfo
    {
        /// <summary>
        /// The ID of the game.
        /// </summary>
        [DeserializeAs(Name = "gameId")]
        public long GameId { get; set; }

        /// <summary>
        /// The game start time represented in epoch milliseconds.
        /// </summary>
        [DeserializeAs(Name = "gameStartTime")]
        public long GameStartTime { get; set; }

        /// <summary>
        /// The ID of the platform on which the game is being played.
        /// </summary>
        [DeserializeAs(Name = "platformId")]
        public string PlatformId { get; set; }

        /// <summary>
        /// The game mode.
        /// </summary>
        [DeserializeAs(Name = "gameMode")]
        public string GameMode { get; set; }

        /// <summary>
        /// The ID of the map.
        /// </summary>
        [DeserializeAs(Name = "mapId")]
        public long MapId { get; set; }

        /// <summary>
        /// The game type.
        /// </summary>
        [DeserializeAs(Name = "gameType")]
        public string GameType { get; set; }

        /// <summary>
        /// Banned champion information.
        /// </summary>
        [DeserializeAs(Name = "bannedChampions")]
        public BannedChampions BannedChampions { get; set; }

        /// <summary>
        /// The observer information.
        /// </summary>
        [DeserializeAs(Name = "observers")]
        public Observer Observers { get; set; }

        /// <summary>
        /// The participant information.
        /// </summary>
        [DeserializeAs(Name = "participants")]
        public CurrentGameParticipants Participants { get; set; }

        /// <summary>
        /// The amount of time in seconds that has passed since the game started.
        /// </summary>
        [DeserializeAs(Name = "gameLength")]
        public long GameLength { get; set; }

        /// <summary>
        /// The queue type (queue types are documented on the Game Constants page).
        /// </summary>
        [DeserializeAs(Name = "gameQueueConfigId")]
        public long GameQueueConfigId { get; set; }
    }
}
