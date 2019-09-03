using RestSharp;
using Snapchat.ApiClient.Entities.Api;
using Snapchat.ApiClient.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Snapchat.ApiClient.Services
{
    internal class AdAccountService : BaseService, IAdAccountService
    {
        internal AdAccountService(AuthenticationService authenticationService) : base(authenticationService)
        {

        }

        public Adaccount GetByAccountId(string accountId)
        {
            var request = new RestRequest("/adaccounts/{adaccount_id}", Method.GET);
            request.AddUrlSegment("adaccount_id", accountId);

            var response = Execute<AdAccountRootObject>(request);

            var result = Extract<AdAccountRootObject, AdaccountWrapper, Adaccount>(response);

            return result.FirstOrDefault();
        }

        public IEnumerable<Adaccount> GetByOrganizationId(string organizationId, PagingOption pagingOption)
        {
            var adAccounts = ExecutePagedRequest<AdAccountRootObject, AdaccountWrapper, Adaccount>($"/organizations/{organizationId}/adaccounts", pagingOption);

            return adAccounts;
        }
    }
}
