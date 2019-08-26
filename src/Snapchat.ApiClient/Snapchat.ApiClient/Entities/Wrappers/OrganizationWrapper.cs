using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    public class OrganizationWrapper : BaseWrapper<Organization>
    {
        [JsonProperty("organization")]
        public override Organization Entity { get; set; }
    }
}
