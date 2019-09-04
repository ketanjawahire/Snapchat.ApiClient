using System.Collections.Generic;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient.Services.Interfaces
{
    /// <summary>
    /// Provides methods to do ad squad level operation on Snapchat API.
    /// </summary>
    public interface IAdSquadService : IApiService
    {
#pragma warning disable CA1716 // Identifiers should not match keywords
        /// <summary>
        /// Gets ad squad by id.
        /// </summary>
        /// <param name="adsquaqId">Ad suqad id.</param>
        /// <returns>Ad suqad object.</returns>
        Adsquad Get(string adsquaqId);
#pragma warning restore CA1716 // Identifiers should not match keywords

        /// <summary>
        /// Gets all ad squads for given campaign.
        /// </summary>
        /// <param name="id">Campaign id.</param>
        /// <param name="pagingOption">API paging options.</param>
        /// <returns>List of ad squads under given campaign.</returns>
        IEnumerable<Adsquad> GetByCampaignId(string id, PagingOption pagingOption);

        /// <summary>
        /// Gets all ad squads for given ad account.
        /// </summary>
        /// <param name="id">Ad account id.</param>
        /// <param name="pagingOption">API paging options.</param>
        /// <returns>List of ad squads under given ad account.</returns>
        IEnumerable<Adsquad> GetByAdAccountId(string id, PagingOption pagingOption);
    }
}
