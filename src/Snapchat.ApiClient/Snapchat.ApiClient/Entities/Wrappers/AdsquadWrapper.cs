using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public class AdsquadWrapper : BaseWrapper<Adsquad>
    {
        [JsonProperty("adsquad")]
        public override Adsquad Entity { get; set; }
    }
}
