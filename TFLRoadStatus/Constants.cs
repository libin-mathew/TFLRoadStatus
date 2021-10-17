using System.Configuration;


namespace TFLRoadStatus
{
    /// <summary>
    /// Static class to hold the constants.
    /// </summary>
    public static class Constants
    {
        static Constants()
        {
            TflApiKey = ConfigurationManager.AppSettings["TFLApiKey"];
            AppKey = AppKey = ConfigurationManager.AppSettings["AppKey"];
            ApiBaseAddress = ConfigurationManager.AppSettings["BaseAddress"];
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
