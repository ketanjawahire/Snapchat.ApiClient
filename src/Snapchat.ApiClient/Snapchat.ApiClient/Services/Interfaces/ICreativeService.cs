using System.Collections.Generic;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient.Services.Interfaces
{
    /// <summary>
    /// Provides methods to do cretive level operation on Snapchat API.
    /// </summary>
    public interface ICreativeService : IApiService
    {
#pragma warning disable CA1716 // Identifiers should not match keywords
        /// <summary>
        /// Gets creative by id.
        /// </summary>
        /// <param name="creativeId">Creative id.</param>
        /// <returns>Creative object.</returns>
        Creative Get(string creativeId);
#pragma warning restore CA1716 // Identifiers should not match keywords

        /// <summary>
        /// Gets creatives under given ad account.
        /// </summary>
        /// <param name="id">Ad a ccount id.</param>
        /// <param name="pagingOption">API Paging options.</param>
        /// <returns>List of all creatives under given ad account.</returns>
        IEnumerable<Creative> GetByAdAccountId(string id, PagingOption pagingOption);
    }
}
