using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents wrapper for <see cref="Adaccount"/>.
    /// </summary>
    public class AdaccountWrapper : BaseWrapper<Adaccount>
    {
        /// <inheritdoc/>
        [JsonProperty("adaccount")]
        public override Adaccount Entity { get; set; }
    }
}
