using System;
using Newtonsoft.Json;
using Snapchat.ApiClient.Enums;

namespace Snapchat.ApiClient.Entities.Api
{
    /// <summary>
    /// Represents Snapchat campaign entity.
    /// </summary>
    public class Campaign : IEntity
    {
        /// <summary>
        /// Gets or sets campaign id.
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
        /// Gets or sets campaign name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets ad account id.
        /// </summary>
        [JsonProperty("ad_account_id")]
        public string AdAccountId { get; set; }

        /// <summary>
        /// Gets or sets daily budget value.
        /// </summary>
        [JsonProperty("daily_budget_micro")]
        public long? DailyBudgetMicro { get; set; }

        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty("status")]
        public CampaignStatus Status { get; set; }

        /// <summary>
        /// Gets or sets start time.
        /// </summary>
        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets end time.
        /// </summary>
        [JsonProperty("end_time")]
        public DateTime? EndTime { get; set; }
    }
}
