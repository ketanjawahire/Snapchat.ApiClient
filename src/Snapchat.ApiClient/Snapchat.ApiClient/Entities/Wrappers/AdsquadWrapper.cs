using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    public class AdsquadWrapper : BaseWrapper<Adsquad>
    {
        [JsonProperty("adsquad")]
        public override Adsquad Entity { get; set; }
    }
}
