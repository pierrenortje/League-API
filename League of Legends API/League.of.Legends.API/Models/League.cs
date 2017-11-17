using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class League
    {
        [DeserializeAs(Name = "hotStreak")]
        public bool HotStreak { get; set; }

        [DeserializeAs(Name = "wins")]
        public int Wins { get; set; }

        [DeserializeAs(Name = "veteran")]
        public bool Veteran { get; set; }

        [DeserializeAs(Name = "losses")]
        public int Losses { get; set; }

        [DeserializeAs(Name = "rank")]
        public string Rank { get; set; }

        [DeserializeAs(Name = "playerOrTeamName")]
        public string PlayerOrTeamName { get; set; }

        [DeserializeAs(Name = "inactive")]
        public bool Inactive { get; set; }

        [DeserializeAs(Name = "playerOrTeamId")]
        public string PlayerOrTeamId { get; set; }

        [DeserializeAs(Name = "freshBlood")]
        public bool FreshBlood { get; set; }

        [DeserializeAs(Name = "leaguePoints")]
        public int LeaguePoints { get; set; }
    }
    public class Leagues : List<League> { }

    public class LeagueRoot
    {
        [DeserializeAs(Name = "tier")]
        public string Tier { get; set; }

        [DeserializeAs(Name = "queue")]
        public string Queue { get; set; }

        [DeserializeAs(Name = "leagueId")]
        public string LeagueId { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "entries")]
        public Leagues Leagues { get; set; }
    }
    public class LeagueRootList : List<LeagueRoot> { }
}
