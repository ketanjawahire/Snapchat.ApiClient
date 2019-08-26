using Newtonsoft.Json;

namespace Snapchat.ApiClient.Entities.Api
{
    public class LongformVideoProperties
    {
        [JsonProperty("video_media_id")]
        public string VideoMediaId { get; set; }
    }
}
