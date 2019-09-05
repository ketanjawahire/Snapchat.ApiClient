using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents errors receives from API.
    /// </summary>
    public class ApiError
    {
        /// <summary>
        /// Gets or sets request status.
        /// </summary>
        [JsonProperty("request_status")]
        public string RequestStatus { get; set; }

        /// <summary>
        /// Gets or sets request id.
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or sets debug message.
        /// </summary>
        [JsonProperty("debug_message")]
        public string DebugMessage { get; set; }

        /// <summary>
        /// Gets or sets display message.
        /// </summary>
        [JsonProperty("display_message")]
        public string DisplayMessage { get; set; }

        /// <summary>
        /// Gets or sets error code.
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }
    }
}
