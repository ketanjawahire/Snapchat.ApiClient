using Newtonsoft.Json;
using Snapchat.ApiClient.Entities.Api;
using System.Collections.Generic;
using System.Linq;

namespace Snapchat.ApiClient
{
    public abstract class RootObject<TWrapper, TEntity> : IRootObject<TWrapper, TEntity> where TWrapper : IWrapper<TEntity> where TEntity : IEntity 
    {
        [JsonProperty("request_status")]
        public string RequestStatus { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
#pragma warning disable CA2227 // Collection properties should be read only
        public abstract List<TWrapper> WrapperCollection { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
