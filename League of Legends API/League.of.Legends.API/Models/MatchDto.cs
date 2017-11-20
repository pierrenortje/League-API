using RestSharp.Deserializers;
using System.Collections.Generic;

namespace League.of.Legends.API.Models
{
    public class MatchDto
    {
        [DeserializeAs(Name = "seasonId")]
        public int SeasonId { get; set; }

        [DeserializeAs(Name = "queueId")]
        public int QueueId { get; set; }

        [DeserializeAs(Name = "gameId")]
        public long GameId { get; set; }

        [DeserializeAs(Name = "participantIdentities")]
        public ParticipantIdentityDtoList ParticipantIdentities { get; set; }

        [DeserializeAs(Name = "gameVersion")]
        public string GameVersion { get; set; }

        [DeserializeAs(Name = "platformId")]
        public string PlatformId { get; set; }

        [DeserializeAs(Name = "gameMode")]
        public string GameMode { get; set; }

        [DeserializeAs(Name = "mapId")]
        public int MapId { get; set; }

        [DeserializeAs(Name = "gameType")]
        public string GameType { get; set; }

        [DeserializeAs(Name = "teams")]
        public TeamStatsDtoList Teams { get; set; }

        [DeserializeAs(Name = "participants")]
        public ParticipantDtoList Participants { get; set; }

        [DeserializeAs(Name = "gameDuration")]
        public long GameDuration { get; set; }

        [DeserializeAs(Name = "gameCreation")]
        public long GameCreation { get; set; }
    }

    public class ParticipantIdentityDto
    {
        [DeserializeAs(Name = "player")]
        public PlayerDto Player { get; set; }

        [DeserializeAs(Name = "participantId")]
        public int ParticipantId { get; set; }
    }
    public class ParticipantIdentityDtoList : List<ParticipantIdentityDto> { }

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

    public class ParticipantDto
    {
        [DeserializeAs(Name = "stats")]
        public ParticipantStats Stats { get; set; }

        [DeserializeAs(Name = "participantId")]
        public int ParticipantId { get; set; }

        [DeserializeAs(Name = "runes")]
        public RuneItemList Runes { get; set; }

        [DeserializeAs(Name = "timeline")]
        public ParticipantTimelineDto Timeline { get; set; }

        [DeserializeAs(Name = "teamId")]
        public int TeamId { get; set; }

        [DeserializeAs(Name = "spell2Id")]
        public int Spell2Id { get; set; }

        [DeserializeAs(Name = "masteries")]
        public Masteries Masteries { get; set; }

        [DeserializeAs(Name = "highestAchievedSeasonTier")]
        public string HighestAchievedSeasonTier { get; set; }

        [DeserializeAs(Name = "spell1Id")]
        public int Spell1Id { get; set; }

        [DeserializeAs(Name = "championId")]
        public int ChampionId { get; set; }
    }
    public class ParticipantDtoList : List<ParticipantDto> { }

    public class PlayerDto
    {
        [DeserializeAs(Name = "currentPlatformId")]
        public string CurrentPlatformId { get; set; }

        [DeserializeAs(Name = "summonerName")]
        public string SummonerName { get; set; }

        [DeserializeAs(Name = "matchHistoryUri")]
        public string MatchHistoryUri { get; set; }

        [DeserializeAs(Name = "platformId")]
        public string PlatformId { get; set; }

        [DeserializeAs(Name = "currentAccountId")]
        public long CurrentAccountId { get; set; }

        [DeserializeAs(Name = "profileIcon")]
        public int ProfileIcon { get; set; }

        [DeserializeAs(Name = "summonerId")]
        public long SummonerId { get; set; }

        [DeserializeAs(Name = "accountId")]
        public long AccountId { get; set; }
    }

    public class TeamBans
    {
        [DeserializeAs(Name = "pickTurn")]
        public int PickTurn { get; set; }

        [DeserializeAs(Name = "championId")]
        public int ChampionId { get; set; }
    }
    public class TeamBansList : List<TeamBans> { }

    public class ParticipantStats
    {
        [DeserializeAs(Name = "physicalDamageDealt")]
        public long PhysicalDamageDealt { get; set; }

        [DeserializeAs(Name = "neutralMinionsKilledTeamJungle")]
        public int NeutralMinionsKilledTeamJungle { get; set; }

        [DeserializeAs(Name = "magicDamageDealt")]
        public long MagicDamageDealt { get; set; }

        [DeserializeAs(Name = "totalPlayerScore")]
        public int TotalPlayerScore { get; set; }

        [DeserializeAs(Name = "deaths")]
        public int Deaths { get; set; }

        [DeserializeAs(Name = "win")]
        public bool Win { get; set; }

        [DeserializeAs(Name = "neutralMinionsKilledEnemyJungle")]
        public int NeutralMinionsKilledEnemyJungle { get; set; }

        [DeserializeAs(Name = "altarsCaptured")]
        public int AltarsCaptured { get; set; }

        [DeserializeAs(Name = "largestCriticalStrike")]
        public int LargestCriticalStrike { get; set; }

        [DeserializeAs(Name = "totalDamageDealt")]
        public long TotalDamageDealt { get; set; }

        [DeserializeAs(Name = "magicDamageDealtToChampions")]
        public long MagicDamageDealtToChampions { get; set; }

        [DeserializeAs(Name = "visionWardsBoughtInGame")]
        public int VisionWardsBoughtInGame { get; set; }

        [DeserializeAs(Name = "damageDealtToObjectives")]
        public long DamageDealtToObjectives { get; set; }

        [DeserializeAs(Name = "largestKillingSpree")]
        public int LargestKillingSpree { get; set; }

        [DeserializeAs(Name = "item1")]
        public int Item1 { get; set; }

        [DeserializeAs(Name = "quadraKills")]
        public int QuadraKills { get; set; }

        [DeserializeAs(Name = "teamObjective")]
        public int TeamObjective { get; set; }

        [DeserializeAs(Name = "totalTimeCrowdControlDealt")]
        public int TotalTimeCrowdControlDealt { get; set; }

        [DeserializeAs(Name = "longestTimeSpentLiving")]
        public int LongestTimeSpentLiving { get; set; }

        [DeserializeAs(Name = "wardsKilled")]
        public int WardsKilled { get; set; }

        [DeserializeAs(Name = "firstTowerAssist	")]
        public bool FirstTowerAssist { get; set; }

        [DeserializeAs(Name = "firstTowerKill")]
        public bool FirstTowerKill { get; set; }

        [DeserializeAs(Name = "item2")]
        public int Item2 { get; set; }

        [DeserializeAs(Name = "item3")]
        public int Item3 { get; set; }

        [DeserializeAs(Name = "item0")]
        public int Item0 { get; set; }

        [DeserializeAs(Name = "firstBloodAssist	")]
        public bool FirstBloodAssist { get; set; }

        [DeserializeAs(Name = "visionScore")]
        public long VisionScore { get; set; }

        [DeserializeAs(Name = "wardsPlaced")]
        public int WardsPlaced { get; set; }

        [DeserializeAs(Name = "item4")]
        public int Item4 { get; set; }

        [DeserializeAs(Name = "item5")]
        public int Item5 { get; set; }

        [DeserializeAs(Name = "item6")]
        public int Item6 { get; set; }

        [DeserializeAs(Name = "turretKills")]
        public int TurretKills { get; set; }

        [DeserializeAs(Name = "tripleKills")]
        public int TripleKills { get; set; }

        [DeserializeAs(Name = "damageSelfMitigated")]
        public long DamageSelfMitigated { get; set; }

        [DeserializeAs(Name = "champLevel")]
        public int ChampLevel { get; set; }

        [DeserializeAs(Name = "nodeNeutralizeAssist")]
        public int NodeNeutralizeAssist { get; set; }

        [DeserializeAs(Name = "firstInhibitorKill")]
        public bool FirstInhibitorKill { get; set; }

        [DeserializeAs(Name = "goldEarned")]
        public int GoldEarned { get; set; }

        [DeserializeAs(Name = "magicalDamageTaken")]
        public long MagicalDamageTaken { get; set; }

        [DeserializeAs(Name = "kills")]
        public int Kills { get; set; }

        [DeserializeAs(Name = "doubleKills")]
        public int DoubleKills { get; set; }

        [DeserializeAs(Name = "nodeCaptureAssist")]
        public int NodeCaptureAssist { get; set; }

        [DeserializeAs(Name = "trueDamageTaken")]
        public long TrueDamageTaken { get; set; }

        [DeserializeAs(Name = "nodeNeutralize")]
        public int NodeNeutralize { get; set; }

        [DeserializeAs(Name = "firstInhibitorAssist")]
        public bool FirstInhibitorAssist { get; set; }

        [DeserializeAs(Name = "assists")]
        public int Assists { get; set; }

        [DeserializeAs(Name = "unrealKills")]
        public int UnrealKills { get; set; }

        [DeserializeAs(Name = "neutralMinionsKilled")]
        public int NeutralMinionsKilled { get; set; }

        [DeserializeAs(Name = "objectivePlayerScore")]
        public int ObjectivePlayerScore { get; set; }

        [DeserializeAs(Name = "combatPlayerScore")]
        public int CombatPlayerScore { get; set; }

        [DeserializeAs(Name = "damageDealtToTurrets")]
        public long DamageDealtToTurrets { get; set; }

        [DeserializeAs(Name = "altarsNeutralized")]
        public int AltarsNeutralized { get; set; }

        [DeserializeAs(Name = "physicalDamageDealtToChampions")]
        public long PhysicalDamageDealtToChampions { get; set; }

        [DeserializeAs(Name = "goldSpent")]
        public int GoldSpent { get; set; }

        [DeserializeAs(Name = "trueDamageDealt")]
        public long TrueDamageDealt { get; set; }

        [DeserializeAs(Name = "trueDamageDealtToChampions")]
        public long TrueDamageDealtToChampions { get; set; }

        [DeserializeAs(Name = "participantId")]
        public int ParticipantId { get; set; }

        [DeserializeAs(Name = "pentaKills")]
        public int PentaKills { get; set; }

        [DeserializeAs(Name = "totalHeal")]
        public long TotalHeal { get; set; }

        [DeserializeAs(Name = "totalMinionsKilled")]
        public int TotalMinionsKilled { get; set; }

        [DeserializeAs(Name = "firstBloodKill")]
        public bool FirstBloodKill { get; set; }

        [DeserializeAs(Name = "nodeCapture")]
        public int NodeCapture { get; set; }

        [DeserializeAs(Name = "largestMultiKill")]
        public int LargestMultiKill { get; set; }

        [DeserializeAs(Name = "sightWardsBoughtInGame")]
        public int SightWardsBoughtInGame { get; set; }

        [DeserializeAs(Name = "totalDamageDealtToChampions")]
        public long TotalDamageDealtToChampions { get; set; }

        [DeserializeAs(Name = "totalUnitsHealed")]
        public int TotalUnitsHealed { get; set; }

        [DeserializeAs(Name = "inhibitorKills")]
        public int InhibitorKills { get; set; }

        [DeserializeAs(Name = "totalScoreRank")]
        public int TotalScoreRank { get; set; }

        [DeserializeAs(Name = "totalDamageTaken")]
        public long TotalDamageTaken { get; set; }

        [DeserializeAs(Name = "killingSprees")]
        public int KillingSprees { get; set; }

        [DeserializeAs(Name = "timeCCingOthers")]
        public long TimeCCingOthers { get; set; }

        [DeserializeAs(Name = "physicalDamageTaken")]
        public long PhysicalDamageTaken { get; set; }
    }

    public class RuneItem
    {
        [DeserializeAs(Name = "runeId")]
        public int RuneId { get; set; }

        [DeserializeAs(Name = "rank")]
        public int Rank { get; set; }
    }
    public class RuneItemList : List<RuneItem> { }

    public class ParticipantTimelineDto
    {
        [DeserializeAs(Name = "lane")]
        public string Lane { get; set; }

        [DeserializeAs(Name = "participantId")]
        public int ParticipantId { get; set; }

        [DeserializeAs(Name = "csDiffPerMinDeltas")]
        public Dictionary<string, double> CsDiffPerMinDeltas { get; set; }

        [DeserializeAs(Name = "goldPerMinDeltas")]
        public Dictionary<string, double> GoldPerMinDeltas { get; set; }

        [DeserializeAs(Name = "xpDiffPerMinDeltas")]
        public Dictionary<string, double> XpDiffPerMinDeltas { get; set; }

        [DeserializeAs(Name = "creepsPerMinDeltas")]
        public Dictionary<string, double> CreepsPerMinDeltas { get; set; }

        [DeserializeAs(Name = "xpPerMinDeltas")]
        public Dictionary<string, double> XpPerMinDeltas { get; set; }

        [DeserializeAs(Name = "role")]
        public string Role { get; set; }

        [DeserializeAs(Name = "damageTakenDiffPerMinDeltas")]
        public Dictionary<string, double> DamageTakenDiffPerMinDeltas { get; set; }

        [DeserializeAs(Name = "damageTakenPerMinDeltas")]
        public Dictionary<string, double> DamageTakenPerMinDeltas { get; set; }
    }
}
