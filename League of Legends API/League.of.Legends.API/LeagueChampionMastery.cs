using League.of.Legends.API.Domain;
using RestSharp;
using System.Threading.Tasks;

namespace League.of.Legends.API
{
    public partial class LeagueService
    {
        /// <summary>
        /// Get all champion mastery entries sorted by number of champion points descending.
        /// </summary>
        /// <param name="summonerId">Summoner ID associated with the player.</param>
        /// <returns></returns>
        public async Task<ChampionMasteries> SelectChampionMasteriesBySummonerID(long summonerId)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/champion-mastery/v3/");

            var request = new RestRequest($"champion-masteries/by-summoner/{summonerId}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await this.restClient.ExecuteTaskAsync<ChampionMasteries>(request);

            return response.Data;
        }

        /// <summary>
        /// Get a champion mastery by player ID and champion ID.
        /// </summary>
        /// <param name="summonerId">Summoner ID associated with the player.</param>
        /// <param name="championId">Champion ID to retrieve Champion Mastery for.</param>
        /// <returns></returns>
        public async Task<ChampionMastery> GetChampionMasteryBySummonerIDByChampionID(long summonerId, long championId)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/champion-mastery/v3/");

            var request = new RestRequest($"champion-masteries/by-summoner/{summonerId}/by-champion/{championId}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await this.restClient.ExecuteTaskAsync<ChampionMastery>(request);

            return response.Data;
        }

        /// <summary>
        /// Get a player's total champion mastery score, which is the sum of individual champion mastery levels.
        /// </summary>
        /// <param name="summonerId">Summoner ID associated with the player.</param>
        /// <returns></returns>
        public async Task<int> GetChampionMasteryScoreBySummonerID(long summonerId)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/champion-mastery/v3/");

            var request = new RestRequest($"scores/by-summoner/{summonerId}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await this.restClient.ExecuteTaskAsync<int>(request);

            return response.Data;
        }
    }
}
