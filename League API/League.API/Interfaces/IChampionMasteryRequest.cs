using League.API.Models;
using System.Threading.Tasks;

namespace League.API.Interfaces
{
    public interface IChampionMasteryRequest
    {
        /// <summary>
        /// Get all champion mastery entries sorted by number of champion points descending.
        /// </summary>
        /// <param name="summonerId">Summoner ID associated with the player.</param>
        /// <returns></returns>
        Task<ChampionMasteryDtoList> SelectBySummonerID(long summonerId);

        /// <summary>
        /// Get a champion mastery by player ID and champion ID.
        /// </summary>
        /// <param name="summonerId">Summoner ID associated with the player.</param>
        /// <param name="championId">Champion ID to retrieve Champion Mastery for.</param>
        /// <returns></returns>
        Task<ChampionMasteryDto> GetBySummonerIDByChampionID(long summonerId, long championId);

        /// <summary>
        /// Get a player's total champion mastery score, which is the sum of individual champion mastery levels.
        /// </summary>
        /// <param name="summonerId">Summoner ID associated with the player.</param>
        /// <returns></returns>
        Task<int> GetScoreBySummonerID(long summonerId);
    }
}
