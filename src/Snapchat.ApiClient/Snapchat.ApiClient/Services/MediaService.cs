using RestSharp;
using Snapchat.ApiClient.Entities.Api;
using Snapchat.ApiClient.Entities.RootObjects;
using Snapchat.ApiClient.Entities.Wrappers;
using Snapchat.ApiClient.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snapchat.ApiClient.Services
{
    /// <summary>
    /// Provides methods to do media level operation on Snapchat API.
    /// </summary>
    internal class MediaService : BaseService, IMediaService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaService"/> class.
        /// </summary>
        /// <param name="authService">Instance of <see cref="AuthenticationService"/>.</param>
        internal MediaService(AuthenticationService authService)
            : base(authService)
        {
        }

        /// <inheritdoc/>
        public Thumbnail Get(string mediaId)
        {
            var request = new RestRequest("/media/{media_id}/thumbnail", Method.GET);
            request.AddUrlSegment("media_id", mediaId);

            var response = Execute<Thumbnail>(request);

            return response;
        }

        /// <inheritdoc/>
        public IEnumerable<CreativeMedia> GetByAdAccountId(string adAccountId, PagingOption pagingOption)
        {
            var media = ExecutePagedRequest<MediaRootObject, MediaWrapper, CreativeMedia>($"/adaccounts/{adAccountId}/media ", pagingOption);

            return media;
        }
    }
}
