using League.of.Legends.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace League.of.Legends.API.Tests
{
    [TestClass]
    public class LeagueChampion
    {
        private const string apiKey = "RGAPI-9351952b-4d49-4676-a031-f30084e2dfb0";
        private const Region region = Region.EUW1;

        private LeagueService leagueService = new LeagueService(apiKey, region);

        private const int championId = 67;


        [TestMethod]
        public async Task Select_Champions()
        {
            var result = await this.leagueService.SelectChampions();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task Select_Free_To_Play_Champions()
        {
            var result = await this.leagueService.SelectChampions(freeToPlay: true);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task Get_Champion_By_ID()
        {
            var result = await this.leagueService.GetChampionByID(championId);

            Assert.IsNotNull(result);
        }
    }
}
