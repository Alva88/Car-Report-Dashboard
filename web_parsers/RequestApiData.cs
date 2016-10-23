
namespace web_parsers
{
    public class RequestApiData
    {
        /// <summary>
        /// Urls used to access data
        /// </summary>
        public const string Url = "http://api.edmunds.com/api/vehicle/v2/makes?fmt=json&api_key=";
        public const string UrlModelsByMake = "https://api.edmunds.com/api/vehicle/v2/{make}/models?fmt=json&api_key=";
        public const string UrlYearsByModels = "http://api.edmunds.com/api/vehicle/v2/{make}/{model}/years?fmt=json&api_key=";
        public const string UrlStyles = "https://api.edmunds.com/api/vehicle/v2/{make}/{model}/{year}/styles?fmt=json&api_key=";
        public const string UrlNewCarCosts = "https://api.edmunds.com/api/tco/v1/details/allnewtcobystyleidzipandstate/{style ID}/{zipcode}/{US State Code}?fmt=json&api_key=";
        /// <summary>
        /// Api key used with the url
        /// </summary>
        public const string UrlKey = "xayj35a45s9a4y7t2z2ncwc9";

        public string RequestModelByMake(string Make)
        {
            string Url = UrlModelsByMake.Replace("{make}", Make);
            return Url;
        }

        public string RequestYearsByModel(string make, string model)
        {
            string Url = UrlYearsByModels.Replace("{make}", make);
            Url = Url.Replace("{model}",model);
            return Url;
        }

        public string RequestNewCarCosts(string StyleID, string StateCode, string ZipCode)
        {
            string Url = UrlNewCarCosts.Replace("{style ID}", StyleID);
            Url = Url.Replace("{zipcode}", ZipCode);
            Url = Url.Replace("{US State Code}", StateCode);
            return Url;
        }

        public string RequestStyles(string make, string model, string year)
        {
            string Url = UrlStyles.Replace("{make}", make);
            Url = Url.Replace("{model}", model);
            Url = Url.Replace("{year}", year);
            return Url;
        }
    }
}
