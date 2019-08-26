using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public class Paging
    {
        [JsonProperty("next_link")]
        public string NextLink { get; set; }
    }
}
