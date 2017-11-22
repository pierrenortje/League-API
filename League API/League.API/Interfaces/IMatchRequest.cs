using League.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace League.API.Interfaces
{
    public interface IMatchRequest
    {
        /// <summary>
        /// Get match by match ID.
        /// </summary>
        /// <param name="matchId">The match ID.</param>
        /// <returns></returns>
        Task<MatchDto> Get(long matchId);

        /// <summary>
        /// Get matchlist for games played on given account ID and platform ID and filtered using given filter parameters, if any.
        /// </summary>
        /// <param name="accountId">The account ID.</param>
        /// <returns></returns>
        Task<MatchlistDto> SelectMatchLists(long accountId);

        /// <summary>
        /// Get matchlist for last 20 matches played on given account ID and platform ID.
        /// </summary>
        /// <param name="accountId">The account ID.</param>
        /// <returns></returns>
        Task<MatchlistDto> SelectMatchListsRecent(long accountId);

        /// <summary>
        /// Get match timeline by match ID.
        /// Note: Not all matches have timeline data.
        /// </summary>
        /// <param name="matchId">The account ID.</param>
        /// <returns></returns>
        Task<MatchTimelineDto> GetTimelineByMatchId(long matchId);

        /// <summary>
        /// Get match IDs by tournament code.
        /// </summary>
        /// <param name="tournamentCode">The tournament code.</param>
        /// <returns></returns>
        Task<List<long>> SelectMatchesByTournamentCode(long tournamentCode);

        /// <summary>
        /// Get match by match ID and tournament code.
        /// </summary>
        /// <param name="matchId">The match ID.</param>
        /// <param name="tournamentCode">The tournament code.</param>
        /// <returns></returns>
        Task<MatchDto> GetByMatchIdTournamentCode(long matchId, long tournamentCode);
    }
}
