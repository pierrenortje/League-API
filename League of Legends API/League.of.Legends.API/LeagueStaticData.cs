using League.of.Legends.API.Models;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace League.of.Legends.API
{
    public partial class LeagueService
    {
        /// <summary>
        /// Retrieves champion list.
        /// </summary>
        /// <param name="locale">
        /// Locale code for returned data (e.g., en_US, es_ES).
        /// If not specified, the default locale for the region is used.
        /// </param>
        /// <param name="version">
        /// Patch version for returned data. If not specified, the latest version for the region is used.
        /// List of valid versions can be obtained from the /versions endpoint.
        /// </param>
        /// <param name="tags">
        /// Tags to return additional data. Only type, version, data, id, key, name, and title are returned
        /// by default if this parameter isn't specified. To return all additional data, use the tag 'all'.
        /// </param>
        /// <param name="dataById">
        /// If specified as true, the returned data map will use the champions' IDs as the keys.
        /// If not specified or specified as false, the returned data map will use the champions' keys instead.
        /// </param>
        /// <returns>A <see cref="ChampionDetailsData"/> object.</returns>
        public async Task<ChampionDetailsData> SelectChampionsDetails(Locale? locale = null, string version = null, ChampionListTags[] tags = null, bool? dataById = null)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/static-data/v3/");

            var request = new RestRequest("champions", Method.GET);
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

            var response = await this.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ChampionDetailsData>(response.Content);

            return responseObj;
        }

        /// <summary>
        /// Retrieves champion by ID.
        /// </summary>
        /// <param name="id">Champion ID.</param>
        /// <param name="locale">
        /// Locale code for returned data (e.g., en_US, es_ES).
        /// If not specified, the default locale for the region is used.
        /// </param>
        /// <param name="version">
        /// Patch version for returned data. If not specified, the latest version for the region is used.
        /// List of valid versions can be obtained from the /versions endpoint.
        /// </param>
        /// <param name="tags">
        /// Tags to return additional data. Only id, key, name, and title are returned by default if this
        /// parameter isn't specified. To return all additional data, use the tag 'all'.
        /// </param>
        /// <returns>A <see cref="ChampionDetails"/> object.</returns>
        public async Task<ChampionDetails> GetChampionDetailsByID(int id, Locale? locale = null, string version = null, ChampionTags[] tags = null)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/static-data/v3/");

            var request = new RestRequest($"champions/{id}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            request.AddParameter("id", id);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            if (tags != null)
                foreach (var tag in tags)
                    request.AddParameter("tags", tag.ToString());

            var response = await this.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ChampionDetails>(response.Content);

            return responseObj;
        }

        /// <summary>
        /// Retrieves item list.
        /// </summary>
        /// <param name="locale">
        /// Locale code for returned data (e.g., en_US, es_ES).
        /// If not specified, the default locale for the region is used.
        /// </param>
        /// <param name="version">
        /// Patch version for returned data. If not specified, the latest version for the region is used.
        /// List of valid versions can be obtained from the /versions endpoint.
        /// </param>
        /// <param name="tags">
        /// Tags to return additional data. Only type, version, data, id, key, name, and title are returned
        /// by default if this parameter isn't specified. To return all additional data, use the tag 'all'.
        /// </param>
        /// <returns>A <see cref="ItemData"/> object.</returns>
        public async Task<ItemData> SelectItemsDetails(Locale? locale = null, string version = null, ItemTags[] tags = null)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/static-data/v3/");

            var request = new RestRequest("items", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            if (tags != null)
                foreach (var tag in tags)
                    request.AddParameter("tags", tag.ToString());

            var response = await this.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ItemData>(response.Content);

            return responseObj;
        }

        /// <summary>
        /// Retrieves item by ID.
        /// </summary>
        /// <param name="id">Item ID.</param>
        /// <param name="locale">
        /// Locale code for returned data (e.g., en_US, es_ES).
        /// If not specified, the default locale for the region is used.
        /// </param>
        /// <param name="version">
        /// Patch version for returned data. If not specified, the latest version for the region is used.
        /// List of valid versions can be obtained from the /versions endpoint.
        /// </param>
        /// <param name="tags">
        /// Tags to return additional data. Only type, version, data, id, key, name, and title are returned
        /// by default if this parameter isn't specified. To return all additional data, use the tag 'all'.
        /// </param>
        /// <returns>A <see cref="Item"/> object.</returns>
        public async Task<Item> GetItemDetailsByID(int id, Locale? locale = null, string version = null, ItemTags[] tags = null)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/static-data/v3/");

            var request = new RestRequest($"items/{id}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            if (tags != null)
                foreach (var tag in tags)
                    request.AddParameter("tags", tag.ToString());

            var response = await this.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Item>(response.Content);

            return responseObj;
        }

        /// <summary>
        /// Retrieve language strings data.
        /// </summary>
        /// <param name="locale">
        /// Locale code for returned data (e.g., en_US, es_ES).
        /// If not specified, the default locale for the region is used.
        /// </param>
        /// <param name="version">
        /// Patch version for returned data. If not specified, the latest version for the region is used.
        /// List of valid versions can be obtained from the /versions endpoint.
        /// </param>
        /// <returns>A <see cref="LanguageStringsData"/> object.</returns>
        public async Task<LanguageStringsData> GetLanguageStrings(Locale? locale = null, string version = null)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/static-data/v3/");

            var request = new RestRequest("language-strings", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            var response = await this.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<LanguageStringsData>(response.Content);

            return responseObj;
        }

        /// <summary>
        /// Retrieve supported languages data.
        /// </summary>
        /// <returns>A list of strings.</returns>
        public async Task<List<string>> SelectLanguages()
        {
            this.restClient = new RestClient($"{this.BaseUrl}/static-data/v3/");

            var request = new RestRequest("languages", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await this.restClient.ExecuteTaskAsync<List<string>>(request);

            return response.Data;
        }

        /// <summary>
        /// Retrieve map data.
        /// </summary>
        /// <param name="locale">
        /// Locale code for returned data (e.g., en_US, es_ES).
        /// If not specified, the default locale for the region is used.
        /// </param>
        /// <param name="version">
        /// Patch version for returned data. If not specified, the latest version for the region is used.
        /// List of valid versions can be obtained from the /versions endpoint.
        /// </param>
        /// <returns>A <see cref="MapData"/> object.</returns>
        public async Task<MapData> SelectMaps(Locale? locale = null, string version = null)
        {
            // Note:
            // This endpoint is only supported for patch version 5.5.3 and later.
            // Also, map data was not generated for patch versions 5.15.1, 5.16.1, and 5.17.1.

            this.restClient = new RestClient($"{this.BaseUrl}/static-data/v3/");

            var request = new RestRequest("language-strings", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            var response = await this.restClient.ExecuteTaskAsync<MapData>(request);

            return response.Data;
        }

        /// <summary>
        /// Retrieves mastery list.
        /// </summary>
        /// <param name="locale">
        /// Locale code for returned data (e.g., en_US, es_ES).
        /// If not specified, the default locale for the region is used.
        /// </param>
        /// <param name="version">
        /// Patch version for returned data. If not specified, the latest version for the region is used.
        /// List of valid versions can be obtained from the /versions endpoint.
        /// </param>
        /// <returns>A <see cref="MasteryData"/> object.</returns>
        public async Task<MasteryData> SelectMasteries(Locale? locale = null, string version = null)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/static-data/v3/");

            var request = new RestRequest("masteries", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            var response = await this.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<MasteryData>(response.Content);

            return responseObj;
        }

        /// <summary>
        /// Retrieves mastery item by ID.
        /// </summary>
        /// <param name="id">Mastery ID.</param>
        /// <param name="locale">
        /// Locale code for returned data (e.g., en_US, es_ES).
        /// If not specified, the default locale for the region is used.
        /// </param>
        /// <param name="version">
        /// Patch version for returned data. If not specified, the latest version for the region is used.
        /// List of valid versions can be obtained from the /versions endpoint.
        /// </param>
        /// <returns>A <see cref="Mastery"/> object.</returns>
        public async Task<Mastery> GetMasteryByID(int id, Locale? locale = null, string version = null)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/static-data/v3/");

            var request = new RestRequest($"masteries/{id}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            var response = await this.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Mastery>(response.Content);

            return responseObj;
        }

        /// <summary>
        /// Retrieve profile icons.
        /// </summary>
        /// <param name="locale">
        /// Locale code for returned data (e.g., en_US, es_ES).
        /// If not specified, the default locale for the region is used.
        /// </param>
        /// <param name="version">
        /// Patch version for returned data. If not specified, the latest version for the region is used.
        /// List of valid versions can be obtained from the /versions endpoint.
        /// </param>
        /// <returns>A <see cref="ProfileIconData"/> object.</returns>
        public async Task<ProfileIconData> SelectProfileIcons(Locale? locale = null, string version = null)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/static-data/v3/");

            var request = new RestRequest("profile-icons", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            var response = await this.restClient.ExecuteTaskAsync<ProfileIconData>(request);

            return response.Data;
        }

        /// <summary>
        /// Retrieve realm data.
        /// </summary>
        /// <returns>A <see cref="Realm"/> object.</returns>
        public async Task<Realm> GetRealm()
        {
            this.restClient = new RestClient($"{this.BaseUrl}/static-data/v3/");

            var request = new RestRequest("realms", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await this.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Realm>(response.Content);

            return responseObj;
        }

        /// <summary>
        /// Retrieves rune list.
        /// </summary>
        /// <returns>A <see cref="RuneData"/> object.</returns>
        public async Task<RuneData> SelectRunes()
        {
            this.restClient = new RestClient($"{this.BaseUrl}/static-data/v3/");

            var request = new RestRequest("runes", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await this.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<RuneData>(response.Content);

            return responseObj;
        }

        /// <summary>
        /// Retrieves rune by ID.
        /// </summary>
        /// <returns>A <see cref="Rune"/> object.</returns>
        public async Task<Rune> GetRuneByID(int id)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/static-data/v3/");

            var request = new RestRequest($"runes/{id}", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await this.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Rune>(response.Content);

            return responseObj;
        }

        /// <summary>
        /// Retrieves summoner spell list.
        /// </summary>
        /// <param name="locale">
        /// Locale code for returned data (e.g., en_US, es_ES).
        /// If not specified, the default locale for the region is used.
        /// </param>
        /// <param name="version">
        /// Patch version for returned data. If not specified, the latest version for the region is used.
        /// List of valid versions can be obtained from the /versions endpoint.
        /// </param>
        /// <param name="dataById">
        /// If specified as true, the returned data map will use the champions' IDs as the keys.
        /// If not specified or specified as false, the returned data map will use the champions' keys instead.
        /// </param>
        /// <param name="tags">
        /// Tags to return additional data. Only type, version, data, id, key, name, description, and
        /// summonerLevel are returned by default if this parameter isn't specified. To return all
        /// additional data, use the tag 'all'.
        /// </param>
        /// <returns>A <see cref="SummonerSpellData"/> object.</returns>
        public async Task<SummonerSpellData> SelectSummonerSpells(Locale? locale = null, string version = null, bool? dataById = null, SpellTags[] tags = null)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/static-data/v3/");

            var request = new RestRequest("summoner-spells", Method.GET);
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

            var response = await this.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<SummonerSpellData>(response.Content);

            return responseObj;
        }

        /// <summary>
        /// Retrieves summoner spell by ID.
        /// </summary>
        /// <param name="id">Summoner spell ID.</param>
        /// <param name="locale">
        /// Locale code for returned data (e.g., en_US, es_ES).
        /// If not specified, the default locale for the region is used.
        /// </param>
        /// <param name="version">
        /// Patch version for returned data. If not specified, the latest version for the region is used.
        /// List of valid versions can be obtained from the /versions endpoint.
        /// </param>
        /// <param name="dataById">
        /// If specified as true, the returned data map will use the champions' IDs as the keys.
        /// If not specified or specified as false, the returned data map will use the champions' keys instead.
        /// </param>
        /// <param name="tags">
        /// Tags to return additional data. Only type, version, data, id, key, name, description, and
        /// summonerLevel are returned by default if this parameter isn't specified. To return all
        /// additional data, use the tag 'all'.
        /// </param>
        /// <returns>A <see cref="SummonerSpell"/> object.</returns>
        public async Task<SummonerSpell> GetSummonerSpellByID(int id, Locale? locale = null, string version = null, bool? dataById = null, SpellTags[] tags = null)
        {
            this.restClient = new RestClient($"{this.BaseUrl}/static-data/v3/");

            var request = new RestRequest($"summoner-spells/{id}", Method.GET);
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

            var response = await this.restClient.ExecuteTaskAsync(request);
            var responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<SummonerSpell>(response.Content);

            return responseObj;
        }

        /// <summary>
        /// Retrieve version data.
        /// </summary>
        /// <returns>A list of strings.</returns>
        public async Task<List<string>> SelectVersions()
        {
            this.restClient = new RestClient($"{this.BaseUrl}/static-data/v3/");

            var request = new RestRequest("versions", Method.GET);
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await this.restClient.ExecuteTaskAsync<List<string>>(request);

            return response.Data;
        }
    }
}
