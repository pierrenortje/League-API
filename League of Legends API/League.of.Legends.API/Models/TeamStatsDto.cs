using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class TeamStatsDto
    {
        [DeserializeAs(Name = "firstDragon")]
        public bool FirstDragon { get; set; }

        [DeserializeAs(Name = "firstInhibitor")]
        public bool FirstInhibitor { get; set; }

        [DeserializeAs(Name = "bans")]
        public TeamBansList Bans { get; set; }

        [DeserializeAs(Name = "baronKills")]
        public int BaronKills { get; set; }

        [DeserializeAs(Name = "firstRiftHerald")]
        public bool FirstRiftHerald { get; set; }

        [DeserializeAs(Name = "firstBaron")]
        public bool FirstBaron { get; set; }

        [DeserializeAs(Name = "riftHeraldKills")]
        public int RiftHeraldKills { get; set; }

        [DeserializeAs(Name = "firstBlood")]
        public bool firstBlood { get; set; }

        [DeserializeAs(Name = "teamId")]
        public int TeamId { get; set; }

        [DeserializeAs(Name = "firstTower")]
        public bool FirstTower { get; set; }

        [DeserializeAs(Name = "vilemawKills")]
        public int VilemawKills { get; set; }

        [DeserializeAs(Name = "inhibitorKills")]
        public int InhibitorKills { get; set; }

        [DeserializeAs(Name = "towerKills")]
        public int TowerKills { get; set; }

        [DeserializeAs(Name = "dominionVictoryScore")]
        public int DominionVictoryScore { get; set; }

        [DeserializeAs(Name = "win")]
        public string Win { get; set; }

        [DeserializeAs(Name = "dragonKills")]
        public int DragonKills { get; set; }
    }
    public class TeamStatsDtoList : List<TeamStatsDto> { }
}
