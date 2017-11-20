using League.of.Legends.API.Models;
using System.Threading.Tasks;

namespace League.of.Legends.API.Interfaces
{
    public interface ILeagueRequest
    {
        /// <summary>
        /// Get the challenger league for given queue.
        /// </summary>
        /// <returns></returns>
        Task<LeagueListDto> SelectChallengerLeagueByQueue(QueueType queueType);

        /// <summary>
        /// Get leagues in all queues for a given summoner ID.
        /// </summary>
        /// <param name="summonerId">Summoner ID associated with the player.</param>
        /// <returns></returns>
        Task<LeagueListDtoList> SelectSummonerLeagues(long summonerId);

        /// <summary>
        /// Get league with given ID, including inactive entries.
        /// </summary>
        /// <param name="leagueId">The UUID of the league.</param>
        /// <returns></returns>
        Task<LeagueListDto> Get(string leagueId);

        /// <summary>
        /// Get the master league for given queue.
        /// </summary>
        /// <returns></returns>
        Task<LeagueListDto> SelectMasterLeagueByQueue(QueueType queueType);

        /// <summary>
        /// Get league positions in all queues for given summoner ID.
        /// </summary>
        /// <param name="summonerId">Summoner ID associated with the player.</param>
        /// <returns></returns>
        Task<LeagueItemDto> SelectSummonerLeaguePositions(long summonerId);
    }
}
