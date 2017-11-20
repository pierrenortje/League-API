using League.of.Legends.API.Models;
using System.Threading.Tasks;

namespace League.of.Legends.API.Interfaces
{
    public interface IStatusRequest
    {
        Task<ShardStatus> SelectShardData();
    }
}
