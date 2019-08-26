using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public partial class CampaignWrapper : BaseWrapper<Campaign>
    {
        [JsonProperty("campaign")]
        public override Campaign Entity { get; set; }
    }

}
