using System.Collections.Generic;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient.Services.Interfaces
{
    /// <summary>
    /// Provides methods to do ad account level operation on Snapchat API.
    /// </summary>
    public interface IAdAccountService : IApiService
    {
        /// <summary>
        /// Gets all ad accounts for given organization id.
        /// </summary>
        /// <param name="organizationId">Organization id.</param>
        /// <param name="pagingOption">API Paging options.</param>
        /// <returns>List of ad account.</returns>
        IEnumerable<Adaccount> GetByOrganizationId(string organizationId, PagingOption pagingOption);

        /// <summary>
        /// Gets ad account by id.
        /// </summary>
        /// <param name="accountId">Ad account id.</param>
        /// <returns>Ad account object.</returns>
        Adaccount GetByAccountId(string accountId);
    }
}
