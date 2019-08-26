using Snapchat.ApiClient.Entities.Api;
using System.Collections.Generic;

namespace Snapchat.ApiClient
{
    public class AdRootObject : RootObject<AdWrapper, Ad>
    {
#pragma warning disable CA2227 // Collection properties should be read only
        public override List<AdWrapper> WrapperCollection { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }

}
