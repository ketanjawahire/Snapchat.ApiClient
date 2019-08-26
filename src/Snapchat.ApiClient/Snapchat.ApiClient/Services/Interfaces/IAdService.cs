using Snapchat.ApiClient.Entities.Api;
using System.Collections.Generic;

namespace Snapchat.ApiClient.Services.Interfaces
{
    public interface IAdService : IApiService
    {
#pragma warning disable CA1716 // Identifiers should not match keywords
        Ad Get(string adId);
#pragma warning restore CA1716 // Identifiers should not match keywords
        IEnumerable<Ad> GetByAdSquadId(string adsquadId, PagingOption pagingOption);
        IEnumerable<Ad> GetByAdAccountId(string adAccountId, PagingOption pagingOption);
    }
}
