using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Snapchat.ApiClient
{
    public class OrganizationService : BaseService, IOrganizationService
    {
        public OrganizationService (AuthenticationService authenticationService) : base(authenticationService)
        {

        }

        public IEnumerable<Organization> Get(PagingOption pagingOption)
        {
            if (pagingOption is null)
            {
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                throw new ArgumentNullException(nameof(pagingOption), Constants.INVALID_PAGEOPTIONS);
#pragma warning restore CA1303 // Do not pass literals as localized parameters
            }

            List<Organization> organizations = null;
            var url = "/me/organizations";
            var counter = 0;
            do
            {
                var request = new RestRequest(url, Method.GET);
                request.AddQueryParameter("limit", pagingOption.Limit.ToString(CultureInfo.InvariantCulture));

                var response = Execute<OrganizationRootObject>(request);
                var tmpResult = Extract(response);

                if (!tmpResult.Any())
                    break;

                if (organizations == null)
                    organizations = new List<Organization>();

                organizations.AddRange(tmpResult);

                if (string.IsNullOrEmpty(response.Paging.NextLink))
                    break;

                url = GetRestReqestUrlFromPagingUrl(response.Paging.NextLink);
                counter++;
            } while (counter < pagingOption.NumberOfPages);

            return organizations;
        }

        public Organization GetById(string organizationId)
        {
            var request = new RestRequest("/organizations/{organization_id}", Method.GET);
            var response = Execute<OrganizationRootObject>(request);
            var result = Extract(response);

            return result.FirstOrDefault();
        }

        //TODO : move to generic method
        private static IEnumerable<Organization> Extract(OrganizationRootObject rootObject)
        {
            return rootObject.WrapperCollection.Select(e => e.Entity);
        }
    }

}
