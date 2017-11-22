using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.API.Models
{
    public class LeagueItemDto
    {
        [DeserializeAs(Name = "rank")]
        public string Rank { get; set; }

        [DeserializeAs(Name = "hotStreak")]
        public bool HotStreak { get; set; }

        [DeserializeAs(Name = "miniSeries")]
        public MiniSeriesDto MiniSeries { get; set; }

        [DeserializeAs(Name = "wins")]
        public string Wins { get; set; }

        [DeserializeAs(Name = "veteran")]
        public bool Veteran { get; set; }

        [DeserializeAs(Name = "losses")]
        public int Losses { get; set; }

        [DeserializeAs(Name = "freshBlood")]
        public bool FreshBlood { get; set; }

        [DeserializeAs(Name = "playerOrTeamName")]
        public string PlayerOrTeamName { get; set; }

        [DeserializeAs(Name = "inactive")]
        public bool Inactive { get; set; }

        [DeserializeAs(Name = "playerOrTeamId")]
        public string PlayerOrTeamId { get; set; }

        [DeserializeAs(Name = "leaguePoints")]
        public int LeaguePoints { get; set; }
    }
    public class LeagueItemDtoList : List<LeagueItemDto> { }
}
