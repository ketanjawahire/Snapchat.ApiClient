using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    public class OrganizationWrapper : BaseWrapper,  IWrapper<Organization>
    {
        [JsonProperty("organization")]
        public Organization Entity { get; set; }
    }
}
