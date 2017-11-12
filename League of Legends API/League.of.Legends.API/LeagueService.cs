using League.of.Legends.API.Domain;
using RestSharp;
using System;

namespace League.of.Legends.API
{
    public partial class LeagueService
    {
        private readonly string apiKey;
        private readonly Region region;
        private RestClient restClient;

        private string baseUrl;

        public LeagueService(string apiKey, Region region)
        {
            this.apiKey = apiKey;
            this.region = region;
        }

        private string BaseUrl
        {
            get
            {
                return this.baseUrl = $"https://{this.region.ToString().ToLower()}.api.riotgames.com/lol";
            }
        }
    }
}
