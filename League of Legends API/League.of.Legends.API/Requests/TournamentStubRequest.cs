using League.of.Legends.API.Interfaces;
using League.of.Legends.API.Models;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace League.of.Legends.API.Requests
{
    public class TournamentStubRequest : RequestBase, ITournamentStubRequest
    {
        public TournamentStubRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<List<string>> SelectCodes(int tournamentId, TournamentCodeParameters model = null, int? count = null)
        {
            var request = new RestRequest("tournament-stub/v3/codes", Method.POST);

            request.AddParameter("tournamentId", tournamentId);

            if (model != null)
                request.AddJsonBody(model);

            if (count.HasValue)
                request.AddParameter("count", count.Value);

            return await base.ExecuteGet<List<string>>(request);
        }

        public async Task<LobbyEventDtoWrapper> SelectLobbyEvents(string tournamentCode)
        {
            var request = new RestRequest($"tournament-stub/v3/lobby-events/by-code/{tournamentCode}", Method.GET);

            return await base.ExecuteGet<LobbyEventDtoWrapper>(request);
        }

        public async Task<int> CreateProvider(ProviderRegistrationParameters model)
        {
            var request = new RestRequest("tournament-stub/v3/providers", Method.POST);
            request.AddJsonBody(model);

            return await base.ExecuteGet<int>(request);
        }

        public async Task<int> CreateTournament(TournamentRegistrationParameters model)
        {
            var request = new RestRequest("tournament-stub/v3/tournaments", Method.POST);
            request.AddJsonBody(model);

            return await base.ExecuteGet<int>(request);
        }
    }
}
