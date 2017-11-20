using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace League.of.Legends.API.Tests
{
    [TestClass]
    public class ChampionRequestTests : TestBase
    {
        [TestMethod]
        public async Task Select_Champions()
        {
            var result = await API.ChampionRequest.Select();
        }

        [TestMethod]
        public async Task Select_Free_To_Play_Champions()
        {
            var result = await API.ChampionRequest.Select(freeToPlay: true);
        }

        [TestMethod]
        public async Task Get_Champion_By_ID()
        {
            var result = await API.ChampionRequest.Get(championId);
        }
    }
}
