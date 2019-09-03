using Newtonsoft.Json;
using Snapchat.ApiClient.Enums;
using System;
using System.Collections.Generic;

namespace Snapchat.ApiClient.Entities.Api
{
    public class Adaccount : IEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public AdAccountType Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        [JsonProperty("funding_source_ids")]
#pragma warning disable CA2227 // Collection properties should be read only
        public List<string> FundingSourceIds { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("advertiser")]
        public string Advertiser { get; set; }
    }
}
