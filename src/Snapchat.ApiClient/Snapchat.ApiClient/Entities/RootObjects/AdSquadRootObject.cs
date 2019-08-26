using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;
using System.Collections.Generic;

namespace Snapchat.ApiClient
{
    public class AdSquadRootObject : RootObject<AdsquadWrapper, Adsquad>
    {
        [JsonProperty("adsquads")]
#pragma warning disable CA2227 // Collection properties should be read only
        public override List<AdsquadWrapper> WrapperCollection { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
