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
    public class MatchEventDto
    {
        [DeserializeAs(Name = "eventType")]
        public string EventType { get; set; }

        [DeserializeAs(Name = "towerType")]
        public string TowerType { get; set; }

        [DeserializeAs(Name = "teamId")]
        public int TeamId { get; set; }

        [DeserializeAs(Name = "ascendedType")]
        public string AscendedType { get; set; }

        [DeserializeAs(Name = "killerId")]
        public int KillerId { get; set; }

        [DeserializeAs(Name = "levelUpType")]
        public string LevelUpType { get; set; }

        [DeserializeAs(Name = "pointCaptured")]
        public string PointCaptured { get; set; }

        [DeserializeAs(Name = "assistingParticipantIds")]
        public List<int> AssistingParticipantIds { get; set; }

        [DeserializeAs(Name = "wardType")]
        public string WardType { get; set; }

        [DeserializeAs(Name = "monsterType")]
        public string MonsterType { get; set; }

        /// <summary>
        /// Legal values:
        /// CHAMPION_KILL, WARD_PLACED, WARD_KILL, BUILDING_KILL, ELITE_MONSTER_KILL,
        /// ITEM_PURCHASED, ITEM_SOLD, ITEM_DESTROYED, ITEM_UNDO, SKILL_LEVEL_UP,
        /// ASCENDED_EVENT, CAPTURE_POINT, PORO_KING_SUMMON
        /// </summary>
        [DeserializeAs(Name = "type")]
        public string Type { get; set; }

        [DeserializeAs(Name = "skillSlot")]
        public int SkillSlot { get; set; }

        [DeserializeAs(Name = "victimId")]
        public int VictimId { get; set; }

        [DeserializeAs(Name = "timestamp")]
        public long Timestamp { get; set; }

        [DeserializeAs(Name = "afterId")]
        public int AfterId { get; set; }

        [DeserializeAs(Name = "monsterSubType")]
        public string MonsterSubType { get; set; }

        [DeserializeAs(Name = "laneType")]
        public string LaneType { get; set; }

        [DeserializeAs(Name = "itemId")]
        public int ItemId { get; set; }

        [DeserializeAs(Name = "participantId")]
        public int ParticipantId { get; set; }

        [DeserializeAs(Name = "buildingType")]
        public string BuildingType { get; set; }

        [DeserializeAs(Name = "creatorId")]
        public int CreatorId { get; set; }

        [DeserializeAs(Name = "position")]
        public MatchPositionDto Position { get; set; }

        [DeserializeAs(Name = "beforeId")]
        public int BeforeId { get; set; }
    }
    public class MatchEventDtoList : List<MatchEventDto> { }
}
