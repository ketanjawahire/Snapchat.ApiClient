namespace Snapchat.ApiClient
{
    public interface IMeasurementService : IApiService
    {
        void GetStats(StatsOptions options);
    }
}
