#region License
// Copyright (c) 2017 Pierre Nortje
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using League.API.Interfaces;
using League.API.Models;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace League.API.Requests
{
    public class MatchRequest : RequestBase, IMatchRequest
    {
        public MatchRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<MatchDto> Get(long matchId)
        {
            var request = new RestRequest($"match/v3/matches/{matchId}", Method.GET);

            return await base.ExecuteGet<MatchDto>(request);
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

            return await base.ExecuteGet<MatchlistDto>(request);
        }

        public async Task<MatchlistDto> SelectMatchListsRecent(long accountId)
        {
            var request = new RestRequest($"match/v3/matchlists/by-account/{accountId}/recent", Method.GET);

            return await base.ExecuteGet<MatchlistDto>(request);
        }

        public async Task<MatchTimelineDto> GetTimelineByMatchId(long matchId)
        {
            var request = new RestRequest($"match/v3/timelines/by-match/{matchId}", Method.GET);

            return await base.ExecuteGet<MatchTimelineDto>(request);
        }

        public async Task<List<long>> SelectMatchesByTournamentCode(long tournamentCode)
        {
            var request = new RestRequest($"match/v3/matches/by-tournament-code/{tournamentCode}/ids", Method.GET);

            return await base.ExecuteGet<List<long>>(request);
        }

        public async Task<MatchDto> GetByMatchIdTournamentCode(long matchId, long tournamentCode)
        {
            var request = new RestRequest($"match/v3/matches/{matchId}/by-tournament-code/{tournamentCode}", Method.GET);

            return await base.ExecuteGet<MatchDto>(request);
        }
    }
}
