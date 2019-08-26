using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    public class AdWrapper : BaseWrapper<Ad>
    {
        [JsonProperty("ad")]
        public override Ad Entity { get; set; }
    }
}
