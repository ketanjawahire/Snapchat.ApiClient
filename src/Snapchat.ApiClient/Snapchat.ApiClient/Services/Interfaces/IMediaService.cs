using System.Collections.Generic;
using Snapchat.ApiClient.Entities.Api;

namespace Snapchat.ApiClient.Services.Interfaces
{
    /// <summary>
    /// Provides methods to do media level operation on Snapchat API.
    /// </summary>
    public interface IMediaService : IApiService
    {
        /// <summary>
        /// Gets media thumbnail by id.
        /// </summary>
        /// <param name="mediaId">media id.</param>
        /// <returns>thumbnail object.</returns>
#pragma warning disable CA1716 // Identifiers should not match keywords
        Thumbnail Get(string mediaId);
#pragma warning restore CA1716 // Identifiers should not match keywords

        /// <summary>
        /// Gets media under given ad account.
        /// </summary>
        /// <param name="id">Ad a ccount id.</param>
        /// <param name="pagingOption">API Paging options.</param>
        /// <returns>List of all media under given ad account.</returns>
        IEnumerable<CreativeMedia> GetByAdAccountId(string id, PagingOption pagingOption);
    }
}
