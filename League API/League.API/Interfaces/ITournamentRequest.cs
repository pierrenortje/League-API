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
