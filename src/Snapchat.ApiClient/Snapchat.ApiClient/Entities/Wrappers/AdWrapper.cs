using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public class AdWrapper : BaseWrapper, IWrapper<Ad>
    {
        [JsonProperty("ad")]
        public Ad Entity { get; set; }
    }
}
