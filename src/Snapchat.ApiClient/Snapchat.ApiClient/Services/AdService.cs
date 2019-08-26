using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Snapchat.ApiClient.Services;

namespace Snapchat.ApiClient
{
    internal class AdService : BaseService, IAdService
    {
        public AdService(AuthenticationService authService) : base(authService)
        {
        }

        public Ad Get(string adId)
        {
            var request = new RestRequest("/ads/{ad_id}", Method.GET);
            request.AddUrlSegment("ad_id", adId);

            var response = Execute<AdRootObject>(request);

            var result = Extract<AdRootObject, AdWrapper, Ad>(response);

            return result.FirstOrDefault();
        }

        public IEnumerable<Ad> GetByAdAccountId(string adAccountId, PagingOption pagingOption)
        {
            var ads = ExecutePagedRequest<AdRootObject, AdWrapper, Ad>($"/adaccounts/{adAccountId}/ads", pagingOption);

            return ads;
        }

        public IEnumerable<Ad> GetByAdSquadId(string adsquadId, PagingOption pagingOption)
        {
            var ads = ExecutePagedRequest<AdRootObject, AdWrapper, Ad>($"/adsquads/{adsquadId}/ads", pagingOption);

            return ads;
        }
    }
}