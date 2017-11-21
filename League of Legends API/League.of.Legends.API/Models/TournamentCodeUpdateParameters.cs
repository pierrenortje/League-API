using RestSharp.Serializers;

namespace League.of.Legends.API.Models
{
    public class TournamentCodeUpdateParameters
    {
        /// <summary>
        /// The spectator type (Legal values: NONE, LOBBYONLY, ALL).
        /// </summary>
        [SerializeAs(Name = "spectatorType")]
        public string SpectatorType { get; set; }

        /// <summary>
        /// The pick type (Legal values: BLIND_PICK, DRAFT_MODE, ALL_RANDOM, TOURNAMENT_DRAFT).
        /// </summary>
        [SerializeAs(Name = "pickType")]
        public string PickType { get; set; }

        /// <summary>
        /// Comma separated list of summoner Ids.
        /// </summary>
        [SerializeAs(Name = "allowedParticipants")]
        public string AllowedParticipants { get; set; }

        /// <summary>
        /// The map type (Legal values: SUMMONERS_RIFT, TWISTED_TREELINE, HOWLING_ABYSS).
        /// </summary>
        [SerializeAs(Name = "mapType")]
        public string MapType { get; set; }
    }
}
