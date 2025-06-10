using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Snapchat.ApiClient.Enums;

namespace Snapchat.ApiClient.Entities.Api
{
    /// <summary>
    /// Represents Snapchat Adsquad entity.
    /// </summary>
    public class Adsquad : IEntity
    {
        /// <summary>
        /// Gets or sets Adsquad id.
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
        /// Gets or sets adsquad name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets adsquad status.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AdSquadStatus Status { get; set; }

        /// <summary>
        /// Gets or sets campaign id.
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or sets adsquad type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets adsquad targeting.
        /// </summary>
        [JsonProperty("targeting")]
        public Targeting Targeting { get; set; }

        /// <summary>
        /// Gets or sets adsquad placement.
        /// </summary>
        [JsonProperty("placement")]
        public string Placement { get; set; }

        /// <summary>
        /// Gets or sets billing event information.
        /// </summary>
        [JsonProperty("billing_event")]
        public string BillingEvent { get; set; }

        /// <summary>
        /// Gets or sets max bid.
        /// </summary>
        [JsonProperty("bid_micro")]
        public long BidMicro { get; set; }

        /// <summary>
        /// Gets or sets daily budget.
        /// </summary>
        [JsonProperty("daily_budget_micro")]
        public long DailyBudgetMicro { get; set; }

        /// <summary>
        /// Gets or sets start time.
        /// </summary>
        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets optimization goal.
        /// </summary>
        [JsonProperty("optimization_goal")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OptimizationGoal OptimizationGoal { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether ad squad is deleted.
        /// </summary>
        /// <value>
        /// Deleted status.
        /// </value>
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }
}
