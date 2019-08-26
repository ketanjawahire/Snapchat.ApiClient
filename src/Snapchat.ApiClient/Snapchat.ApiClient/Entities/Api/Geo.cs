using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    //TODO : complete class structure
    public class Geo
    {
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
    }
}
