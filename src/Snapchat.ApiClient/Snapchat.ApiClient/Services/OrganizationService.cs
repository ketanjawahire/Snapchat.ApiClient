using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using RestSharp;
using Snapchat.ApiClient.Entities.Api;
using Snapchat.ApiClient.Services.Interfaces;

namespace Snapchat.ApiClient.Services
{
    /// <summary>
    /// Provides methods to do organization level operation on Snapchat API.
    /// </summary>
    internal class OrganizationService : BaseService, IOrganizationService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationService"/> class.
        /// </summary>
        /// <param name="authenticationService">Instance of <see cref="AuthenticationService"/>.</param>
        internal OrganizationService(AuthenticationService authenticationService)
            : base(authenticationService)
        {
        }

        /// <inheritdoc/>
        public IEnumerable<Organization> Get(PagingOption pagingOption)
        {
            var organizations = ExecutePagedRequest<OrganizationRootObject, OrganizationWrapper, Organization>("/me/organizations", pagingOption);

            return organizations;
        }

        /// <inheritdoc/>
        public Organization GetById(string organizationId)
        {
            var request = new RestRequest("/organizations/{organization_id}", Method.GET);
            var response = Execute<OrganizationRootObject>(request);
            var result = Extract<OrganizationRootObject, OrganizationWrapper, Organization>(response);

            return result.FirstOrDefault();
        }
    }
}
