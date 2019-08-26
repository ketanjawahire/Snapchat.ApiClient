using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public class AppInstallProperties
    {
        [JsonProperty("app_name")]
        public string AppName { get; set; }

        [JsonProperty("ios_app_id")]
        public string IosAppId { get; set; }

        [JsonProperty("android_app_url")]
#pragma warning disable CA1056 // Uri properties should not be strings
        public string AndroidAppUrl { get; set; }
#pragma warning restore CA1056 // Uri properties should not be strings

        [JsonProperty("icon_media_id")]
        public string IconMediaId { get; set; }
    }
}
