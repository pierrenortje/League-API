using League.of.Legends.API.Models;
using RestSharp;
using System.Threading.Tasks;

namespace League.of.Legends.API
{
    public partial class LeagueService
    {
        /// <summary>
        /// Get mastery pages for a given summoner ID.
        /// </summary>
        /// <param name="summonerId">Summoner ID.</param>
        /// <returns>A <see cref="MasteryPagesData"/> object.</returns>
        public async Task<MasteryPagesData> SelectSummonerMasteryPages(string summonerId)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/status/v3/");

            var request = new RestRequest("shard-data", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await this.restClient.ExecuteTaskAsync<MasteryPagesData>(request);

            return response.Data;
        }
    }
}
