using System.Collections.Generic;

namespace Snapchat.ApiClient.Services
{
    public interface IAdSquadService : IApiService
    {
#pragma warning disable CA1716 // Identifiers should not match keywords
        Adsquad Get(string adsquaqId);
#pragma warning restore CA1716 // Identifiers should not match keywords
        IEnumerable<Adsquad> GetByCampaignId(string campaignId, PagingOption pagingOption);
        IEnumerable<Adsquad> GetByAdAccountId(string adAccountId, PagingOption pagingOption);
    }
}
