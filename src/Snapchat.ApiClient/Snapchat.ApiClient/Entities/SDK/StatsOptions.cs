using Snapchat.ApiClient.Enums;
using System;
using System.Collections.Generic;

namespace Snapchat.ApiClient
{
    public class StatsOptions
    {
        public Level Level { get; set; }
        public Breakdown? Breakdown { get; set; }
#pragma warning disable CA2227 // Collection properties should be read only
        public List<string> Fields { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
        public DateTime EndTime { get; set; }
        public DateTime StartTime { get; set; }
        public Granularity Granularity { get; set; }
        public bool Test { get; set; }
        public Dimension? Dimension { get; set; }
        public Pivot? Pivot { get; set; }
        public SwipUpAttriutionWindow? SwipUpAttriutionWindow { get; set; }
        public ViewAttriutionWindow? ViewAttriutionWindow { get; set; }
        public bool PositionStats { get; set; }
    }
}
