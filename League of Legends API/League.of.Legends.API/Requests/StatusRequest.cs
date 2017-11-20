using League.of.Legends.API.Interfaces;
using League.of.Legends.API.Models;
using RestSharp;
using System.Threading.Tasks;

namespace League.of.Legends.API.Requests
{
    public class StatusRequest : RequestBase, IStatusRequest
    {
        public StatusRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<ShardStatus> SelectShardData()
        {
            var request = new RestRequest("status/v3/shard-data", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync<ShardStatus>(request);

            return response.Data;
        }
    }
}
