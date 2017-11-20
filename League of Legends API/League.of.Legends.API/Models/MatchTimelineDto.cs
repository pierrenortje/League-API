using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class MatchTimelineDto
    {
        [DeserializeAs(Name = "frames")]
        public MatchFrameDtoList Frames { get; set; }

        [DeserializeAs(Name = "frameInterval")]
        public long FrameInterval { get; set; }
    }

    public class MatchFrameDto
    {
        [DeserializeAs(Name = "timestamp")]
        public long Timestamp { get; set; }

        [DeserializeAs(Name = "participantFrames")]
        public Dictionary<int, MatchParticipantFrameDto> ParticipantFrames { get; set; }

        [DeserializeAs(Name = "events")]
        public MatchEventDtoList Events { get; set; }
    }
    public class MatchFrameDtoList : List<MatchFrameDto> { }

    public class MatchParticipantFrameDto
    {
        [DeserializeAs(Name = "totalGold")]
        public int TotalGold { get; set; }

        [DeserializeAs(Name = "teamScore")]
        public int TeamScore { get; set; }

        [DeserializeAs(Name = "participantId")]
        public int ParticipantId { get; set; }

        [DeserializeAs(Name = "level")]
        public int Level { get; set; }

        [DeserializeAs(Name = "currentGold")]
        public int CurrentGold { get; set; }

        [DeserializeAs(Name = "minionsKilled")]
        public int MinionsKilled { get; set; }

        [DeserializeAs(Name = "dominionScore")]
        public int DominionScore { get; set; }

        [DeserializeAs(Name = "position")]
        public MatchPositionDto Position { get; set; }

        [DeserializeAs(Name = "xp")]
        public int XP { get; set; }

        [DeserializeAs(Name = "jungleMinionsKilled")]
        public int JungleMinionsKilled { get; set; }
    }

    public class MatchPositionDto
    {
        [DeserializeAs(Name = "y")]
        public int Y { get; set; }

        [DeserializeAs(Name = "x")]
        public int X { get; set; }
    }

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
