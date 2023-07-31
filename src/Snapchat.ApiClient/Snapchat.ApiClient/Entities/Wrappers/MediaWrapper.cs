using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient.Entities.Wrappers
{
    /// <summary>
    /// Represents wrapper for <see cref="CreativeMedia"/>.
    /// </summary>
    public class MediaWrapper : BaseWrapper<CreativeMedia>
    {
        /// <inheritdoc/>
        [JsonProperty("media")]
        public override CreativeMedia Entity { get; set; }
    }
}
