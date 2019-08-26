using RestSharp;

namespace Snapchat.ApiClient
{
    public class OrganizationService : BaseService, IOrganizationService
    {
        public OrganizationService (AuthenticationService authenticationService) : base(authenticationService)
        {

        }

        public OrganizationRootObject Get()
        {
            var request = new RestRequest("/me/organizations", Method.GET);

            var response = Execute<OrganizationRootObject>(request);

            return response;
        }
    }

}
