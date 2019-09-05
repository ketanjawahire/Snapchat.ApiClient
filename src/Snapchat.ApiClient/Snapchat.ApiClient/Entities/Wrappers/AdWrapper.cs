using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents wrapper for <see cref="Ad"/>.
    /// </summary>
    public class AdWrapper : BaseWrapper<Ad>
    {
        /// <inheritdoc/>
        [JsonProperty("ad")]
        public override Ad Entity { get; set; }
    }
}
