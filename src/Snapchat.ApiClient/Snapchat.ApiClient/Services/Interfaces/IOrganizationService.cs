using System.Collections.Generic;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient.Services.Interfaces
{
    /// <summary>
    /// Provides methods to do organization level operation on Snapchat API.
    /// </summary>
    public interface IOrganizationService : IApiService
    {
        /// <summary>
        /// Gets organization by id.
        /// </summary>
        /// <param name="organizationId">Organization id.</param>
        /// <returns>Organization object.</returns>
        Organization GetById(string organizationId);

        /// <summary>
        /// Gets all organization for given user.
        /// </summary>
        /// <param name="pagingOption">API paging options.</param>
        /// <returns>List of organizations.</returns>
#pragma warning disable CA1716 // Identifiers should not match keywords
        IEnumerable<Organization> Get(PagingOption pagingOption);
#pragma warning restore CA1716 // Identifiers should not match keywords
    }
}
