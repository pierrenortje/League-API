using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class TeamBans
    {
        [DeserializeAs(Name = "pickTurn")]
        public int PickTurn { get; set; }

        [DeserializeAs(Name = "championId")]
        public int ChampionId { get; set; }
    }
    public class TeamBansList : List<TeamBans> { }
}
