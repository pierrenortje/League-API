#region License
// Copyright (c) 2017 Pierre Nortje
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.API.Models
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
