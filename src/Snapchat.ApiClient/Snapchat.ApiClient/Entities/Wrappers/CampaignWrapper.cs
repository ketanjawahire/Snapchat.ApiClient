using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    public class CampaignWrapper : BaseWrapper<Campaign>
    {
        [JsonProperty("campaign")]
        public override Campaign Entity { get; set; }
    }

}
