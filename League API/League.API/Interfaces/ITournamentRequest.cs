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
    public interface ITournamentRequest
    {
        /// <summary>
        /// Create a mock tournament code for the given tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <param name="count">The number of codes to create (max 1000).</param>
        Task<List<string>> SelectCodes(int tournamentId, TournamentCodeParameters model = null, int? count = null);

        /// <summary>
        /// Gets a mock list of lobby events by tournament code.
        /// </summary>
        /// <param name="tournamentCode">The short code to look up lobby events for.</param>
        void UpdateCode(string tournamentCode, TournamentCodeUpdateParameters model = null);

        /// <summary>
        /// Returns the tournament code DTO associated with a tournament code string.
        /// </summary>
        /// <param name="tournamentCode"></param>
        /// <returns>A <see cref="LobbyEventDtoWrapper"/> object.</returns>
        Task<TournamentCodeDto> GetCode(string tournamentCode);

        /// <summary>
        /// Gets a list of lobby events by tournament code.
        /// </summary>
        /// <param name="tournamentCode"></param>
        /// <returns></returns>
        Task<LobbyEventDtoWrapper> SelectLobbyEvents(string tournamentCode);

        /// <summary>
        /// Creates a mock tournament provider and returns its ID.
        /// </summary>
        /// <returns>The provider Id.</returns>
        Task<int> CreateProvider(ProviderRegistrationParameters model);

        /// <summary>
        /// Creates a mock tournament and returns its ID.
        /// </summary>
        /// <returns>The tournament Id.</returns>
        Task<int> CreateTournament(TournamentRegistrationParameters model);
    }
}
