using League.API.Models;
using System.Threading.Tasks;

namespace League.API.Interfaces
{
    public interface ISpectatorRequest
    {
        /// <summary>
        /// Get current game information for the given summoner ID.
        /// </summary>
        /// <param name="summonerId">The ID of the summoner.</param>
        /// <returns>A <see cref="CurrentGameInfo"/> object.</returns>
        Task<CurrentGameInfo> SelectActiveGamesBySummonerId(long summonerId);

        /// <summary>
        /// Get list of featured games.
        /// </summary>
        /// <param name="summonerId">The ID of the summoner.</param>
        /// <returns>A <see cref="FeaturedGames"/> object.</returns>
        Task<FeaturedGames> SelectFeaturedGames();
    }
}
