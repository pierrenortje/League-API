using League.of.Legends.API.Interfaces;
using League.of.Legends.API.Models;
using RestSharp;
using System.Threading.Tasks;

namespace League.of.Legends.API.Requests
{
    public class MasteriesRequest : RequestBase, IMasteriesRequest
    {
        public MasteriesRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<MasteryPagesDto> SelectSummonerMasteryPages(string summonerId)
        {
            var request = new RestRequest($"platform/v3/masteries/by-summoner/{summonerId}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync<MasteryPagesDto>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }
    }
}
