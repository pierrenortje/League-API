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
    public class TournamentRequest : RequestBase, ITournamentRequest
    {
        public TournamentRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<List<string>> SelectCodes(int tournamentId, TournamentCodeParameters model = null, int? count = null)
        {
            var request = new RestRequest("tournament/v3/codes", Method.POST);

            request.AddParameter("tournamentId", tournamentId);

            if (model != null)
                request.AddJsonBody(model);

            if (count.HasValue)
                request.AddParameter("count", count.Value);

            return await base.ExecuteGet<List<string>>(request);
        }

        public void UpdateCode(string tournamentCode, TournamentCodeUpdateParameters model = null)
        {
            var request = new RestRequest($"tournament/v3/codes/{tournamentCode}", Method.PUT);

            base.restClient.ExecuteTaskAsync(request);
        }

        public async Task<TournamentCodeDto> GetCode(string tournamentCode)
        {
            var request = new RestRequest($"tournament/v3/codes/{tournamentCode}", Method.GET);

            return await base.ExecuteGet<TournamentCodeDto>(request);
        }

        public async Task<LobbyEventDtoWrapper> SelectLobbyEvents(string tournamentCode)
        {
            var request = new RestRequest($"tournament/v3/lobby-events/by-code/{tournamentCode}", Method.GET);

            return await base.ExecuteGet<LobbyEventDtoWrapper>(request);
        }

        public async Task<int> CreateProvider(ProviderRegistrationParameters model)
        {
            var request = new RestRequest("tournament/v3/providers", Method.POST);

            return await base.ExecuteGet<int>(request);
        }

        public async Task<int> CreateTournament(TournamentRegistrationParameters model)
        {
            var request = new RestRequest("tournament-stub/v3/tournaments", Method.POST);

            return await base.ExecuteGet<int>(request);
        }
    }
}
