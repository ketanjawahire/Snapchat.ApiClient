using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Snapchat.ApiClient.Entities.Api;
using Snapchat.ApiClient.Services.Interfaces;

namespace Snapchat.ApiClient.Services
{
    /// <summary>
    /// Provides methods to do ad level operation on Snapchat API.
    /// </summary>
    internal class AdService : BaseService, IAdService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdService"/> class.
        /// </summary>
        /// <param name="authService">Instance of <see cref="AuthenticationService"/>.</param>
        internal AdService(AuthenticationService authService)
            : base(authService)
        {
        }

        /// <inheritdoc/>
        public Ad Get(string adId)
        {
            var request = new RestRequest("/ads/{ad_id}", Method.GET);
            request.AddUrlSegment("ad_id", adId);

            request.AddParameter("read_deleted_entities", true);

            var response = Execute<AdRootObject>(request);

            var result = Extract<AdRootObject, AdWrapper, Ad>(response);

            return result.FirstOrDefault();
        }

        /// <inheritdoc/>
        public IEnumerable<Ad> GetByAdAccountId(string adAccountId, PagingOption pagingOption)
        {
            var ads = ExecutePagedRequest<AdRootObject, AdWrapper, Ad>($"/adaccounts/{adAccountId}/ads", pagingOption);

            return ads;
        }

        /// <inheritdoc/>
        public IEnumerable<Ad> GetByAdSquadId(string adsquadId, PagingOption pagingOption)
        {
            var ads = ExecutePagedRequest<AdRootObject, AdWrapper, Ad>($"/adsquads/{adsquadId}/ads", pagingOption);

            return ads;
        }
    }
}