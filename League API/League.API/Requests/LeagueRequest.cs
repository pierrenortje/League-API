using League.API.Interfaces;
using League.API.Models;
using RestSharp;
using System.Threading.Tasks;

namespace League.API.Requests
{
    public class LeagueRequest : RequestBase, ILeagueRequest
    {
        public LeagueRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<LeagueListDto> SelectChallengerLeagueByQueue(QueueType queueType)
        {
            var request = new RestRequest($"league/v3/challengerleagues/by-queue/{queueType.ToString()}", Method.GET);

            return await base.ExecuteGet<LeagueListDto>(request);
        }

        public async Task<LeagueListDtoList> SelectSummonerLeagues(long summonerId)
        {
            var request = new RestRequest($"league/v3/leagues/by-summoner/{summonerId}", Method.GET);

            return await base.ExecuteGet<LeagueListDtoList>(request);
        }

        public async Task<LeagueListDto> Get(string leagueId)
        {
            var request = new RestRequest($"league/v3/leagues/{leagueId}", Method.GET);

            return await base.ExecuteGet<LeagueListDto>(request);
        }

        public async Task<LeagueListDto> SelectMasterLeagueByQueue(QueueType queueType)
        {
            var request = new RestRequest($"league/v3/masterleagues/by-queue/{queueType.ToString()}", Method.GET);

            return await base.ExecuteGet<LeagueListDto>(request);
        }

        public async Task<LeagueItemDto> SelectSummonerLeaguePositions(long summonerId)
        {
            var request = new RestRequest($"league/v3/positions/by-summoner/{summonerId}", Method.GET);

            return await base.ExecuteGet<LeagueItemDto>(request);
        }
    }
}
