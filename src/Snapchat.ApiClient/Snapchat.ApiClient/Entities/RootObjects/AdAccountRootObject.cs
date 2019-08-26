using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Snapchat.ApiClient
{
    public partial class AdAccountRootObject : RootObject<AdaccountWrapper, Adaccount>
    {
        [JsonProperty("adaccounts")]
#pragma warning disable CA2227 // Collection properties should be read only
        public override List<AdaccountWrapper> WrapperCollection { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
