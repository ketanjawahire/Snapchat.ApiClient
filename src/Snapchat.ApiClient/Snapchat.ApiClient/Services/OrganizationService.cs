using RestSharp;
using Snapchat.ApiClient.Entities.Api;
using Snapchat.ApiClient.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Snapchat.ApiClient.Services
{
    public class OrganizationService : BaseService, IOrganizationService
    {
        public OrganizationService(AuthenticationService authenticationService) : base(authenticationService)
        {
        }

        public IEnumerable<Organization> Get(PagingOption pagingOption)
        {
            var organizations = ExecutePagedRequest<OrganizationRootObject, OrganizationWrapper, Organization>("/me/organizations", pagingOption);

            return organizations;
        }

        public Organization GetById(string organizationId)
        {
            var request = new RestRequest("/organizations/{organization_id}", Method.GET);
            var response = Execute<OrganizationRootObject>(request);
            var result = Extract<OrganizationRootObject, OrganizationWrapper, Organization>(response);

            return result.FirstOrDefault();
        }
    }

}
