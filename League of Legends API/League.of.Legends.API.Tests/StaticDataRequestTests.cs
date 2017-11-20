using League.of.Legends.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace League.of.Legends.API.Tests
{
    [TestClass]
    public class StaticDataRequestTests : TestBase
    {
        [TestMethod]
        public async Task Select_Champions_Detailed()
        {
            var tags = new ChampionListTags[] { ChampionListTags.format };

            var result = await API.StaticDataRequest.SelectChampionsDetails(Locale.en_US, null, tags, false);
        }
    }
}
