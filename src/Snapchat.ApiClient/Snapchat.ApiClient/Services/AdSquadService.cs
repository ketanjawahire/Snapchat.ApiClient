using System;
using System.Collections.Generic;
using System.Text;

namespace Snapchat.ApiClient.Services
{
    public class AdSquadService : BaseService, IAdSquadService
    {
        public AdSquadService(AuthenticationService authenticationService) : base(authenticationService)
        {
        }

        public Adsquad Get(string adsquaqId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Adsquad> GetByAdAccountId(string accountId, PagingOption pagingOption)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Adsquad> GetByCampaignId(string campaignId, PagingOption pagingOption)
        {
            throw new NotImplementedException();
        }
    }
}
