using System.Collections.Generic;
using Snapchat.ApiClient.Services;

namespace Snapchat.ApiClient
{
    internal class AdService : BaseService, IAdService
    {
        private AuthenticationService _authService;

        public AdService(AuthenticationService authService) : base(authService)
        {
            _authService = authService;
        }

        public Ad Get(string adId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Ad> GetByAdAccountId(string adAccountId, PagingOption pagingOption)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Ad> GetByAdSquadId(string adsquadId, PagingOption pagingOption)
        {
            throw new System.NotImplementedException();
        }
    }
}