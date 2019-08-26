using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public partial class AdaccountWrapper : BaseWrapper<Adaccount>
    {
        [JsonProperty("adaccount")]
        public override Adaccount Entity { get; set; }
    }
}
