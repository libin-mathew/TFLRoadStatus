using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using TFLRoadStatus.CoreOperations.Models;

namespace TFLRoadStatus
{
    public static class AppConstants
    {
        static IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();
        static IConfiguration configSection = configuration.GetSection(nameof(AppSettings));

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
