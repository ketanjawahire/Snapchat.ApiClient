namespace Snapchat.ApiClient
{
    internal class MeasurementService : BaseService, IMeasurementService
    {
        private AuthenticationService _authService;

        public MeasurementService(AuthenticationService authService) : base(authService)
        {
            _authService = authService;
        }

        public void GetStats(StatsOptions options)
        {
            throw new System.NotImplementedException();
        }
    }
}