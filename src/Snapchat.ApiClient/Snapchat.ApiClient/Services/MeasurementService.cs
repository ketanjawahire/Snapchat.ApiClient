using RestSharp;
using Snapchat.ApiClient.Services.Interfaces;
using System.Globalization;
using System.Linq;

namespace Snapchat.ApiClient.Services
{
    internal class MeasurementService : BaseService, IMeasurementService
    {
        public MeasurementService(AuthenticationService authService) : base(authService)
        {
        }

        public T GetStats<T>(string entityId, StatsOptions options) where T : class, new()
        {
            var request = new RestRequest("/{entity_name}s/{entity_id}/stats", Method.GET);

            request.AddUrlSegment("entity_id", entityId);

#pragma warning disable CA1308 // Normalize strings to uppercase
            request.AddUrlSegment("entity_name", options.Level.ToString().ToLowerInvariant());
#pragma warning restore CA1308 // Normalize strings to uppercase

            request.AddParameter("end_time", options.EndTime.ToString("yyyy-MM-ddTHH:mm:sszzz", CultureInfo.InvariantCulture));
            request.AddParameter("start_time", options.StartTime.ToString("yyyy-MM-ddTHH:mm:sszzz", CultureInfo.InvariantCulture));
            request.AddParameter("granularity", options.Granularity.ToString());

            if (options.Fields != null && options.Fields.Any())
            {
                request.AddParameter("fields", string.Join(",", options.Fields));
            }

            if (options.Test)
            {
                request.AddParameter("test", "true");
            }

            if (options.Breakdown.HasValue)
            {
#pragma warning disable CA1308 // Normalize strings to uppercase
                request.AddParameter("breakdown", options.Breakdown.Value.ToString().ToLowerInvariant());
#pragma warning restore CA1308 // Normalize strings to uppercase
            }

            if (options.Dimension.HasValue)
            {
                request.AddParameter("dimension", options.Dimension.Value.ToString().ToUpperInvariant());
            }

            if (options.SwipUpAttriutionWindow.HasValue)
            {
                request.AddParameter("swipe_up_attribution_window", options.SwipUpAttriutionWindow.Value.ToString().TrimStart('_').ToUpperInvariant());
            }

            if (options.ViewAttriutionWindow.HasValue)
            {
                request.AddParameter("view_attribution_window", options.ViewAttriutionWindow.Value.ToString().TrimStart('_').ToUpperInvariant());
            }

            if (options.PositionStats)
            {
                request.AddParameter("position_stats", "true");
            }

            var response = Execute<T>(request);

            return response;

        }
    }
}