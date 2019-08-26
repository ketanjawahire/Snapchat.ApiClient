namespace Snapchat.ApiClient
{
    internal class MeasurementService : BaseService, IMeasurementService
    {
        public MeasurementService(AuthenticationService authService) : base(authService)
        {
        }

        public void GetStats(StatsOptions options)
        {
            throw new System.NotImplementedException();
        }
    }
}