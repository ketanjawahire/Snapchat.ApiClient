using Snapchat.ApiClient.Enums;
using System;

namespace Snapchat.ApiClient
{
    public class StatsOptions
    {
        Level Level { get; set; }
        public string Breakdown { get; set; }
        public string Fields { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime StartTime { get; set; }
        public string Granularity { get; set; }
        public bool Test { get; set; }
        public Dimension Dimension { get; set; }
        public Pivot Pivot { get; set; }
        public SwipUpAttriutionWindow SwipUpAttriutionWindow { get; set; }
        public ViewAttriutionWindow ViewAttriutionWindow { get; set; }
        public bool PositionStats { get; set; }
    }
}
