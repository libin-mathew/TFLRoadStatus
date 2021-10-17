using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TFLRoadStatus.CoreOperations.Models;

namespace TFLRoadStatus.CoreOperations
{

    /// <summary>
    /// Class to Handle TFL API call and Serialize the Response JSON to Model.
    /// Implementing the interface ITfLRoadStatusChecker.
    /// </summary>
    public class TfLRoadStatusChecker : ITfLRoadStatusChecker
    {
        private static readonly HttpClient HttpClient = new HttpClient();
        private string baseUrl;

        public TfLRoadStatusChecker()
        {
           baseUrl= Constants.ApiBaseAddress;
        }

        /// <summary>
        /// Async Method to call TFL Roads Api
        /// </summary>
        /// <param name="roadId"></param>
        /// <returns></returns>
        public async Task<RoadStatus> GetRoadStatus(string roadId)
        {
            //Setting http client details
            HttpClient.BaseAddress = new Uri(Constants.ApiBaseAddress);
            HttpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            RoadStatus roadStatus = new RoadStatus();
            // Uri for Api call
            string apiUrl = string.Format("{0}{1}?app_id={2}&amp;app_key={3}", Constants.ApiBaseAddress, roadId,
                Constants.AppKey, Constants.TflApiKey);

            try
            {
                HttpResponseMessage response = await HttpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    roadStatus = SerializeRoadStatusResponse(responseBody);
                    roadStatus.HttpsStatus = true;
                }
                else
                {
                    roadStatus.HttpsStatus = false;
                }
            }
            catch (Exception exe)
            {

                throw;
            }

            return roadStatus;
        }

        /// <summary>
        /// To Serialize Response Json to Model Class
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public RoadStatus SerializeRoadStatusResponse(string response)
        {
            var responseObject = JsonConvert.DeserializeObject<List<RoadStatus>>(response);
            return responseObject.FirstOrDefault();
        }
    }
}
