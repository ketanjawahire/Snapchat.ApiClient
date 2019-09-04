using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Snapchat.ApiClient.Enums;

namespace Snapchat.ApiClient.Entities.Api
{
    /// <summary>
    /// Represents Snapchat ad account.
    /// </summary>
    public class Adaccount : IEntity
    {
        /// <summary>
        /// Gets or sets ad account id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets updated at value.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets created at value.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets ad account name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets ad account type.
        /// </summary>
        [JsonProperty("type")]
        public AdAccountType Type { get; set; }

        /// <summary>
        /// Gets or sets ad account status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets organization id.
        /// </summary>
        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets funding source ids.
        /// </summary>
        [JsonProperty("funding_source_ids")]
#pragma warning disable CA2227 // Collection properties should be read only
        public List<string> FundingSourceIds { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only

        /// <summary>
        /// Gets or sets currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets timezone.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or sets advertiser.
        /// </summary>
        [JsonProperty("advertiser")]
        public string Advertiser { get; set; }
    }
}
