using System.Collections.Generic;
using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;
using Snapchat.ApiClient.Entities.Wrappers;

namespace Snapchat.ApiClient.Entities.RootObjects
{
    /// <summary>
    /// Represents root object for <see cref="CreativeMedia"/>.
    /// </summary>
    public class MediaRootObject : RootObject<MediaWrapper, CreativeMedia>
    {
        /// <inheritdoc/>
        [JsonProperty("media")]
#pragma warning disable CA2227 // Collection properties should be read only
        public override List<MediaWrapper> WrapperCollection { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
