using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public partial class ErrorResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}
