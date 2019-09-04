using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents wrapper for <see cref="Creative"/>.
    /// </summary>
    public class CreativeWrapper : BaseWrapper<Creative>
    {
        /// <inheritdoc/>
        [JsonProperty("creative")]
        public override Creative Entity { get; set; }
    }
}
