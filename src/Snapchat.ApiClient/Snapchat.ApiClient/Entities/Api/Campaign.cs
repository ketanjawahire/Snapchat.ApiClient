using Newtonsoft.Json;
using System;

namespace Snapchat.ApiClient
{
    public partial class Campaign : IEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ad_account_id")]
        public string AdAccountId { get; set; }

        [JsonProperty("daily_budget_micro")]
        public long? DailyBudgetMicro { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }

        [JsonProperty("end_time")]
        public DateTime? EndTime { get; set; }
    }

}
