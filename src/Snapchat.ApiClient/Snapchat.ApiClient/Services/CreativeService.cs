using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Snapchat.ApiClient.Entities.Api;
using Snapchat.ApiClient.Services.Interfaces;

namespace Snapchat.ApiClient.Services
{
    internal class CreativeService : BaseService, ICreativeService
    {
        public CreativeService(AuthenticationService authService) : base(authService)
        {
        }

        public Creative Get(string creativeId)
        {
            var request = new RestRequest("/creatives/{creative_id}", Method.GET);
            request.AddUrlSegment("creative_id", creativeId);

            var response = Execute<CreativeRootObject>(request);

            var result = Extract<CreativeRootObject, CreativeWrapper, Creative>(response);

            return result.FirstOrDefault();
        }

        public IEnumerable<Creative> GetByAdAccountId(string adAccountId, PagingOption pagingOption)
        {
            var creatives = ExecutePagedRequest<CreativeRootObject, CreativeWrapper, Creative>($"/adaccounts/{adAccountId}/creatives", pagingOption);

            return creatives;
        }
    }
}