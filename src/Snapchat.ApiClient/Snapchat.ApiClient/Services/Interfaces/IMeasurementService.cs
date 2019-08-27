namespace Snapchat.ApiClient.Services.Interfaces
{
    public interface IMeasurementService : IApiService
    {
        T GetStats<T>(string accountId, StatsOptions options) where T : class, new();
    }
}
