using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public class CreativeWrapper :  BaseWrapper, IWrapper<Creative>
    {
        [JsonProperty("creative")]
        public Creative Entity { get; set; }
    }
}
