using League.API.Interfaces;
using League.API.Models;
using RestSharp;
using System.Threading.Tasks;

namespace League.API.Requests
{
    public class RunesRequest : RequestBase, IRunesRequest
    {
        public RunesRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<RunePagesDto> SelectBySummonerId(string summonerId)
        {
            var request = new RestRequest($"platform/v3/runes/by-summoner/{summonerId}", Method.GET);

            return await base.ExecuteGet<RunePagesDto>(request);
        }
    }
}
