namespace Snapchat.ApiClient.Entities.Api
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Snapchat.ApiClient.Enums;

    /// <summary>
    /// Represents the properties for Objective V2 in the Snapchat API.
    /// </summary>
    public class ObjectiveV2Properties
    {
        /// <summary>
        /// Gets or sets the type of the Objective V2.
        /// </summary>
        /// <value>
        /// ObjectiveV2Type.
        /// </value>
        [JsonProperty("objective_v2_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CampaignObjective ObjectiveV2Type { get; set; }
    }
}
