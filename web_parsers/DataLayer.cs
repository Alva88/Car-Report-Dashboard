using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;

namespace web_parsers
{
    public static class DataLayer
    {

        public static IEnumerable<JToken> GetMakes()
        {
            var client = new WebClient();
            string response = client.DownloadString(new Uri(RequestApiData.Url + RequestApiData.UrlKey));
            //Load  makes.
            JObject Json = JObject.Parse(response);
            //load models
            IEnumerable<JToken> Makes = Json.SelectTokens("$.makes[*].name");
            return Makes;
        }

        public static IEnumerable<JToken> GetModels(string Make)
        {
                var client = new WebClient();
                RequestApiData GetUrl = new RequestApiData();
                string Url = GetUrl.RequestModelByMake(Make);
                string Response = client.DownloadString(new Uri(Url + RequestApiData.UrlKey));
                //Load  makes.
                JObject Json = JObject.Parse(Response);
                //load models
                IEnumerable<JToken> Models = Json.SelectTokens("$..models[*].name");
            return Models;
        }

        public static IEnumerable<JToken> GetYearsByModel(string Make,string Model)
        {
            var client = new WebClient();
            RequestApiData GetUrl = new RequestApiData();
            string Url = GetUrl.RequestYearsByModel(Make,Model);
            string Response = client.DownloadString(new Uri(Url + RequestApiData.UrlKey));
            //Load years
            JObject Json = JObject.Parse(Response);
            IEnumerable<JToken> Years = Json.SelectTokens("$.years[*].year");             
            return Years;
        }

        /// <summary>
        /// Requests style id for specific vehicle
        /// </summary>
        /// <param name="Make"></param>
        /// <param name="Model"></param>
        /// <param name="Year"></param>
        /// <returns></returns>
        public static string GetStyle(string Make, string Model, string Year)
        {
            var client = new WebClient();
            RequestApiData GetUrl = new RequestApiData();
            string Url = GetUrl.RequestStyles(Make,Model,Year);
            string Response = client.DownloadString(new Uri(Url + RequestApiData.UrlKey));
            //Load  makes.
            JObject Json = JObject.Parse(Response);
            //load model.
            string filter = "$.styles[0].id";
            string Styles = (string)Json.SelectToken(filter);
            return Styles;
        }

        /// <summary>
        /// Requests total costs
        /// </summary>
        /// <param name="Make"></param>
        /// <param name="Model"></param>
        /// <param name="Year"></param>
        /// <param name="StyleID"></param>
        /// <param name="ZipCode"></param>
        /// <param name="StateCode"></param>
        /// <returns></returns>
        public static JObject GetCosts(string Make, string Model, string Year, string StyleID, string ZipCode, string StateCode)
        {
            var client = new WebClient();
            RequestApiData GetUrl = new RequestApiData();
            string Response = "";
            string Url = GetUrl.RequestNewCarCosts(StyleID, ZipCode, StateCode);
            try
            {
                Response = client.DownloadString(new Uri(Url + RequestApiData.UrlKey));
            }
            catch (Exception ex)
            {
                Console.WriteLine("No data found for this particular selection:"+ Make + " / " + Model + " / " + Year + Environment.NewLine + ex);
                JObject obj = null;
                return obj;
            }
            //Load 5 year costs categories.
            JObject Json = JObject.Parse(Response);
            return Json;
        }
    }
}
