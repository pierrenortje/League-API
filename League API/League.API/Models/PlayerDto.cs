using RestSharp.Deserializers;

namespace League.API.Models
{
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
}
