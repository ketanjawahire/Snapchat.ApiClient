using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;
using System.Collections.Generic;

namespace Snapchat.ApiClient
{
    public class OrganizationRootObject : RootObject<OrganizationWrapper, Organization>
    {
#pragma warning disable CA2227 // Collection properties should be read only
        [JsonProperty("organizations")]
        public override List<OrganizationWrapper> WrapperCollection { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }

}
