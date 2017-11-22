using League.API.Interfaces;
using League.API.Models;
using RestSharp;
using System.Threading.Tasks;

namespace League.API.Requests
{
    public class MasteriesRequest : RequestBase, IMasteriesRequest
    {
        public MasteriesRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<MasteryPagesDto> SelectSummonerMasteryPages(string summonerId)
        {
            var request = new RestRequest($"platform/v3/masteries/by-summoner/{summonerId}", Method.GET);

            return await base.ExecuteGet<MasteryPagesDto>(request);
        }
    }
}
