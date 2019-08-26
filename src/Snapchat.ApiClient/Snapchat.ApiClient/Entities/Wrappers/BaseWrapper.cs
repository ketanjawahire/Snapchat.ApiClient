using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public abstract class BaseWrapper<T> : IWrapper<T> where T: IEntity
    {
        [JsonProperty("sub_request_status")]
        public string SubRequestStatus { get; set; }
        public abstract T Entity { get; set; }
    }
}
