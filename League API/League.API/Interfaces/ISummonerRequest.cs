using League.API.Models;
using System.Threading.Tasks;

namespace League.API.Interfaces
{
    public interface ISummonerRequest
    {
        /// <summary>
        /// Get a summoner by account ID.
        /// </summary>
        /// <returns>A <see cref="SummonerDto"/> object.</returns>
        Task<SummonerDto> GetByAccountId(long accountId);

        /// <summary>
        /// Get a summoner by summoner name.
        /// </summary>
        /// <param name="summonerName">Summoner Name.</param>
        /// <returns>A <see cref="SummonerDto"/> object.</returns>
        Task<SummonerDto> GetBySummonerName(string summonerName);

        /// <summary>
        /// Get a summoner by summoner ID.
        /// </summary>
        /// <param name="summonerId">Summoner ID.</param>
        /// <returns>A <see cref="SummonerDto"/> object.</returns>
        Task<SummonerDto> GetBySummonerName(long summonerId);
    }
}
