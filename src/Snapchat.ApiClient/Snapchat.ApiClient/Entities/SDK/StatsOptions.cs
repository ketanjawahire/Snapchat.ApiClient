using System;
using System.Collections.Generic;
using Snapchat.ApiClient.Enums;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents data download API call input options model.
    /// </summary>
    public class StatsOptions
    {
        /// <summary>
        /// Gets or sets data download level.
        /// </summary>
        public Level Level { get; set; }

        /// <summary>
        /// Gets or sets data breakdown.
        /// </summary>
        public Breakdown? Breakdown { get; set; }
#pragma warning disable CA2227 // Collection properties should be read only

        /// <summary>
        /// Gets or sets fields to fetch from API.
        /// </summary>
        public List<string> Fields { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only

        /// <summary>
        /// Gets or sets end time with account timezone offset.
        /// </summary>
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// Gets or sets start time with account timezone offset.
        /// </summary>
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// Gets or sets data download granularity.
        /// </summary>
        public Granularity Granularity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include fake test values or not.
        /// </summary>
        public bool Test { get; set; }

        /// <summary>
        /// Gets or sets dimension.
        /// </summary>
        public Dimension? Dimension { get; set; }

        /// <summary>
        /// Gets or sets pivot value.
        /// </summary>
        public Pivot? Pivot { get; set; }

        /// <summary>
        /// Gets or sets swipe up attribution window value.
        /// </summary>
        public SwipUpAttriutionWindow? SwipUpAttriutionWindow { get; set; }

        /// <summary>
        /// Gets or sets view attribution window value.
        /// </summary>
        public ViewAttriutionWindow? ViewAttriutionWindow { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include position stats or not.
        /// </summary>
        public bool PositionStats { get; set; }
    }
}
