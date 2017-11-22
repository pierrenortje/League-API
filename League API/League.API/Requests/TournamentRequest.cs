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
