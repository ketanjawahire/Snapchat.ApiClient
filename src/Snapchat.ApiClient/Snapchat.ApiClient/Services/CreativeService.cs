using System.Collections.Generic;
using Snapchat.ApiClient.Services;

namespace Snapchat.ApiClient
{
    internal class CreativeService : BaseService, ICreativeService
    {
        private AuthenticationService _authService;

        public CreativeService(AuthenticationService authService) : base(authService)
        {
            _authService = authService;
        }

        public Creative Get(string creativeId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Creative> GetByAdAccountId(string adAccountId, PagingOption pagingOption)
        {
            throw new System.NotImplementedException();
        }
    }
}