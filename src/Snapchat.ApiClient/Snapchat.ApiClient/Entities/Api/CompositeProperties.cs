using System.Collections.Generic;
using Newtonsoft.Json;

namespace Snapchat.ApiClient.Entities.Api
{
    /// <summary>
    /// Represents Snapchat composite properties.
    /// </summary>
    public class CompositeProperties
    {
        /// <summary>
        /// Gets or sets url.
        /// </summary>
        [JsonProperty("creative_ids")]
#pragma warning disable CA2227 // Collection properties should be read only
        public List<string> CreativeIds { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
