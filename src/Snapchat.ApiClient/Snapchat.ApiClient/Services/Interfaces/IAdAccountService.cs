namespace Snapchat.ApiClient
{
    public interface IAdAccountService : IApiService
    {
        AdAccountRootObject GetByOrganizationId(string organizationId);
    }
}
