using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Snapchat.ApiClient
{
    public class Ad : IEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ad_squad_id")]
        public string AdSquadId { get; set; }

        [JsonProperty("creative_id")]
        public string CreativeId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("render_type")]
        public string RenderType { get; set; }

        [JsonProperty("review_status")]
        public string ReviewStatus { get; set; }

        [JsonProperty("review_status_reasons")]
#pragma warning disable CA2227 // Collection properties should be read only
        public List<string> ReviewStatusReasons { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only

    }
}
