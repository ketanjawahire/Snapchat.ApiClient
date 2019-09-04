using System.Collections.Generic;
using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents root object for <see cref="Creative"/>.
    /// </summary>
    public class CreativeRootObject : RootObject<CreativeWrapper, Creative>
    {
        /// <inheritdoc/>
        [JsonProperty("creatives")]
#pragma warning disable CA2227 // Collection properties should be read only
        public override List<CreativeWrapper> WrapperCollection { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
