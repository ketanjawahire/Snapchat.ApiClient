using Newtonsoft.Json;

namespace Snapchat.ApiClient.Entities.Api
{
    public class WebViewProperties
    {
        [JsonProperty("url")]
#pragma warning disable CA1056 // Uri properties should not be strings
        public string Url { get; set; }
#pragma warning restore CA1056 // Uri properties should not be strings
    }
}
