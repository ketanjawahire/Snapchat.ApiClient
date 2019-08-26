using System.Collections.Generic;

namespace Snapchat.ApiClient
{
    public interface ICampaignService : IApiService
    {
        Campaign GetById(string campaignId);
        IEnumerable<Campaign> GetByAccountId(string adAccountId, PagingOption pagingOption);
        IEnumerable<Campaign> GetByAccountId(string adAccountId);
    }

}
