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
        public ChampionMasteryRequest ChampionMasteryRequest { get { return new ChampionMasteryRequest(this.client, this.apiKey); } }
        public ChampionRequest ChampionRequest { get { return new ChampionRequest(this.client, this.apiKey); } }
        public LeagueRequest LeagueRequest { get { return new LeagueRequest(this.client, this.apiKey); } }
        public MasteriesRequest MasteriesRequest { get { return new MasteriesRequest(this.client, this.apiKey); } }
        public MatchRequest MatchRequest { get { return new MatchRequest(this.client, this.apiKey); } }
        public StaticDataRequest StaticDataRequest { get { return new StaticDataRequest(this.client, this.apiKey); } }
        public StatusRequest StatusRequest { get { return new StatusRequest(this.client, this.apiKey); } }
        public RunesRequest RunesRequest { get { return new RunesRequest(this.client, this.apiKey); } }
        public SpectatorRequest SpectatorRequest { get { return new SpectatorRequest(this.client, this.apiKey); } }
        public SummonerRequest SummonerRequest { get { return new SummonerRequest(this.client, this.apiKey); } }
        public TournamentStubRequest TournamentStubRequest { get { return new TournamentStubRequest(this.client, this.apiKey); } }
        public TournamentRequest TournamentRequest { get { return new TournamentRequest(this.client, this.apiKey); } }
        #endregion
    }
}
