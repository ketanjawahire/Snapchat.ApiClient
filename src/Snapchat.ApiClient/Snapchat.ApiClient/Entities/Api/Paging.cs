using Newtonsoft.Json;

namespace Snapchat.ApiClient.Entities.Api
{
    /// <summary>
    /// Represents Snapchat paging object.
    /// </summary>
    public class Paging
    {
        /// <summary>
        /// Gets or sets next page link.
        /// </summary>
        [JsonProperty("next_link")]
        public string NextLink { get; set; }
    }
}
