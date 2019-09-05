using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents wrapper for <see cref="Organization"/>.
    /// </summary>
    public class OrganizationWrapper : BaseWrapper<Organization>
    {
        /// <inheritdoc/>
        [JsonProperty("organization")]
        public override Organization Entity { get; set; }
    }
}
