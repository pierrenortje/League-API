using League.of.Legends.API.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace League.of.Legends.API.Tests
{
    [TestClass]
    public class LeagueChampionMastery
    {
        private const string apiKey = "RGAPI-9351952b-4d49-4676-a031-f30084e2dfb0";
        private const Region region = Region.EUW1;

        private LeagueService leagueService = new LeagueService(apiKey, region);

        private const long summonerId = 37000721;
        private const long championId = 67;

        [TestMethod]
        public async Task Select_Champion_Masteries_By_Summoner_ID()
        {
            var result = await this.leagueService.SelectChampionMasteriesBySummonerID(summonerId);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task Get_Champion_Masteries_By_Summoner_ID_By_Champion_ID()
        {
            var result = await this.leagueService.GetChampionMasteryBySummonerIDByChampionID(summonerId, championId);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task Get_Champion_Mastery_Score_By_Summoner_ID()
        {
            var result = await this.leagueService.GetChampionMasteryScoreBySummonerID(summonerId);

            Assert.IsTrue(result >= 0);
        }
    }
}
