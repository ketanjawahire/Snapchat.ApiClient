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
            if (pagingOption is null)
            {
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                throw new ArgumentNullException(nameof(pagingOption), Constants.INVALID_PAGEOPTIONS);
#pragma warning restore CA1303 // Do not pass literals as localized parameters
            }

            List<Campaign> campaigns = null;
            var url = "/adaccounts/{adaccount_id}/campaigns";
            var counter = 0;
            do
            {
                var request = new RestRequest(url, Method.GET);
                request.AddUrlSegment("adaccount_id", adAccountId);
                request.AddQueryParameter("limit", pagingOption.Limit.ToString(CultureInfo.InvariantCulture));

                var response = Execute<CampaignRootObject>(request);
                var tmpCampaigns = Extract(response);

                if (!tmpCampaigns.Any())
                    break;

                if (campaigns == null)
                    campaigns = new List<Campaign>();

                campaigns.AddRange(tmpCampaigns);

                if (string.IsNullOrEmpty(response.Paging.NextLink))
                    break;

                url = GetRestReqestUrlFromPagingUrl(response.Paging.NextLink);
                counter++;
            } while (counter < pagingOption.NumberOfPages);

            return campaigns;
        }


        public IEnumerable<Campaign> GetByAccountId(string adAccountId)
        {
            var request = new RestRequest("/adaccounts/{adaccount_id}/campaigns", Method.GET);
            request.AddUrlSegment("adaccount_id", adAccountId);

            var response = Execute<CampaignRootObject>(request);
            var campaigns = Extract(response);

            return campaigns;
        }

        public Campaign GetById(string campaignId)
        {
            var request = new RestRequest("/campaigns/{campaign_id}", Method.GET);
            request.AddUrlSegment("campaign_id", campaignId);

            var response = Execute<CampaignRootObject>(request);
            var campaigns = Extract(response);

            return campaigns.FirstOrDefault();
        }

        //TODO : move to generic method
        private static IEnumerable<Campaign> Extract(CampaignRootObject rootObject)
        {
            return rootObject.WrapperCollection.Select(e => e.Entity);
        }
    }

}
