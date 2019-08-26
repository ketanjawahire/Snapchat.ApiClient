using Snapchat.ApiClient.Exceptions;
using Snapchat.ApiClient.Services.Interfaces;

namespace Snapchat.ApiClient.Services
{
    public class SnapchatServices
    {
        private AuthenticationService _authService;

        public SnapchatServices(string clientId, string clientSecret, string refreshToken)
        {
            _authService = new AuthenticationService(clientId, clientSecret, refreshToken);
        }

        public T GetService<T>() where T : IApiService
        {
            IApiService apiService = null;

            if (typeof(T) == typeof(IOrganizationService)) apiService = new OrganizationService(_authService);
            else if (typeof(T) == typeof(IAdAccountService)) apiService = new AdAccountService(_authService);
            else if (typeof(T) == typeof(ICampaignService)) apiService = new CampaignService(_authService);
            else if (typeof(T) == typeof(IAdSquadService)) apiService = new AdSquadService(_authService);
            else if (typeof(T) == typeof(IAdService)) apiService = new AdService(_authService);
            else if (typeof(T) == typeof(ICreativeService)) apiService = new CreativeService(_authService);
            else if (typeof(T) == typeof(IMeasurementService)) apiService = new MeasurementService(_authService);
            else throw new ApiServiceNotFoundException(typeof(T));
            return (T)apiService;
        }
    }
}
