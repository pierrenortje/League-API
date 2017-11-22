using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace League.API.Tests
{
    [TestClass]
    public class ChampionMasteryRequestTests : TestBase
    {
        [TestMethod]
        public async Task Select_Champion_Masteries_By_Summoner_ID()
        {
            var result = await API.ChampionMasteryRequest.SelectBySummonerID(summonerId);
        }

        [TestMethod]
        public async Task Get_Champion_Masteries_By_Summoner_ID_By_Champion_ID()
        {
            var result = await API.ChampionMasteryRequest.GetBySummonerIDByChampionID(summonerId, championId);
        }

        [TestMethod]
        public async Task Get_Champion_Mastery_Score_By_Summoner_ID()
        {
            var result = await API.ChampionMasteryRequest.GetScoreBySummonerID(summonerId);
        }
    }
}
