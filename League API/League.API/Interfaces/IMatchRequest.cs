#region License
// Copyright (c) 2017 Pierre Nortje
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

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
