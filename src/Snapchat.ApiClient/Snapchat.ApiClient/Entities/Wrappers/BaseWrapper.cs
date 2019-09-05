using Newtonsoft.Json;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents wrapper for <typeparamref name="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity">Any object of type <see cref="IEntity"/>.</typeparam>
    public abstract class BaseWrapper<TEntity> : IWrapper<TEntity>
        where TEntity : IEntity
    {
        /// <inheritdoc/>
        [JsonProperty("sub_request_status")]
        public string SubRequestStatus { get; set; }

        /// <inheritdoc/>
        public abstract TEntity Entity { get; set; }
    }
}
