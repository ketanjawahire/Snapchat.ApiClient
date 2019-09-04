using System.Collections.Generic;
using Newtonsoft.Json;

namespace Snapchat.ApiClient.Entities.Api
{
    // TODO : complete class structure

    /// <summary>
    /// Represents Snapchat targeting.
    /// </summary>
    public class Targeting
    {
        /// <summary>
        /// Gets or sets geos.
        /// </summary>
        [JsonProperty("geos", NullValueHandling = NullValueHandling.Ignore)]
#pragma warning disable CA2227 // Collection properties should be read only
        public List<Geo> Geos { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
