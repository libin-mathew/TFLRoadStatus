
using System.Threading.Tasks;
using TFLRoadStatus.CoreOperations.Models;

namespace TFLRoadStatus.CoreOperations
{
    /// <summary>
    /// Interface to provide concrete implementation for TFL API calls
    /// </summary>
    public interface ITfLRoadStatusChecker
    {
        public Task<RoadStatus> GetRoadStatus(string roadId);
        public RoadStatus SerializeRoadStatusResponse(string response);
    }
}
