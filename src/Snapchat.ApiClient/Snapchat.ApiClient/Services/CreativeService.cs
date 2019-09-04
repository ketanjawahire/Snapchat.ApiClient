using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Snapchat.ApiClient.Entities.Api;
using Snapchat.ApiClient.Services.Interfaces;

namespace Snapchat.ApiClient.Services
{
    /// <summary>
    /// Provides methods to do cretive level operation on Snapchat API.
    /// </summary>
    internal class CreativeService : BaseService, ICreativeService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreativeService"/> class.
        /// </summary>
        /// <param name="authService">Instance of <see cref="AuthenticationService"/>.</param>
        internal CreativeService(AuthenticationService authService)
            : base(authService)
        {
        }

        /// <inheritdoc/>
        public Creative Get(string creativeId)
        {
            var request = new RestRequest("/creatives/{creative_id}", Method.GET);
            request.AddUrlSegment("creative_id", creativeId);

            var response = Execute<CreativeRootObject>(request);

            var result = Extract<CreativeRootObject, CreativeWrapper, Creative>(response);

            return result.FirstOrDefault();
        }

        /// <inheritdoc/>
        public IEnumerable<Creative> GetByAdAccountId(string adAccountId, PagingOption pagingOption)
        {
            var creatives = ExecutePagedRequest<CreativeRootObject, CreativeWrapper, Creative>($"/adaccounts/{adAccountId}/creatives", pagingOption);

            return creatives;
        }
    }
}