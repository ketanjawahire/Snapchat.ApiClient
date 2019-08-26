using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    public class CreativeWrapper :  BaseWrapper<Creative>
    {
        [JsonProperty("creative")]
        public override Creative Entity { get; set; }
    }
}
