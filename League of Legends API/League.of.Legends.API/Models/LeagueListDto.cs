using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class LeagueListDto
    {
        [DeserializeAs(Name = "leagueId")]
        public string LeagueId { get; set; }

        [DeserializeAs(Name = "tier")]
        public string Tier { get; set; }

        [DeserializeAs(Name = "entries")]
        public LeagueItemDtoList Leagues { get; set; }

        [DeserializeAs(Name = "queue")]
        public string Queue { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }
    }
    public class LeagueListDtoList : List<LeagueListDto> { }
}
