using RestSharp.Deserializers;

namespace League.API.Models
{
    public class TournamentCodeDto
    {
        /// <summary>
        /// The game map for the tournament code game.
        /// </summary>
        [DeserializeAs(Name = "map")]
        public string Map { get; set; }

        /// <summary>
        /// The tournament code.
        /// </summary>
        [DeserializeAs(Name = "code")]
        public string Code { get; set; }

        /// <summary>
        /// The spectator mode for the tournament code game.
        /// </summary>
        [DeserializeAs(Name = "spectators")]
        public string Spectators { get; set; }

        /// <summary>
        /// The tournament code's region. (Legal values: BR, EUNE, EUW, JP, LAN, LAS, NA, OCE, PBE, RU, TR).
        /// </summary>
        [DeserializeAs(Name = "region")]
        public string Region { get; set; }

        /// <summary>
        /// The provider's ID.
        /// </summary>
        [DeserializeAs(Name = "providerId")]
        public string ProviderId { get; set; }

        /// <summary>
        /// The team size for the tournament code game.
        /// </summary>
        [DeserializeAs(Name = "teamSize")]
        public string TeamSize { get; set; }

        [DeserializeAs(Name = "participants")]
        public string Participants { get; set; }

        /// <summary>
        /// The pick mode for tournament code game.
        /// </summary>
        [DeserializeAs(Name = "pickType")]
        public string PickType { get; set; }

        /// <summary>
        /// The tournament's ID.
        /// </summary>
        [DeserializeAs(Name = "tournamentId")]
        public string TournamentId { get; set; }

        /// <summary>
        /// The lobby name for the tournament code game.
        /// </summary>
        [DeserializeAs(Name = "lobbyName")]
        public string LobbyName { get; set; }

        /// <summary>
        /// The password for the tournament code game.
        /// </summary>
        [DeserializeAs(Name = "password")]
        public string Password { get; set; }

        /// <summary>
        /// The tournament code's ID.
        /// </summary>
        [DeserializeAs(Name = "id")]
        public string ID { get; set; }

        /// <summary>
        /// The metadata for tournament code.
        /// </summary>
        [DeserializeAs(Name = "metaData")]
        public string MetaData { get; set; }
    }
}
