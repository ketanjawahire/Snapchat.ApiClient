using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents wrapper for <see cref="Campaign"/>.
    /// </summary>
    public class CampaignWrapper : BaseWrapper<Campaign>
    {
        /// <inheritdoc/>
        [JsonProperty("campaign")]
        public override Campaign Entity { get; set; }
    }
}
