using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public class CreativeWrapper :  BaseWrapper<Creative>
    {
        [JsonProperty("creative")]
        public override Creative Entity { get; set; }
    }
}
