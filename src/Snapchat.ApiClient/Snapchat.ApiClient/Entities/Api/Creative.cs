using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Snapchat.ApiClient.Enums;

namespace Snapchat.ApiClient.Entities.Api
{
    /// <summary>
    /// Represents Snapchat creative.
    /// </summary>
    public class Creative : IEntity
    {
        /// <summary>
        /// Gets or sets creative id.
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
        /// Gets or sets creative name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets creative headline.
        /// </summary>
        [JsonProperty("headline")]
        public string Headline { get; set; }

        /// <summary>
        /// Gets or sets ad account id.
        /// </summary>
        [JsonProperty("ad_account_id")]
        public string AdAccountId { get; set; }

        /// <summary>
        /// Gets or sets creative type.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CreativeType Type { get; set; }

        /// <summary>
        /// Gets or sets packaging status.
        /// </summary>
        [JsonProperty("packaging_status")]
        public string PackagingStatus { get; set; }

        /// <summary>
        /// Gets or sets review status.
        /// </summary>
        [JsonProperty("review_status")]
        public string ReviewStatus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it is sharable or not.
        /// </summary>
        [JsonProperty("shareable")]
        public bool Shareable { get; set; }

        /// <summary>
        /// Gets or sets call to action type.
        /// </summary>
        [JsonProperty("call_to_action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CallToAction CallToAction { get; set; }

        /// <summary>
        /// Gets or sets top snap id.
        /// </summary>
        [JsonProperty("top_snap_media_id")]
        public string TopSnapMediaId { get; set; }

        /// <summary>
        /// Gets or sets top snap crop position.
        /// </summary>
        [JsonProperty("top_snap_crop_position")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TopSnapCropPosition? TopSnapCropPosition { get; set; }

        /// <summary>
        /// Gets or sets long form video properties.
        /// </summary>
        [JsonProperty("longform_video_properties", NullValueHandling = NullValueHandling.Ignore)]
        public LongformVideoProperties LongformVideoProperties { get; set; }

        /// <summary>
        /// Gets or sets app install properties.
        /// </summary>
        [JsonProperty("app_install_properties", NullValueHandling = NullValueHandling.Ignore)]
        public AppInstallProperties AppInstallProperties { get; set; }

        /// <summary>
        /// Gets or sets web view properties.
        /// </summary>
        [JsonProperty("web_view_properties", NullValueHandling = NullValueHandling.Ignore)]
        public WebViewProperties WebViewProperties { get; set; }

        /// <summary>
        /// Gets or sets brand name.
        /// </summary>
        [JsonProperty("brand_name")]
        public string BrandName { get; set; }
    }
}
