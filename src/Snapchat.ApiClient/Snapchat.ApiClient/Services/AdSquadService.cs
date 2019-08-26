using RestSharp;
using Snapchat.ApiClient.Entities.Api;
using Snapchat.ApiClient.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var request = new RestRequest("/adsquads/{adsquad_id}", Method.GET);
            request.AddUrlSegment("adsquad", adsquaqId);

            var response = Execute<AdSquadRootObject>(request);

            var result = Extract<AdSquadRootObject, AdsquadWrapper, Adsquad>(response);

            return result.FirstOrDefault();
        }

        public IEnumerable<Adsquad> GetByAdAccountId(string adAccountId, PagingOption pagingOption)
        {
            var adSquads = ExecutePagedRequest<AdSquadRootObject, AdsquadWrapper, Adsquad>($"/adaccounts/{adAccountId}/adsquads", pagingOption);

            return adSquads;
        }

        public IEnumerable<Adsquad> GetByCampaignId(string campaignId, PagingOption pagingOption)
        {
            var adSquads = ExecutePagedRequest<AdSquadRootObject, AdsquadWrapper, Adsquad>($"/campaigns/{campaignId}/adsquads", pagingOption);

            return adSquads;
        }
    }
}
