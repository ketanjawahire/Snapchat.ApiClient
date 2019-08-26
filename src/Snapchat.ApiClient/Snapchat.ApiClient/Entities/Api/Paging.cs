using Newtonsoft.Json;

namespace Snapchat.ApiClient.Entities.Api
{
    public class Paging
    {
        [JsonProperty("next_link")]
        public string NextLink { get; set; }
    }
}
