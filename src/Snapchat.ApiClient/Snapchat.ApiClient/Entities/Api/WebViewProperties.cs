using Newtonsoft.Json;

namespace Snapchat.ApiClient.Entities.Api
{
    /// <summary>
    /// Represents Snapchat web view properties.
    /// </summary>
    public class WebViewProperties
    {
        /// <summary>
        /// Gets or sets url.
        /// </summary>
        [JsonProperty("url")]
#pragma warning disable CA1056 // Uri properties should not be strings
        public string Url { get; set; }
#pragma warning restore CA1056 // Uri properties should not be strings
    }
}
