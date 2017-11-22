using RestSharp.Serializers;

namespace League.API.Models
{
    public class TournamentCodeParameters
    {
        /// <summary>
        /// The spectator type of the game. (Legal values: NONE, LOBBYONLY, ALL).
        /// </summary>
        [SerializeAs(Name = "spectatorType")]
        public string SpectatorType { get; set; }

        /// <summary>
        /// The team size of the game. Valid values are 1-5.
        /// </summary>
        [SerializeAs(Name = "teamSize")]
        public int TeamSize { get; set; }

        /// <summary>
        /// The pick type of the game. (Legal values: BLIND_PICK, DRAFT_MODE, ALL_RANDOM, TOURNAMENT_DRAFT).
        /// </summary>
        [SerializeAs(Name = "pickType")]
        public string PickType { get; set; }

        /// <summary>
        /// Optional list of participants in order to validate the players eligible to join the lobby.
        /// NOTE: We currently do not enforce participants at the team level, but rather the aggregate of
        /// teamOne and teamTwo. We may add the ability to enforce at the team level in the future.
        /// </summary>
        [SerializeAs(Name = "allowedSummonerIdstatorType")]
        public SummonerIdParams AllowedSummonerIds { get; set; }

        /// <summary>
        /// The map type of the game. (Legal values: SUMMONERS_RIFT, TWISTED_TREELINE, HOWLING_ABYSS).
        /// </summary>
        [SerializeAs(Name = "mapType")]
        public string MapType { get; set; }

        /// <summary>
        /// Optional string that may contain any data in any format, if specified at all.
        /// Used to denoteany custom information about the game.
        /// </summary>
        [SerializeAs(Name = "metadata")]
        public string Metadata { get; set; }
    }
}
