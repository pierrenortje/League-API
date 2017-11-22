using League.API.Interfaces;
using League.API.Models;
using RestSharp;
using System.Threading.Tasks;

namespace League.API.Requests
{
    public class SummonerRequest : RequestBase, ISummonerRequest
    {
        public SummonerRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<SummonerDto> GetByAccountId(long accountId)
        {
            var request = new RestRequest($"summoner/v3/summoners/by-account/{accountId}", Method.GET);

            return await base.ExecuteGet<SummonerDto>(request);
        }

        public async Task<SummonerDto> GetBySummonerName(string summonerName)
        {
            var request = new RestRequest($"summoner/v3/summoners/by-name/{summonerName}", Method.GET);

            return await base.ExecuteGet<SummonerDto>(request);
        }

        public async Task<SummonerDto> GetBySummonerName(long summonerId)
        {
            var request = new RestRequest($"summoner/v3/summoners/{summonerId}", Method.GET);

            return await base.ExecuteGet<SummonerDto>(request);
        }
    }
}
