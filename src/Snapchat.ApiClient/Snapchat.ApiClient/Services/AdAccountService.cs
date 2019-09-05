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
    /// Provides methods to do ad account level operation on Snapchat API.
    /// </summary>
    internal class AdAccountService : BaseService, IAdAccountService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdAccountService"/> class.
        /// </summary>
        /// <param name="authenticationService">Instance of <see cref="AuthenticationService"/>.</param>
        internal AdAccountService(AuthenticationService authenticationService)
            : base(authenticationService)
        {
        }

        /// <inheritdoc/>
        public Adaccount GetByAccountId(string accountId)
        {
            var request = new RestRequest("/adaccounts/{adaccount_id}", Method.GET);
            request.AddUrlSegment("adaccount_id", accountId);

            var response = Execute<AdAccountRootObject>(request);

            var result = Extract<AdAccountRootObject, AdaccountWrapper, Adaccount>(response);

            return result.FirstOrDefault();
        }

        /// <inheritdoc/>
        public IEnumerable<Adaccount> GetByOrganizationId(string organizationId, PagingOption pagingOption)
        {
#pragma warning disable SA1305 // Field names should not use Hungarian notation
            var adAccounts = ExecutePagedRequest<AdAccountRootObject, AdaccountWrapper, Adaccount>($"/organizations/{organizationId}/adaccounts", pagingOption);
#pragma warning restore SA1305 // Field names should not use Hungarian notation

            return adAccounts;
        }
    }
}
