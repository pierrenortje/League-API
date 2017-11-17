using League.of.Legends.API.Domain;
using RestSharp;
using System.Threading.Tasks;

namespace League.of.Legends.API
{
    public partial class LeagueService
    {
        public async Task<ShardStatus> SelectShardData()
        {
            this.restClient = new RestClient($"{this.BaseUrl}/status/v3/");

            var request = new RestRequest("shard-data", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await this.restClient.ExecuteTaskAsync<ShardStatus>(request);

            return response.Data;
        }
    }
}
