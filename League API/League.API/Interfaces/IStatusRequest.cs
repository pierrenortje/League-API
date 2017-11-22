using League.API.Models;
using System.Threading.Tasks;

namespace League.API.Interfaces
{
    public interface IStatusRequest
    {
        Task<ShardStatus> SelectShardData();
    }
}
