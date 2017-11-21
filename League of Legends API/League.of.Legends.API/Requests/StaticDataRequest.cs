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

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            if (tags != null)
                foreach (var tag in tags)
                    request.AddParameter("tags", tag.ToString());

            if (dataById.HasValue)
                request.AddParameter("dataById", dataById.ToString().ToLower());

            return await base.ExecuteGet<ChampionListDto>(request, true);
        }

        public async Task<ChampionDto> GetChampionDetailsByID(int id, Locale? locale = null, string version = null, ChampionTags[] tags = null)
        {
            var request = new RestRequest($"static-data/v3/champions/{id}", Method.GET);

            request.AddParameter("id", id);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            if (tags != null)
                foreach (var tag in tags)
                    request.AddParameter("tags", tag.ToString());

            return await base.ExecuteGet<ChampionDto>(request, true);
        }

        public async Task<ItemListDto> SelectItemsDetails(Locale? locale = null, string version = null, ItemTags[] tags = null)
        {
            var request = new RestRequest("static-data/v3/items", Method.GET);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            if (tags != null)
                foreach (var tag in tags)
                    request.AddParameter("tags", tag.ToString());

            return await base.ExecuteGet<ItemListDto>(request, true);
        }

        public async Task<ItemDto> GetItemDetailsByID(int id, Locale? locale = null, string version = null, ItemTags[] tags = null)
        {
            var request = new RestRequest($"static-data/v3/items/{id}", Method.GET);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            if (tags != null)
                foreach (var tag in tags)
                    request.AddParameter("tags", tag.ToString());

            return await base.ExecuteGet<ItemDto>(request, true);
        }

        public async Task<LanguageStringsDto> GetLanguageStrings(Locale? locale = null, string version = null)
        {
            var request = new RestRequest("static-data/v3/language-strings", Method.GET);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            return await base.ExecuteGet<LanguageStringsDto>(request, true);
        }

        public async Task<List<string>> SelectLanguages()
        {
            var request = new RestRequest("static-data/v3/languages", Method.GET);

            return await base.ExecuteGet<List<string>>(request);
        }

        public async Task<MapDataDto> SelectMaps(Locale? locale = null, string version = null)
        {
            // Note:
            // This endpoint is only supported for patch version 5.5.3 and later.
            // Also, map data was not generated for patch versions 5.15.1, 5.16.1, and 5.17.1.

            var request = new RestRequest("static-data/v3/language-strings", Method.GET);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            return await base.ExecuteGet<MapDataDto>(request);
        }

        public async Task<MasteryListDto> SelectMasteries(Locale? locale = null, string version = null)
        {
            var request = new RestRequest("static-data/v3/masteries", Method.GET);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            return await base.ExecuteGet<MasteryListDto>(request, true);
        }

        public async Task<MasteryDto> GetMasteryByID(int id, Locale? locale = null, string version = null)
        {
            var request = new RestRequest($"static-data/v3/masteries/{id}", Method.GET);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            return await base.ExecuteGet<MasteryDto>(request, true);
        }

        public async Task<ProfileIconDataDto> SelectProfileIcons(Locale? locale = null, string version = null)
        {
            var request = new RestRequest("static-data/v3/profile-icons", Method.GET);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            return await base.ExecuteGet<ProfileIconDataDto>(request);
        }

        public async Task<Realm> GetRealm()
        {
            var request = new RestRequest("static-data/v3/realms", Method.GET);

            return await base.ExecuteGet<Realm>(request, true);
        }

        public async Task<RuneListDto> SelectRunes()
        {
            var request = new RestRequest("static-data/v3/runes", Method.GET);

            return await base.ExecuteGet<RuneListDto>(request, true);
        }

        public async Task<RuneDto> GetRuneByID(int id)
        {
            var request = new RestRequest($"static-data/v3/runes/{id}", Method.GET);

            return await base.ExecuteGet<RuneDto>(request, true);
        }

        public async Task<SummonerSpellListDto> SelectSummonerSpells(Locale? locale = null, string version = null, bool? dataById = null, SpellTags[] tags = null)
        {
            var request = new RestRequest("static-data/v3/summoner-spells", Method.GET);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            if (dataById.HasValue)
                request.AddParameter("dataById", dataById.ToString().ToLower());

            if (tags != null)
                foreach (var tag in tags)
                    request.AddParameter("tags", tag.ToString());

            return await base.ExecuteGet<SummonerSpellListDto>(request, true);
        }

        public async Task<SummonerSpellDto> GetSummonerSpellByID(int id, Locale? locale = null, string version = null, bool? dataById = null, SpellTags[] tags = null)
        {
            var request = new RestRequest($"static-data/v3/summoner-spells/{id}", Method.GET);

            if (locale.HasValue)
                request.AddParameter("locale", locale.ToString());

            if (!string.IsNullOrEmpty(version))
                request.AddParameter("version", version);

            if (dataById.HasValue)
                request.AddParameter("dataById", dataById.ToString().ToLower());

            if (tags != null)
                foreach (var tag in tags)
                    request.AddParameter("tags", tag.ToString());

            return await base.ExecuteGet<SummonerSpellDto>(request, true);
        }

        public async Task<List<string>> SelectVersions()
        {
            var request = new RestRequest("static-data/v3/versions", Method.GET);

            return await base.ExecuteGet<List<string>>(request);
        }
    }
}
