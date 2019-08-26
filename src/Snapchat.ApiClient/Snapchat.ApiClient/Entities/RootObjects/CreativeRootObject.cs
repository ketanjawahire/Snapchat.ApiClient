using Newtonsoft.Json;
using System.Collections.Generic;

namespace Snapchat.ApiClient
{
    public class CreativeRootObject : RootObject<CreativeWrapper, Creative>
    {
        [JsonProperty("creatives")]
#pragma warning disable CA2227 // Collection properties should be read only
        public override List<CreativeWrapper> WrapperCollection  { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
