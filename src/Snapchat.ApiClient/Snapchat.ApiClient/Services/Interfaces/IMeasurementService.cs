namespace Snapchat.ApiClient.Services.Interfaces
{
    public interface IMeasurementService : IApiService
    {
        void GetStats(StatsOptions options);
    }
}
