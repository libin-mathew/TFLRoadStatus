using Microsoft.Extensions.Configuration;
using TFLRoadStatus.CoreOperations.Models;

namespace TFLRoadStatus
{
    /// <summary>
    /// Static class to hold the constants.
    /// </summary>
    public static class AppConstants
    {
        static IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();
        static IConfiguration configSection = configuration.GetSection(nameof(AppSettings));

        /// <summary>
        /// Static Constructor
        /// </summary>
        static AppConstants()
        {
            TflApiKey = configSection["TFLApiKey"];
            AppKey = configSection["AppKey"];
            ApiBaseAddress = configSection["BaseAddress"];
        }
        /// <summary>
        /// TFL Api Key
        /// </summary>
        public static readonly string TflApiKey;

        /// <summary>
        /// App Key
        /// </summary>
        public static readonly string AppKey;

        /// <summary>
        /// Api Base Address
        /// </summary>
        public static readonly string ApiBaseAddress;
    }
}
