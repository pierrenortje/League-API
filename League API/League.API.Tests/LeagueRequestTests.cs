using League.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace League.API.Tests
{
    [TestClass]
    public class LeagueRequestTests : TestBase
    {
        [TestMethod]
        public async Task Select_Challenger_League_By_Queue()
        {
            var result = await API.LeagueRequest.SelectChallengerLeagueByQueue(QueueType.RANKED_SOLO_5x5);
        }

        [TestMethod]
        public async Task Select_Summoner_Leagues()
        {
            var result = await API.LeagueRequest.SelectSummonerLeagues(summonerId);
        }

        [TestMethod]
        public async Task Get_League_By_ID()
        {
            var result = await API.LeagueRequest.Get(leagueId);
        }

        [TestMethod]
        public async Task Select_Master_League_By_Queue()
        {
            var result = await API.LeagueRequest.SelectMasterLeagueByQueue(QueueType.RANKED_SOLO_5x5);
        }

        [TestMethod]
        public async Task Select_Summoner_League_Positions()
        {
            var result = await API.LeagueRequest.SelectSummonerLeaguePositions(summonerId);
        }
    }
}
