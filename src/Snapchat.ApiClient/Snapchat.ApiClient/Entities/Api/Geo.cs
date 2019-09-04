using Newtonsoft.Json;

namespace Snapchat.ApiClient.Entities.Api
{
    /// <summary>
    /// Represents Snapchat Geo entity.
    /// </summary>
    public class Geo
    {
        // TODO : complete class structure

        /// <summary>
        /// Gets or sets country code.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
    }
}
