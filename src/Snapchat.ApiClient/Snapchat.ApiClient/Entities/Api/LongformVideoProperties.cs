using Newtonsoft.Json;

namespace Snapchat.ApiClient.Entities.Api
{
    /// <summary>
    /// Represents Snapchat long form video properties.
    /// </summary>
    public class LongformVideoProperties
    {
        /// <summary>
        /// Gets or sets video media id.
        /// </summary>
        [JsonProperty("video_media_id")]
        public string VideoMediaId { get; set; }
    }
}
