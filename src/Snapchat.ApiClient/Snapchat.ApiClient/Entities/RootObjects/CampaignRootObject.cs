using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;
using System.Collections.Generic;

namespace Snapchat.ApiClient
{
    public partial class CampaignRootObject : RootObject<CampaignWrapper, Campaign>, IRootObject<CampaignWrapper, Campaign>
    {
        [JsonProperty("campaigns")]
#pragma warning disable CA2227 // Collection properties should be read only
        public override List<CampaignWrapper> WrapperCollection { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }

}
