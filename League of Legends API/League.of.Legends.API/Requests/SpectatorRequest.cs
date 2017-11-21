using League.of.Legends.API.Interfaces;
using League.of.Legends.API.Models;
using RestSharp;
using System.Threading.Tasks;

namespace League.of.Legends.API.Requests
{
    public class SpectatorRequest : RequestBase, ISpectatorRequest
    {
        public SpectatorRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<CurrentGameInfo> SelectActiveGamesBySummonerId(long summonerId)
        {
            var request = new RestRequest($"spectator/v3/active-games/by-summoner/{summonerId}", Method.GET);

            return await base.ExecuteGet<CurrentGameInfo>(request);
        }

        public async Task<FeaturedGames> SelectFeaturedGames()
        {
            var request = new RestRequest("spectator/v3/featured-games", Method.GET);

            return await base.ExecuteGet<FeaturedGames>(request);
        }
    }
}
