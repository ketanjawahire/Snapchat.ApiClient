using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public class AdsquadWrapper : BaseWrapper, IWrapper<Adsquad>
    {
        [JsonProperty("adsquad")]
        public Adsquad Entity { get; set; }
    }
}
