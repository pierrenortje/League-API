using League.of.Legends.API.Interfaces;
using League.of.Legends.API.Models;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace League.of.Legends.API.Requests
{
    public class MatchRequest : RequestBase, IMatchRequest
    {
        public MatchRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<MatchDto> Get(long matchId)
        {
            var request = new RestRequest($"match/v3/matches/{matchId}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync<MatchDto>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }

        public async Task<MatchlistDto> SelectMatchLists(long accountId)
        {
            /*
                A number of optional parameters are provided for filtering. It is up to the caller to ensure that the combination of filter parameters provided is
                valid for the requested account, otherwise, no matches may be returned. If beginIndex is specified, but not endIndex, then endIndex defaults to
                beginIndex+100. If endIndex is specified, but not beginIndex, then beginIndex defaults to 0. If both are specified, then endIndex must be greater
                than beginIndex. The maximum range allowed is 100, otherwise a 400 error code is returned. If beginTime is specified, but not endTime, then these
                parameters are ignored. If endTime is specified, but not beginTime, then beginTime defaults to the start of the account's match history. If both
                are specified, then endTime should be greater than beginTime. The maximum time range allowed is one week, otherwise a 400 error code is returned.
             */

            var request = new RestRequest($"match/v3/matchlists/by-account/{accountId}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync<MatchlistDto>(request);

            return response.Data;
        }

        public async Task<MatchlistDto> SelectMatchListsRecent(long accountId)
        {
            var request = new RestRequest($"match/v3/matchlists/by-account/{accountId}/recent", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync<MatchlistDto>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }

        public async Task<MatchTimelineDto> GetTimelineByMatchId(long matchId)
        {
            var request = new RestRequest($"match/v3/timelines/by-match/{matchId}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync<MatchTimelineDto>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }

        public async Task<List<long>> SelectMatchesByTournamentCode(long tournamentCode)
        {
            var request = new RestRequest($"match/v3/matches/by-tournament-code/{tournamentCode}/ids", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync<List<long>>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }

        public async Task<MatchDto> GetByMatchIdTournamentCode(long matchId, long tournamentCode)
        {
            var request = new RestRequest($"match/v3/matches/{matchId}/by-tournament-code/{tournamentCode}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync<MatchDto>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }
    }
}
