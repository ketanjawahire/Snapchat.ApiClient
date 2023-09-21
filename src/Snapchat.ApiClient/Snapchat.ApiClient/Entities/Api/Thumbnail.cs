using Newtonsoft.Json;

namespace Snapchat.ApiClient.Entities.Api
{
    /// <summary>
    /// Represents Snapchat Media thumbnail.
    /// </summary>
    public class Thumbnail : IEntity
    {
        /// <summary>
        /// Gets or sets media id.
        /// </summary>
        [JsonProperty("media_id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets link.
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
