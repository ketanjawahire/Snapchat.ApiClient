using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public abstract class BaseWrapper
    {
        [JsonProperty("sub_request_status")]
        public string SubRequestStatus { get; set; }
    }
}
