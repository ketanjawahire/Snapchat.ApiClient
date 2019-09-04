using System.Collections.Generic;
using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents root object for <see cref="Campaign"/>.
    /// </summary>
    public class CampaignRootObject : RootObject<CampaignWrapper, Campaign>, IRootObject<CampaignWrapper, Campaign>
    {
        /// <inheritdoc/>
        [JsonProperty("campaigns")]
#pragma warning disable CA2227 // Collection properties should be read only
        public override List<CampaignWrapper> WrapperCollection { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
