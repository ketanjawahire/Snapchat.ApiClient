using System.Collections.Generic;
using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents root object for <see cref="Organization"/>.
    /// </summary>
    public class OrganizationRootObject : RootObject<OrganizationWrapper, Organization>
    {
#pragma warning disable CA2227 // Collection properties should be read only
        /// <inheritdoc/>
        [JsonProperty("organizations")]
        public override List<OrganizationWrapper> WrapperCollection { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
