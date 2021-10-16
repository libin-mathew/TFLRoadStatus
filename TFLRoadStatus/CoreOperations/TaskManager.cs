using System;
using System.Threading.Tasks;

namespace TFLRoadStatus.CoreOperations
{
    /// <summary>
    /// Static Class to Handle Async Task Run
    /// </summary>
    public static class TaskManager
    {
        /// <summary>
        /// Readonly TfLRoadStatusChecker variable 
        /// </summary>
        private static readonly TfLRoadStatusChecker RoadStatusChecker = new TfLRoadStatusChecker();

        /// <summary>
        /// Task to execute asynchronously call for for Road Status 
        /// </summary>
        /// <param name="roadCode"></param>
        /// <returns></returns>
        public static async Task RunAsync(string roadCode)
        {
            try
            {
                var resRoadStatus = await RoadStatusChecker.GetRoadStatus("dsfsd");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
