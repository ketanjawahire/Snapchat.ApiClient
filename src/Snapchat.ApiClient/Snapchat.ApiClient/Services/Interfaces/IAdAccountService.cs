using System.Collections.Generic;

namespace Snapchat.ApiClient
{
    public interface IAdAccountService : IApiService
    {
        IEnumerable<Adaccount> GetByOrganizationId(string organizationId, PagingOption pagingOption);

        Adaccount GetByAccountId(string accountId);
    }
}
