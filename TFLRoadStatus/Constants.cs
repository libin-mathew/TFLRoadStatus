﻿using System.Configuration;


namespace TFLRoadStatus
{
    /// <summary>
    /// Static class to hold the constants
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// TFL Api Key
        /// </summary>
        public static readonly string TFLApiKey = ConfigurationManager.AppSettings["TFLApiKey"];

        /// <summary>
        /// App Key
        /// </summary>
        public static readonly string AppKey = ConfigurationManager.AppSettings["AppKey"];

        /// <summary>
        /// App Key
        /// </summary>
        public static readonly string ApiBaseAddress = ConfigurationManager.AppSettings["BaseAddress"];
    }
}
