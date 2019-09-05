using Newtonsoft.Json;

namespace Snapchat.ApiClient.Entities.Api
{
    /// <summary>
    /// Reprresents Snapchat app install properties.
    /// </summary>
    public class AppInstallProperties
    {
        /// <summary>
        /// Gets or sets app name.
        /// </summary>
        [JsonProperty("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// Gets or sets iOS app id.
        /// </summary>
        [JsonProperty("ios_app_id")]
        public string IosAppId { get; set; }

        /// <summary>
        /// Gets or sets andriod app url.
        /// </summary>
        [JsonProperty("android_app_url")]
#pragma warning disable CA1056 // Uri properties should not be strings
        public string AndroidAppUrl { get; set; }
#pragma warning restore CA1056 // Uri properties should not be strings

        /// <summary>
        /// Gets or sets icon media id.
        /// </summary>
        [JsonProperty("icon_media_id")]
        public string IconMediaId { get; set; }
    }
}
