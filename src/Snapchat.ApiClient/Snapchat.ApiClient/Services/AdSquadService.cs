using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using Snapchat.ApiClient.Entities.Api;
using Snapchat.ApiClient.Services.Interfaces;

namespace Snapchat.ApiClient.Services
{
    /// <summary>
    /// Provides methods to do ad squad level operation on Snapchat API.
    /// </summary>
    internal class AdSquadService : BaseService, IAdSquadService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdSquadService"/> class.
        /// </summary>
        /// <param name="authenticationService">Instance of <see cref="AuthenticationService"/>.</param>
        internal AdSquadService(AuthenticationService authenticationService)
            : base(authenticationService)
        {
        }

        /// <inheritdoc/>
        public Adsquad Get(string adsquaqId)
        {
            var request = new RestRequest("/adsquads/{adsquad_id}", Method.GET);
            request.AddUrlSegment("adsquad_id", adsquaqId);

            var response = Execute<AdSquadRootObject>(request);

            var result = Extract<AdSquadRootObject, AdsquadWrapper, Adsquad>(response);

            return result.FirstOrDefault();
        }

        /// <inheritdoc/>
        public IEnumerable<Adsquad> GetByAdAccountId(string adAccountId, PagingOption pagingOption)
        {
#pragma warning disable SA1305 // Field names should not use Hungarian notation
            var adSquads = ExecutePagedRequest<AdSquadRootObject, AdsquadWrapper, Adsquad>($"/adaccounts/{adAccountId}/adsquads", pagingOption);
#pragma warning restore SA1305 // Field names should not use Hungarian notation

            return adSquads;
        }

        /// <inheritdoc/>
        public IEnumerable<Adsquad> GetByCampaignId(string campaignId, PagingOption pagingOption)
        {
#pragma warning disable SA1305 // Field names should not use Hungarian notation
            var adSquads = ExecutePagedRequest<AdSquadRootObject, AdsquadWrapper, Adsquad>($"/campaigns/{campaignId}/adsquads", pagingOption);
#pragma warning restore SA1305 // Field names should not use Hungarian notation

            return adSquads;
        }
    }
}
