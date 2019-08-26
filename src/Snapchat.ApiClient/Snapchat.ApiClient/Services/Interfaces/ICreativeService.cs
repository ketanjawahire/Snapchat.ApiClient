using Snapchat.ApiClient.Entities.Api;
using System.Collections.Generic;

namespace Snapchat.ApiClient.Services.Interfaces
{
    public interface ICreativeService : IApiService
    {
#pragma warning disable CA1716 // Identifiers should not match keywords
        Creative Get(string creativeId);
#pragma warning restore CA1716 // Identifiers should not match keywords
        IEnumerable<Creative> GetByAdAccountId(string adAccountId, PagingOption pagingOption);
    }
}
