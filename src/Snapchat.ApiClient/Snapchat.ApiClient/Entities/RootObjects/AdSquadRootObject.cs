using System.Collections.Generic;
using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents root object for <see cref="Adsquad"/>.
    /// </summary>
    public class AdSquadRootObject : RootObject<AdsquadWrapper, Adsquad>
    {
        /// <inheritdoc/>
        [JsonProperty("adsquads")]
#pragma warning disable CA2227 // Collection properties should be read only
        public override List<AdsquadWrapper> WrapperCollection { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
