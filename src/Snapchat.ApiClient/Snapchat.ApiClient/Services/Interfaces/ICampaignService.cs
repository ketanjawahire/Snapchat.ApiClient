using Snapchat.ApiClient.Entities.Api;
using System.Collections.Generic;

namespace Snapchat.ApiClient.Services.Interfaces
{
    public interface ICampaignService : IApiService
    {
        Campaign GetById(string campaignId);
        IEnumerable<Campaign> GetByAccountId(string adAccountId, PagingOption pagingOption);
    }

}
