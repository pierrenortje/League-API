using League.of.Legends.API.Domain;
using RestSharp;
using System.Threading.Tasks;

namespace League.of.Legends.API
{
    public partial class LeagueService
    {
        /// <summary>
        /// Retrieve all champions.
        /// </summary>
        /// <param name="freeToPlay">Optional filter param to retrieve only free to play champions.</param>
        /// <returns></returns>
        public async Task<ChampionRoot> SelectChampions(bool? freeToPlay = null)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/platform/v3/");

            var request = new RestRequest("champions", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (freeToPlay.HasValue)
                request.AddParameter("freeToPlay", freeToPlay.Value.ToString().ToLower());

            var response = await this.restClient.ExecuteTaskAsync<ChampionRoot>(request);

            return response.Data;
        }

        /// <summary>
        /// Retrieve champion by ID.
        /// </summary>
        /// <param name="id">Champion ID.</param>
        /// <returns></returns>
        public async Task<Champion> GetChampionByID(int id)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/platform/v3/");

            var request = new RestRequest($"champions/{id}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await this.restClient.ExecuteTaskAsync<Champion>(request);

            return response.Data;
        }
    }
}
