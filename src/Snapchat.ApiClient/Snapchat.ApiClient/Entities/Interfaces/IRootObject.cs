using Snapchat.ApiClient.Entities.Api;
using System.Collections.Generic;

namespace Snapchat.ApiClient
{
    public interface IRootObject <TWrapper, TEntity> where TWrapper : IWrapper<TEntity> where TEntity  : IEntity 
    {
        string RequestStatus { get; set; }
        string RequestId { get; set; }
        Paging Paging { get; set; }
#pragma warning disable CA2227 // Collection properties should be read only
        List<TWrapper> WrapperCollection { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
    }
}
