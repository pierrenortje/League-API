using League.of.Legends.API.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace League.of.Legends.API.Tests
{
    [TestClass]
    public class LeagueLeague
    {
        private const string apiKey = "RGAPI-d26891f6-9d2b-442e-b744-9d2c1e0945f0";
        private const Region region = Region.EUW1;

        private LeagueService leagueService = new LeagueService(apiKey, region);

        private const long summonerId = 85987189;
        private const string leagueId = "14bdc992-b1c9-3cd6-a301-d6e2e52dfe39";

        [TestMethod]
        public async Task Select_Challenger_League_By_Queue()
        {
            var result = await this.leagueService.SelectChallengerLeagueByQueue(QueueType.RANKED_SOLO_5x5);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task Select_Summoner_Leagues()
        {
            var result = await this.leagueService.SelectSummonerLeagues(summonerId);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task Get_League_By_ID()
        {
            var result = await this.leagueService.GetLeagueByID(leagueId);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task Select_Master_League_By_Queue()
        {
            var result = await this.leagueService.SelectMasterLeagueByQueue(QueueType.RANKED_SOLO_5x5);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task Select_Summoner_League_Positions()
        {
            var result = await this.leagueService.SelectSummonerLeaguePositions(summonerId);

            Assert.IsNotNull(result);
        }
    }
}
