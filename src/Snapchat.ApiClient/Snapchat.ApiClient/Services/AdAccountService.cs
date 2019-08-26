using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Snapchat.ApiClient
{
    public class AdAccountService : BaseService, IAdAccountService
    {
        public AdAccountService(AuthenticationService authenticationService) : base(authenticationService)
        {

        }

        public Adaccount GetByAccountId(string accountId)
        {
            var request = new RestRequest("/adaccounts/{adaccount_id}", Method.GET);
            request.AddUrlSegment("adaccount_id", accountId);

            var response = Execute<AdAccountRootObject>(request);

            var result = Extract(response);

            return result.FirstOrDefault();
        }

        public IEnumerable<Adaccount> GetByOrganizationId(string organizationId, PagingOption pagingOption)
        {
            if (pagingOption is null)
            {
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                throw new ArgumentNullException(nameof(pagingOption), Constants.INVALID_PAGEOPTIONS);
#pragma warning restore CA1303 // Do not pass literals as localized parameters
            }

            List<Adaccount> adAccounts = null;
            var url = "/organizations/{organization_id}/adaccounts";
            var counter = 0;
            do
            {
                var request = new RestRequest(url, Method.GET);
                request.AddUrlSegment("organization_id", organizationId);
                request.AddQueryParameter("limit", pagingOption.Limit.ToString(CultureInfo.InvariantCulture));

                var response = Execute<AdAccountRootObject>(request);
                var tmpResult = Extract(response);

                if (!tmpResult.Any())
                    break;

                if (adAccounts == null)
                    adAccounts = new List<Adaccount>();

                adAccounts.AddRange(tmpResult);

                if (string.IsNullOrEmpty(response.Paging.NextLink))
                    break;

                url = GetRestReqestUrlFromPagingUrl(response.Paging.NextLink);
                counter++;
            } while (counter < pagingOption.NumberOfPages);

            return adAccounts;
        }

        //TODO : move to generic method
        private static IEnumerable<Adaccount> Extract(AdAccountRootObject rootObject)
        {
            return rootObject.WrapperCollection.Select(e => e.Entity);
        }
    }
}
