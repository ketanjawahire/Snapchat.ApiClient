using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public partial class AdaccountWrapper : BaseWrapper, IWrapper<Adaccount>
    {
        [JsonProperty("adaccount")]
        public Adaccount Entity { get; set; }
    }
}
