﻿#region License
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
using System.Threading.Tasks;

namespace League.API.Requests
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
