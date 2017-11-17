using League.of.Legends.API.Models;
using RestSharp;
using System.Threading.Tasks;

namespace League.of.Legends.API
{
    public partial class LeagueService
    {
        /// <summary>
        /// Get the challenger league for given queue.
        /// </summary>
        /// <returns></returns>
        public async Task<LeagueRoot> SelectChallengerLeagueByQueue(QueueType queueType)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/league/v3/");

            var request = new RestRequest($"challengerleagues/by-queue/{queueType.ToString()}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await this.restClient.ExecuteTaskAsync<LeagueRoot>(request);

            return response.Data;
        }

        /// <summary>
        /// Get leagues in all queues for a given summoner ID.
        /// </summary>
        /// <param name="summonerId">Summoner ID associated with the player.</param>
        /// <returns></returns>
        public async Task<LeagueRootList> SelectSummonerLeagues(long summonerId)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/league/v3/");

            var request = new RestRequest($"leagues/by-summoner/{summonerId}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await this.restClient.ExecuteTaskAsync<LeagueRootList>(request);

            return response.Data;
        }

        /// <summary>
        /// Get league with given ID, including inactive entries.
        /// </summary>
        /// <param name="leagueId">The UUID of the league.</param>
        /// <returns></returns>
        public async Task<LeagueRoot> GetLeagueByID(string leagueId)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/league/v3/");

            var request = new RestRequest($"leagues/{leagueId}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await this.restClient.ExecuteTaskAsync<LeagueRoot>(request);

            return response.Data;
        }

        /// <summary>
        /// Get the master league for given queue.
        /// </summary>
        /// <returns></returns>
        public async Task<LeagueRoot> SelectMasterLeagueByQueue(QueueType queueType)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/league/v3/");

            var request = new RestRequest($"masterleagues/by-queue/{queueType.ToString()}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await this.restClient.ExecuteTaskAsync<LeagueRoot>(request);

            return response.Data;
        }

        /// <summary>
        /// Get league positions in all queues for given summoner ID.
        /// </summary>
        /// <param name="summonerId">Summoner ID associated with the player.</param>
        /// <returns></returns>
        public async Task<Leagues> SelectSummonerLeaguePositions(long summonerId)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/league/v3/");

            var request = new RestRequest($"positions/by-summoner/{summonerId}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await this.restClient.ExecuteTaskAsync<Leagues>(request);

            return response.Data;
        }
    }
}
