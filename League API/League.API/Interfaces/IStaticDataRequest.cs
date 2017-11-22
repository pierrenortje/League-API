using League.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.API.Interfaces
{
    public interface IStaticDataRequest
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
        /// <returns>A <see cref="ChampionListDto"/> object.</returns>
        Task<ChampionListDto> SelectChampionsDetails(Locale? locale = null, string version = null, ChampionListTags[] tags = null, bool? dataById = null);

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
        /// <returns>A <see cref="ChampionDto"/> object.</returns>
        Task<ChampionDto> GetChampionDetailsByID(int id, Locale? locale = null, string version = null, ChampionTags[] tags = null);

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
        /// <returns>A <see cref="ItemListDto"/> object.</returns>
        Task<ItemListDto> SelectItemsDetails(Locale? locale = null, string version = null, ItemTags[] tags = null);

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
        /// <returns>A <see cref="ItemDto"/> object.</returns>
        Task<ItemDto> GetItemDetailsByID(int id, Locale? locale = null, string version = null, ItemTags[] tags = null);

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
        /// <returns>A <see cref="LanguageStringsDto"/> object.</returns>
        Task<LanguageStringsDto> GetLanguageStrings(Locale? locale = null, string version = null);

        /// <summary>
        /// Retrieve supported languages data.
        /// </summary>
        /// <returns>A list of strings.</returns>
        Task<List<string>> SelectLanguages();

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
        /// <returns>A <see cref="MapDataDto"/> object.</returns>
        Task<MapDataDto> SelectMaps(Locale? locale = null, string version = null);

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
        /// <returns>A <see cref="MasteryListDto"/> object.</returns>
        Task<MasteryListDto> SelectMasteries(Locale? locale = null, string version = null);

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
        /// <returns>A <see cref="MasteryDto"/> object.</returns>
        Task<MasteryDto> GetMasteryByID(int id, Locale? locale = null, string version = null);

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
        /// <returns>A <see cref="ProfileIconDataDto"/> object.</returns>
        Task<ProfileIconDataDto> SelectProfileIcons(Locale? locale = null, string version = null);

        /// <summary>
        /// Retrieve realm data.
        /// </summary>
        /// <returns>A <see cref="Realm"/> object.</returns>
        Task<Realm> GetRealm();

        /// <summary>
        /// Retrieves rune list.
        /// </summary>
        /// <returns>A <see cref="RuneListDto"/> object.</returns>
        Task<RuneListDto> SelectRunes();

        /// <summary>
        /// Retrieves rune by ID.
        /// </summary>
        /// <returns>A <see cref="RuneDto"/> object.</returns>
        Task<RuneDto> GetRuneByID(int id);

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
        /// <returns>A <see cref="SummonerSpellListDto"/> object.</returns>
        Task<SummonerSpellListDto> SelectSummonerSpells(Locale? locale = null, string version = null, bool? dataById = null, SpellTags[] tags = null);

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
        /// <returns>A <see cref="SummonerSpellDto"/> object.</returns>
        Task<SummonerSpellDto> GetSummonerSpellByID(int id, Locale? locale = null, string version = null, bool? dataById = null, SpellTags[] tags = null);

        /// <summary>
        /// Retrieve version data.
        /// </summary>
        /// <returns>A list of strings.</returns>
        Task<List<string>> SelectVersions();
    }
}
