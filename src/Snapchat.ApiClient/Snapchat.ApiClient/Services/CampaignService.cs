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
    /// Provides methods to do campaign level operation on Snapchat API.
    /// </summary>
    internal class CampaignService : BaseService, ICampaignService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignService"/> class.
        /// </summary>
        /// <param name="authenticationService">Instance of <see cref="AuthenticationService"/>.</param>
        internal CampaignService(AuthenticationService authenticationService)
            : base(authenticationService)
        {
        }

        /// <inheritdoc/>
        public IEnumerable<Campaign> GetByAccountId(string adAccountId, PagingOption pagingOption)
        {
            var campaigns = ExecutePagedRequest<CampaignRootObject, CampaignWrapper, Campaign>($"/adaccounts/{adAccountId}/campaigns", pagingOption);

            return campaigns;
        }

        /// <inheritdoc/>
        public Campaign GetById(string campaignId)
        {
            var request = new RestRequest("/campaigns/{campaign_id}", Method.GET);
            request.AddUrlSegment("campaign_id", campaignId);

            var response = Execute<CampaignRootObject>(request);
            var campaigns = Extract<CampaignRootObject, CampaignWrapper, Campaign>(response);

            return campaigns.FirstOrDefault();
        }
    }
}
