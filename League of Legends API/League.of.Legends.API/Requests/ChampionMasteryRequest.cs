using League.of.Legends.API.Interfaces;
using League.of.Legends.API.Models;
using RestSharp;
using System.Threading.Tasks;

namespace League.of.Legends.API.Requests
{
    public class ChampionMasteryRequest : RequestBase, IChampionMasteryRequest
    {
        public ChampionMasteryRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<ChampionMasteryDtoList> SelectBySummonerID(long summonerId)
        {
            var request = new RestRequest($"champion-mastery/v3/champion-masteries/by-summoner/{summonerId}", Method.GET);

            return await base.ExecuteGet<ChampionMasteryDtoList>(request);
        }

        public async Task<ChampionMasteryDto> GetBySummonerIDByChampionID(long summonerId, long championId)
        {
            var request = new RestRequest($"champion-mastery/v3/champion-masteries/by-summoner/{summonerId}/by-champion/{championId}", Method.GET);

            return await base.ExecuteGet<ChampionMasteryDto>(request);
        }

        public async Task<int> GetScoreBySummonerID(long summonerId)
        {
            var request = new RestRequest($"champion-mastery/v3/scores/by-summoner/{summonerId}", Method.GET);

            return await base.ExecuteGet<int>(request);
        }
    }
}
