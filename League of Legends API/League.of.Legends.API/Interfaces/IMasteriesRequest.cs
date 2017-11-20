using League.of.Legends.API.Models;
using System.Threading.Tasks;

namespace League.of.Legends.API.Interfaces
{
    public interface IMasteriesRequest
    {
        /// <summary>
        /// Get mastery pages for a given summoner ID.
        /// </summary>
        /// <param name="summonerId">Summoner ID.</param>
        /// <returns>A <see cref="MasteryPagesDto"/> object.</returns>
        Task<MasteryPagesDto> SelectSummonerMasteryPages(string summonerId);
    }
}
