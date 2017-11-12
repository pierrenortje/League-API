using League.of.Legends.API.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;


namespace League.of.Legends.API.Tests
{
    [TestClass]
    public class LeagueStaticData
    {
        private const string apiKey = "RGAPI-9351952b-4d49-4676-a031-f30084e2dfb0";
        private const Region region = Region.EUW1;

        private LeagueService leagueService = new LeagueService(apiKey, region);

        [TestMethod]
        public async Task Select_Champions_Detailed()
        {
            var tags = new ChampionListTags[] { ChampionListTags.format };

            var result = await this.leagueService.SelectChampionsDetails(Locale.en_US, null, tags, false);

            Assert.IsNotNull(result);
        }
    }
}
