using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class BannedChampion
    {
        /// <summary>
        /// The turn during which the champion was banned.
        /// </summary>
        [DeserializeAs(Name = "pickTurn")]
        public int PickTurn { get; set; }

        /// <summary>
        /// The ID of the banned champion.
        /// </summary>
        [DeserializeAs(Name = "championId")]
        public long ChampionId { get; set; }

        /// <summary>
        /// The ID of the team that banned the champion.
        /// </summary>
        [DeserializeAs(Name = "teamId")]
        public long TeamId { get; set; }
    }
    public class BannedChampions : List<BannedChampion> { }
}
