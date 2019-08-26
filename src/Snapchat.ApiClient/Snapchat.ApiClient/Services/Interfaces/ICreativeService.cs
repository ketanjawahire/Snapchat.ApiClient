using System.Collections.Generic;

namespace Snapchat.ApiClient.Services
{
    public interface ICreativeService : IApiService
    {
#pragma warning disable CA1716 // Identifiers should not match keywords
        Creative Get(string creativeId);
#pragma warning restore CA1716 // Identifiers should not match keywords
        IEnumerable<Creative> GetByAdAccountId(string adAccountId, PagingOption pagingOption);
    }
}
