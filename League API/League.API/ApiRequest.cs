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

using League.API.Models;
using League.API.Requests;
using RestSharp;
using System;

namespace League.API
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
