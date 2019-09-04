using System.Collections.Generic;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient.Services.Interfaces
{
    /// <summary>
    /// Provides methods to do ad level operation on Snapchat API.
    /// </summary>
    public interface IAdService : IApiService
    {
#pragma warning disable CA1716 // Identifiers should not match keywords
        /// <summary>
        /// Gets ad by id.
        /// </summary>
        /// <param name="id">Ad id.</param>
        /// <returns>Ad object.</returns>
        Ad Get(string id);
#pragma warning restore CA1716 // Identifiers should not match keywords

        /// <summary>
        /// Gets all ads for given ad sqad.
        /// </summary>
        /// <param name="id">Ad squad id.</param>
        /// <param name="pagingOption">API Paging options.</param>
        /// <returns>List of all ads under given ad squad.</returns>
        IEnumerable<Ad> GetByAdSquadId(string id, PagingOption pagingOption);

        /// <summary>
        /// Gets all ads under given ad account.
        /// </summary>
        /// <param name="id">Ad account id.</param>
        /// <param name="pagingOption">API Paging options.</param>
        /// <returns>List of all ads under given ad account.</returns>
        IEnumerable<Ad> GetByAdAccountId(string id, PagingOption pagingOption);
    }
}
