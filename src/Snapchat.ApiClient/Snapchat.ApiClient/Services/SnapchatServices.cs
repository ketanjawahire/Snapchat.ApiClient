using Snapchat.ApiClient.Exceptions;
using Snapchat.ApiClient.Services.Interfaces;

namespace Snapchat.ApiClient.Services
{
    /// <summary>
    /// Provides set of API services to interact with Snapchat API.
    /// </summary>
    public class SnapchatServices
    {
        private readonly AuthenticationService _authService;

        /// <summary>
        /// Initializes a new instance of the <see cref="SnapchatServices"/> class.
        /// </summary>
        /// <param name="clientId">Client id.</param>
        /// <param name="clientSecret">Client secret.</param>
        /// <param name="refreshToken">Refresh token.</param>
        public SnapchatServices(string clientId, string clientSecret, string refreshToken)
        {
            _authService = new AuthenticationService(clientId, clientSecret, refreshToken);
        }

        /// <summary>
        /// Gets service implementation of type <typeparamref name="TEntity"/>.
        /// </summary>
        /// <typeparam name="TEntity"><see cref="IApiService"/>.</typeparam>
        /// <returns>Service implementation of type <typeparamref name="TEntity"/>.</returns>
        public TEntity GetService<TEntity>()
            where TEntity : IApiService
        {
            IApiService apiService = null;

            if (typeof(TEntity) == typeof(IOrganizationService))
            {
                apiService = new OrganizationService(_authService);
            }
            else if (typeof(TEntity) == typeof(IAdAccountService))
            {
                apiService = new AdAccountService(_authService);
            }
            else if (typeof(TEntity) == typeof(ICampaignService))
            {
                apiService = new CampaignService(_authService);
            }
            else if (typeof(TEntity) == typeof(IAdSquadService))
            {
                apiService = new AdSquadService(_authService);
            }
            else if (typeof(TEntity) == typeof(IAdService))
            {
                apiService = new AdService(_authService);
            }
            else if (typeof(TEntity) == typeof(ICreativeService))
            {
                apiService = new CreativeService(_authService);
            }
            else if (typeof(TEntity) == typeof(IMeasurementService))
            {
                apiService = new MeasurementService(_authService);
            }
            else if (typeof(TEntity) == typeof(IMediaService))
            {
                apiService = new MediaService(_authService);
            }
            else
            {
                throw new ApiServiceNotFoundException(typeof(TEntity));
            }

            return (TEntity)apiService;
        }
    }
}
