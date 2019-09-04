using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents root object for <see cref="Adaccount"/>.
    /// </summary>
    public class AdAccountRootObject : RootObject<AdaccountWrapper, Adaccount>
    {
        /// <inheritdoc/>
        [JsonProperty("adaccounts")]
#pragma warning disable CA2227 // Collection properties should be read only
        public override List<AdaccountWrapper> WrapperCollection { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
