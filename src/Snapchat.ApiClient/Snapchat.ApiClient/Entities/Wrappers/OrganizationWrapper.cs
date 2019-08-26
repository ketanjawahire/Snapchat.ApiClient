using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public class OrganizationWrapper : BaseWrapper<Organization>
    {
        [JsonProperty("organization")]
        public override Organization Entity { get; set; }
    }
}
