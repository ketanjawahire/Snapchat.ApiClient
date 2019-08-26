using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    public partial class AdaccountWrapper : BaseWrapper<Adaccount>
    {
        [JsonProperty("adaccount")]
        public override Adaccount Entity { get; set; }
    }
}
