using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public class AdWrapper : BaseWrapper<Ad>
    {
        [JsonProperty("ad")]
        public override Ad Entity { get; set; }
    }
}
