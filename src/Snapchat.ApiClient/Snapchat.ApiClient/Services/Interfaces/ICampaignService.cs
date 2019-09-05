using System.Collections.Generic;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient.Services.Interfaces
{
    /// <summary>
    /// Provides methods to do campaign level operation on Snapchat API.
    /// </summary>
    public interface ICampaignService : IApiService
    {
        /// <summary>
        /// Gets campaigns by id.
        /// </summary>
        /// <param name="campaignId">Campaign id.</param>
        /// <returns>Campaign object.</returns>
        Campaign GetById(string campaignId);

        /// <summary>
        /// Gets campaigns under given ad account.
        /// </summary>
        /// <param name="id">Ad account id.</param>
        /// <param name="pagingOption">API paging options.</param>
        /// <returns>List of all campaigns under given ad account.</returns>
        IEnumerable<Campaign> GetByAccountId(string id, PagingOption pagingOption);
    }
}