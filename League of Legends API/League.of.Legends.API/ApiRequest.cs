using League.of.Legends.API.Models;
using League.of.Legends.API.Requests;
using RestSharp;
using System;

namespace League.of.Legends.API
{
    public class ApiRequest
    {
        #region Private Fields
        private readonly IRestClient client;
        private readonly string apiKey;
        private readonly Region region;
        #endregion

        #region Constructor
        public ApiRequest(string apiKey, Region region)
        {
            this.apiKey = apiKey;
            this.region = region;

            this.client = new RestClient
            {
                BaseUrl = new Uri($"https://{this.region.ToString().ToLower()}.api.riotgames.com/lol")
            };
        }
        #endregion

        #region Public Properties
        public ChampionMasteryRequest ChampionMasteryRequest { get { return new ChampionMasteryRequest(this.client, this.apiKey, this.region); } }
        public ChampionRequest ChampionRequest { get { return new ChampionRequest(this.client, this.apiKey, this.region); } }
        public LeagueRequest LeagueRequest { get { return new LeagueRequest(this.client, this.apiKey, this.region); } }
        public MasteriesRequest MasteriesRequest { get { return new MasteriesRequest(this.client, this.apiKey, this.region); } }
        public MatchRequest MatchRequest { get { return new MatchRequest(this.client, this.apiKey, this.region); } }
        public StaticDataRequest StaticDataRequest { get { return new StaticDataRequest(this.client, this.apiKey, this.region); } }
        public StatusRequest StatusRequest { get { return new StatusRequest(this.client, this.apiKey, this.region); } }
        #endregion
    }
}
