using Snapchat.ApiClient.Entities.Api;
using System.Collections.Generic;

namespace Snapchat.ApiClient.Services.Interfaces
{
    public interface IAdAccountService : IApiService
    {
        IEnumerable<Adaccount> GetByOrganizationId(string organizationId, PagingOption pagingOption);

        Adaccount GetByAccountId(string accountId);
    }
}
