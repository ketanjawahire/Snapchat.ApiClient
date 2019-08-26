using Snapchat.ApiClient.Entities.Api;
using System.Collections.Generic;

namespace Snapchat.ApiClient.Services.Interfaces
{
    public interface IOrganizationService : IApiService
    {
        Organization GetById(string organizationId);

#pragma warning disable CA1716 // Identifiers should not match keywords
        IEnumerable<Organization> Get(PagingOption pagingOption);
#pragma warning restore CA1716 // Identifiers should not match keywords
    }


}
