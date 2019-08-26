using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public partial class CampaignWrapper : BaseWrapper, IWrapper<Campaign>
    {
        [JsonProperty("campaign")]
        public Campaign Entity { get; set; }
    }

}
