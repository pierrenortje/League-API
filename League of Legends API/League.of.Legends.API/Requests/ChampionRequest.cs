using League.of.Legends.API.Interfaces;
using League.of.Legends.API.Models;
using RestSharp;
using System.Threading.Tasks;

namespace League.of.Legends.API.Requests
{
    public class ChampionRequest : RequestBase, IChampionRequest
    {
        public ChampionRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<ChampionData> Select(bool? freeToPlay = null)
        {
            var request = new RestRequest("platform/v3/champions", Method.GET);
            request.AddHeader("X-Riot-Token", base.apiKey);

            if (freeToPlay.HasValue)
                request.AddParameter("freeToPlay", freeToPlay.Value.ToString().ToLower());

            var response = await base.restClient.ExecuteTaskAsync<ChampionData>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }

        public async Task<Champion> Get(int id)
        {
            var request = new RestRequest($"platform/v3/champions/{id}", Method.GET);
            request.AddHeader("X-Riot-Token", base.apiKey);

            var response = await base.restClient.ExecuteTaskAsync<Champion>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }
    }
}
