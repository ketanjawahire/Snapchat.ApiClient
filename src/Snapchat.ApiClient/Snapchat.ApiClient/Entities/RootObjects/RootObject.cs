using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient
{
    /// <inheritdoc/>
    public abstract class RootObject<TWrapper, TEntity> : IRootObject<TWrapper, TEntity>
        where TWrapper : IWrapper<TEntity>
        where TEntity : IEntity
    {
        /// <inheritdoc/>
        [JsonProperty("request_status")]
        public string RequestStatus { get; set; }

        /// <inheritdoc/>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <inheritdoc/>
        [JsonProperty("paging")]
        public Paging Paging { get; set; }
#pragma warning disable CA2227 // Collection properties should be read only

        /// <inheritdoc/>
        public abstract List<TWrapper> WrapperCollection { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
