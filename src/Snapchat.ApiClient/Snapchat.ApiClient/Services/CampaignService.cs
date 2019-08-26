using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using RestSharp;

namespace Snapchat.ApiClient
{
    public class CampaignService : BaseService, ICampaignService
    {
        public CampaignService(AuthenticationService authenticationService) : base(authenticationService)
        {
        }

        public IEnumerable<Campaign> GetByAccountId(string adAccountId, PagingOption pagingOption)
        {
            var campaigns = ExecutePagedRequest<CampaignRootObject, CampaignWrapper, Campaign>($"/adaccounts/{adAccountId}/campaigns", pagingOption);

            return campaigns;
        }

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
