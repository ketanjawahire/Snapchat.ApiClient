using System;
using System.Globalization;
using System.Linq;
using RestSharp;
using Snapchat.ApiClient.Services.Interfaces;

namespace Snapchat.ApiClient.Services
{
    /// <summary>
    /// Provides methods to get measurement data using Snapchat API.
    /// </summary>
    internal class MeasurementService : BaseService, IMeasurementService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementService"/> class.
        /// </summary>
        /// <param name="authService">Instance of <see cref="AuthenticationService"/>.</param>
        internal MeasurementService(AuthenticationService authService)
            : base(authService)
        {
        }

        /// <inheritdoc/>
        public T GetStats<T>(string entityId, StatsOptions options)
            where T : class, new()
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

            if (options.ReportDimension != null && options.ReportDimension.Length > 1)
            {
                request.AddParameter("report_dimension", options.ReportDimension);
            }

            var response = Execute<T>(request);

            return response;
        }
    }
}