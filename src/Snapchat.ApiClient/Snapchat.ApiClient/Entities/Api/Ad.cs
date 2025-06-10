﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Snapchat.ApiClient.Enums;

namespace Snapchat.ApiClient.Entities.Api
{
    /// <summary>
    /// Represents Snapchat Ad entity.
    /// </summary>
    public class Ad : IEntity
    {
        /// <summary>
        /// Gets or Sets Ad Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Ad Updated at value.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Ad created time.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Ad name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AdSquad Id.
        /// </summary>
        [JsonProperty("ad_squad_id")]
        public string AdSquadId { get; set; }

        /// <summary>
        /// Gets or Sets Ad creative id.
        /// </summary>
        [JsonProperty("creative_id")]
        public string CreativeId { get; set; }

        /// <summary>
        /// Gets or sets As status.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AdStatus Status { get; set; }

        /// <summary>
        /// Gets or sets ad type.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AdType Type { get; set; }

        /// <summary>
        /// Gets or sets ad review status.
        /// </summary>
        [JsonProperty("review_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AdReviewStatus ReviewStatus { get; set; }

        /// <summary>
        /// Gets or sets ad review reasons.
        /// </summary>
        [JsonProperty("review_status_reasons")]
#pragma warning disable CA2227 // Collection properties should be read only
        public List<string> ReviewStatusReasons { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only

        /// <summary>
        /// Gets or sets a value indicating whether ad is deleted.
        /// </summary>
        /// <value>
        /// Deleted status.
        /// </value>
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }
}
