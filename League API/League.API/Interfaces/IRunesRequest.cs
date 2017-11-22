using League.API.Models;
using System.Threading.Tasks;

namespace League.API.Interfaces
{
    public interface IRunesRequest
    {
        /// <summary>
        /// Get rune pages for a given summoner ID.
        /// </summary>
        /// <param name="summonerId">Summoner ID.</param>
        /// <returns>A <see cref="RunePagesDto"/> object.</returns>
        Task<RunePagesDto> SelectBySummonerId(string summonerId);
    }
}
