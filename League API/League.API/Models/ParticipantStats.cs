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

namespace League.API.Models
{
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
}
