using League.of.Legends.API.Interfaces;
using League.of.Legends.API.Models;
using RestSharp;
using System.Threading.Tasks;

namespace League.of.Legends.API.Requests
{
    public class LeagueRequest : RequestBase, ILeagueRequest
    {
        public LeagueRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<LeagueListDto> SelectChallengerLeagueByQueue(QueueType queueType)
        {
            var request = new RestRequest($"league/v3/challengerleagues/by-queue/{queueType.ToString()}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync<LeagueListDto>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }

        public async Task<LeagueListDtoList> SelectSummonerLeagues(long summonerId)
        {
            var request = new RestRequest($"league/v3/leagues/by-summoner/{summonerId}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync<LeagueListDtoList>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }

        public async Task<LeagueListDto> Get(string leagueId)
        {
            var request = new RestRequest($"league/v3/leagues/{leagueId}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync<LeagueListDto>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }

        public async Task<LeagueListDto> SelectMasterLeagueByQueue(QueueType queueType)
        {
            var request = new RestRequest($"league/v3/masterleagues/by-queue/{queueType.ToString()}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync<LeagueListDto>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }

        public async Task<LeagueItemDto> SelectSummonerLeaguePositions(long summonerId)
        {
            var request = new RestRequest($"league/v3/positions/by-summoner/{summonerId}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync<LeagueItemDto>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }
    }
}
