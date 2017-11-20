using League.of.Legends.API.Interfaces;
using League.of.Legends.API.Models;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace League.of.Legends.API.Requests
{
    public class StaticDataRequest : RequestBase, IStaticDataRequest
    {
        public StaticDataRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public async Task<ChampionListDto> SelectChampionsDetails(Locale? locale = null, string version = null, ChampionListTags[] tags = null, bool? dataById = null)
        {
            var request = new RestRequest("static-data/v3/champions", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            if (tags != null)
                foreach (var tag in tags)
                    request.AddParameter("tags", tag.ToString());

            if (dataById.HasValue)
                request.AddParameter("dataById", dataById.ToString().ToLower());

            var response = await base.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ChampionListDto>(response.Content);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return responseObj;
        }

        public async Task<ChampionDto> GetChampionDetailsByID(int id, Locale? locale = null, string version = null, ChampionTags[] tags = null)
        {
            var request = new RestRequest($"static-data/v3/champions/{id}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            request.AddParameter("id", id);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            if (tags != null)
                foreach (var tag in tags)
                    request.AddParameter("tags", tag.ToString());

            var response = await base.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ChampionDto>(response.Content);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return responseObj;
        }

        public async Task<ItemListDto> SelectItemsDetails(Locale? locale = null, string version = null, ItemTags[] tags = null)
        {
            var request = new RestRequest("static-data/v3/items", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            if (tags != null)
                foreach (var tag in tags)
                    request.AddParameter("tags", tag.ToString());

            var response = await base.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ItemListDto>(response.Content);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return responseObj;
        }

        public async Task<ItemDto> GetItemDetailsByID(int id, Locale? locale = null, string version = null, ItemTags[] tags = null)
        {
            var request = new RestRequest($"static-data/v3/items/{id}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            if (tags != null)
                foreach (var tag in tags)
                    request.AddParameter("tags", tag.ToString());

            var response = await base.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ItemDto>(response.Content);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return responseObj;
        }

        public async Task<LanguageStringsDto> GetLanguageStrings(Locale? locale = null, string version = null)
        {
            var request = new RestRequest("static-data/v3/language-strings", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            var response = await base.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<LanguageStringsDto>(response.Content);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return responseObj;
        }

        public async Task<List<string>> SelectLanguages()
        {
            var request = new RestRequest("static-data/v3/languages", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync<List<string>>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }

        public async Task<MapDataDto> SelectMaps(Locale? locale = null, string version = null)
        {
            // Note:
            // This endpoint is only supported for patch version 5.5.3 and later.
            // Also, map data was not generated for patch versions 5.15.1, 5.16.1, and 5.17.1.

            var request = new RestRequest("static-data/v3/language-strings", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            var response = await base.restClient.ExecuteTaskAsync<MapDataDto>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }

        public async Task<MasteryListDto> SelectMasteries(Locale? locale = null, string version = null)
        {
            var request = new RestRequest("static-data/v3/masteries", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            var response = await base.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<MasteryListDto>(response.Content);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return responseObj;
        }

        public async Task<MasteryDto> GetMasteryByID(int id, Locale? locale = null, string version = null)
        {
            var request = new RestRequest($"static-data/v3/masteries/{id}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            var response = await base.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<MasteryDto>(response.Content);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return responseObj;
        }

        public async Task<ProfileIconDataDto> SelectProfileIcons(Locale? locale = null, string version = null)
        {
            var request = new RestRequest("static-data/v3/profile-icons", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            var response = await base.restClient.ExecuteTaskAsync<ProfileIconDataDto>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }

        public async Task<Realm> GetRealm()
        {
            var request = new RestRequest("static-data/v3/realms", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Realm>(response.Content);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return responseObj;
        }

        public async Task<RuneListDto> SelectRunes()
        {
            var request = new RestRequest("static-data/v3/runes", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<RuneListDto>(response.Content);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return responseObj;
        }

        public async Task<RuneDto> GetRuneByID(int id)
        {
            var request = new RestRequest($"static-data/v3/runes/{id}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<RuneDto>(response.Content);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return responseObj;
        }

        public async Task<SummonerSpellListDto> SelectSummonerSpells(Locale? locale = null, string version = null, bool? dataById = null, SpellTags[] tags = null)
        {
            var request = new RestRequest("static-data/v3/summoner-spells", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            if (dataById.HasValue)
                request.AddParameter("dataById", dataById.ToString().ToLower());

            if (tags != null)
                foreach (var tag in tags)
                    request.AddParameter("tags", tag.ToString());

            var response = await base.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<SummonerSpellListDto>(response.Content);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return responseObj;
        }

        public async Task<SummonerSpellDto> GetSummonerSpellByID(int id, Locale? locale = null, string version = null, bool? dataById = null, SpellTags[] tags = null)
        {
            var request = new RestRequest($"static-data/v3/summoner-spells/{id}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            if (dataById.HasValue)
                request.AddParameter("dataById", dataById.ToString().ToLower());

            if (tags != null)
                foreach (var tag in tags)
                    request.AddParameter("tags", tag.ToString());

            var response = await base.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<SummonerSpellDto>(response.Content);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return responseObj;
        }

        public async Task<List<string>> SelectVersions()
        {
            var request = new RestRequest("static-data/v3/versions", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await base.restClient.ExecuteTaskAsync<List<string>>(request);

            base.StatusDescription = response.StatusDescription;
            base.StatusCode = response.StatusCode;

            return response.Data;
        }
    }
}
