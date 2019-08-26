using Newtonsoft.Json;
using System.Collections.Generic;

namespace Snapchat.ApiClient.Entities.Api
{
    //TODO : complete class structure
    public class Targeting
    {
        [JsonProperty("geos", NullValueHandling = NullValueHandling.Ignore)]
#pragma warning disable CA2227 // Collection properties should be read only
        public List<Geo> Geos { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
