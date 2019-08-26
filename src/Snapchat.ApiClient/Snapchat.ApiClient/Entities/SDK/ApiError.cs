using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    //TODO : rethink class name
    public class ApiError
    {
        [JsonProperty("request_status")]
        public string RequestStatus { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("debug_message")]
        public string DebugMessage { get; set; }

        [JsonProperty("display_message")]
        public string DisplayMessage { get; set; }

        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }
    }
}
