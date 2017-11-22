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
using System.Threading.Tasks;

namespace League.API.Requests
{
    public class SummonerRequest : RequestBase, ISummonerRequest
    {
        public SummonerRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<SummonerDto> GetByAccountId(long accountId)
        {
            var request = new RestRequest($"summoner/v3/summoners/by-account/{accountId}", Method.GET);

            return await base.ExecuteGet<SummonerDto>(request);
        }

        public async Task<SummonerDto> GetBySummonerName(string summonerName)
        {
            var request = new RestRequest($"summoner/v3/summoners/by-name/{summonerName}", Method.GET);

            return await base.ExecuteGet<SummonerDto>(request);
        }

        public async Task<SummonerDto> GetBySummonerName(long summonerId)
        {
            var request = new RestRequest($"summoner/v3/summoners/{summonerId}", Method.GET);

            return await base.ExecuteGet<SummonerDto>(request);
        }
    }
}
