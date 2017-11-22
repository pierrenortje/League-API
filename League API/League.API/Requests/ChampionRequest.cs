using League.API.Interfaces;
using League.API.Models;
using RestSharp;
using System.Threading.Tasks;

namespace League.API.Requests
{
    public class ChampionRequest : RequestBase, IChampionRequest
    {
        public ChampionRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<ChampionData> Select(bool? freeToPlay = null)
        {
            var request = new RestRequest("platform/v3/champions", Method.GET);

            if (freeToPlay.HasValue)
                request.AddParameter("freeToPlay", freeToPlay.Value.ToString().ToLower());

            return await base.ExecuteGet<ChampionData>(request);
        }

        public async Task<Champion> Get(int id)
        {
            var request = new RestRequest($"platform/v3/champions/{id}", Method.GET);

            return await base.ExecuteGet<Champion>(request);
        }
    }
}
