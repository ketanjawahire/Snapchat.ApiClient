using System.Collections.Generic;
using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents root object for <see cref="Ad"/>.
    /// </summary>
    public class AdRootObject : RootObject<AdWrapper, Ad>
    {
#pragma warning disable CA2227 // Collection properties should be read only
        /// <inheritdoc/>
        [JsonProperty("ads")]
        public override List<AdWrapper> WrapperCollection { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
