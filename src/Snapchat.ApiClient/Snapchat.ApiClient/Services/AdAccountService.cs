using RestSharp;
using System.Collections.Generic;
using System.Linq;

namespace Snapchat.ApiClient
{
    public class AdAccountService : BaseService, IAdAccountService
    {
        public AdAccountService(AuthenticationService authenticationService) : base(authenticationService)
        {

        }

        public AdAccountRootObject GetByOrganizationId(string organizationId)
        {
            var request = new RestRequest("/organizations/{organization_id}/adaccounts", Method.GET);
            request.AddUrlSegment("organization_id", organizationId);

            var response = Execute<AdAccountRootObject>(request);

            return response;
        }
    }
}
