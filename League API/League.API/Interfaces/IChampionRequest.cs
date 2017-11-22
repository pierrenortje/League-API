using League.API.Models;
using System.Threading.Tasks;

namespace League.API.Interfaces
{
    public interface IChampionRequest
    {
        /// <summary>
        /// Retrieve all champions.
        /// </summary>
        /// <param name="freeToPlay">Optional filter param to retrieve only free to play champions.</param>
        /// <returns></returns>
        Task<ChampionData> Select(bool? freeToPlay = null);

        /// <summary>
        /// Retrieve champion by ID.
        /// </summary>
        /// <param name="id">Champion ID.</param>
        /// <returns></returns>
        Task<Champion> Get(int id);
    }
}
