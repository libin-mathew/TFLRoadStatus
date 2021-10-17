
using System.Threading.Tasks;
using TFLRoadStatus.CoreOperations.Models;

namespace TFLRoadStatus.CoreOperations
{
    /// <summary>
    /// Interface to provide concrete implementation for TFL API calls.
    /// </summary>
    public interface ITfLRoadStatusChecker
    {
        /// <summary>
        /// To Make the TFL Road Status Api call
        /// </summary>
        /// <param name="roadId"></param>
        /// <returns></returns>
        public Task<RoadStatus> GetRoadStatus(string roadId);

        /// <summary>
        /// Serialize Road status response JSON to Model 
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public RoadStatus SerializeRoadStatusResponse(string response);
    }
}
