using Newtonsoft.Json;
using Snapchat.ApiClient.Enums;
using System;

namespace Snapchat.ApiClient.Entities.Api
{
    public class Adsquad : IEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("targeting")]
        public Targeting Targeting { get; set; }

        [JsonProperty("placement")]
        public string Placement { get; set; }

        [JsonProperty("billing_event")]
        public string BillingEvent { get; set; }

        [JsonProperty("bid_micro")]
        public long BidMicro { get; set; }

        [JsonProperty("daily_budget_micro")]
        public long DailyBudgetMicro { get; set; }

        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }

        [JsonProperty("optimization_goal")]
        public OptimizationGoal OptimizationGoal { get; set; }
    }
}
