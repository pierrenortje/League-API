using League.of.Legends.API.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace League.of.Legends.API.Tests
{
    [TestClass]
    public class LeagueChampion
    {
        private const string apiKey = "RGAPI-d26891f6-9d2b-442e-b744-9d2c1e0945f0";
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
