using Newtonsoft.Json;
using Snapchat.ApiClient.Enums;
using System;

namespace Snapchat.ApiClient.Entities.Api
{
    public class Creative : IEntity
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

        [JsonProperty("type")]
        public CreativeType Type { get; set; }

        [JsonProperty("packaging_status")]
        public string PackagingStatus { get; set; }

        [JsonProperty("review_status")]
        public string ReviewStatus { get; set; }

        [JsonProperty("shareable")]
        public bool Shareable { get; set; }

        [JsonProperty("call_to_action")]
        public CallToAction CallToAction { get; set; }

        [JsonProperty("top_snap_media_id")]
        public string TopSnapMediaId { get; set; }

        [JsonProperty("top_snap_crop_position")]
        public TopSnapCropPosition? TopSnapCropPosition { get; set; }

        [JsonProperty("longform_video_properties", NullValueHandling = NullValueHandling.Ignore)]
        public LongformVideoProperties LongformVideoProperties { get; set; }

        [JsonProperty("app_install_properties", NullValueHandling = NullValueHandling.Ignore)]
        public AppInstallProperties AppInstallProperties { get; set; }

        [JsonProperty("web_view_properties", NullValueHandling = NullValueHandling.Ignore)]
        public WebViewProperties WebViewProperties { get; set; }
    }
}
