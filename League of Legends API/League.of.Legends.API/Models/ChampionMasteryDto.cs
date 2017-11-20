using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class ChampionMasteryDto
    {
        /// <summary>
        /// Champion level for specified player and champion combination.
        /// </summary>
        [DeserializeAs(Name = "championLevel")]
        public int ChampionLevel { get; set; }

        /// <summary>
        /// Is chest granted for this champion or not in current season.
        /// </summary>
        [DeserializeAs(Name = "chestGranted")]
        public bool ChestGranted { get; set; }

        /// <summary>
        /// Total number of champion points for this player and champion combination - they are used to determine <see cref="ChampionLevel"/>.
        /// </summary>
        [DeserializeAs(Name = "championPoints")]
        public int ChampionPoints { get; set; }

        /// <summary>
        /// Number of points earned since current level has been achieved.
        /// Zero if player reached maximum champion level for this champion.
        /// </summary>
        [DeserializeAs(Name = "championPointsSinceLastLevel")]
        public int ChampionPointsSinceLastLevel { get; set; }

        /// <summary>
        /// Player ID for this entry.
        /// </summary>
        [DeserializeAs(Name = "playerId")]
        public int PlayerId { get; set; }

        /// <summary>
        /// Number of points needed to achieve next level.
        /// Zero if player reached maximum champion level for this champion.
        /// </summary>
        [DeserializeAs(Name = "championPointsUntilNextLevel")]
        public int ChampionPointsUntilNextLevel { get; set; }

        [DeserializeAs(Name = "tokensEarned")]
        public int TokensEarned { get; set; }

        /// <summary>
        /// Champion ID for this entry.
        /// </summary>
        [DeserializeAs(Name = "championId")]
        public int ChampionId { get; set; }

        /// <summary>
        /// Last time this champion was played by this player - in Unix milliseconds time format.
        /// </summary>
        [DeserializeAs(Name = "lastPlayTime")]
        public long LastPlayTime { get; set; }
    }

    public class ChampionMasteryDtoList : List<ChampionMasteryDto> { }
}
