using League.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace League.API.Tests
{
    [TestClass]
    public class TestBase
    {
        #region Private Fields
        private ApiRequest api;

        private const string apikey = "RGAPI-9351952b-4d49-4676-a031-f30084e2dfb0";
        private const Region region = Region.EUW1;
        #endregion

        #region Protected Fields
        protected const long summonerId = 37000721;
        protected const int championId = 67;
        protected const string leagueId = "14bdc992-b1c9-3cd6-a301-d6e2e52dfe39";
        #endregion

        #region Public Properties
        public ApiRequest API
        {
            get
            {
                return this.api;
            }
        }
        #endregion

        #region Public Methods
        [TestInitialize]
        public void Init()
        {
            this.api = new ApiRequest(apikey, region);
        }
        #endregion
    }
}
