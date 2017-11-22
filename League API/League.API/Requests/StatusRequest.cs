using League.API.Interfaces;
using League.API.Models;
using RestSharp;
using System.Threading.Tasks;

namespace League.API.Requests
{
    public class StatusRequest : RequestBase, IStatusRequest
    {
        public StatusRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<ShardStatus> SelectShardData()
        {
            var request = new RestRequest("status/v3/shard-data", Method.GET);

            return await base.ExecuteGet<ShardStatus>(request);
        }
    }
}
