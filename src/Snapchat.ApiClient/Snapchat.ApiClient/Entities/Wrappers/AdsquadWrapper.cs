using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents wrapper for <see cref="Adsquad"/>.
    /// </summary>
    public class AdsquadWrapper : BaseWrapper<Adsquad>
    {
        /// <inheritdoc/>
        [JsonProperty("adsquad")]
        public override Adsquad Entity { get; set; }
    }
}
