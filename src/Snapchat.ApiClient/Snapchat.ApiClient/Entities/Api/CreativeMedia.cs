using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Snapchat.ApiClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snapchat.ApiClient.Entities.Api
{
    /// <summary>
    /// Represents Snapchat Media.
    /// </summary>
    public class CreativeMedia : IEntity
    {
        /// <summary>
        /// Gets or sets media id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets updated at time.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets created at time.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets media name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets ad account id.
        /// </summary>
        [JsonProperty("ad_account_id")]
        public string AdAccountId { get; set; }

        /// <summary>
        /// Gets or sets media type.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MediaType Type { get; set; }

        /// <summary>
        /// Gets or sets link.
        /// </summary>
        [JsonProperty("download_link")]
        public string DownloadLink { get; set; }

        /// <summary>
        /// Gets or sets media status.
        /// </summary>
        [JsonProperty("media_status")]
        public string MediaStatus { get; set; }
    }
}
