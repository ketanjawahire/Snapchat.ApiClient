namespace Snapchat.ApiClient.Services.Interfaces
{
    /// <summary>
    /// Provides methods to get measurement data using Snapchat API.
    /// </summary>
    public interface IMeasurementService : IApiService
    {
        /// <summary>
        /// Gets measurement data for given entity id using given stat options.
        /// </summary>
        /// <typeparam name="T">C# class which will be used to deserialize API response.</typeparam>
        /// <param name="entityId">Entity id for which we have to pull data.</param>
        /// <param name="options">API Options.</param>
        /// <returns>Measurement data for given entity id using provided options.</returns>
        T GetStats<T>(string entityId, StatsOptions options)
            where T : class, new();
    }
}
