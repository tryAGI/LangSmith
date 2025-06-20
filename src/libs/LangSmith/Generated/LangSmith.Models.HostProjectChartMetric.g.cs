
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// LGP Metrics you can chart.
    /// </summary>
    public enum HostProjectChartMetric
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryUsage,
        /// <summary>
        /// 
        /// </summary>
        CpuUsage,
        /// <summary>
        /// 
        /// </summary>
        DiskUsage,
        /// <summary>
        /// 
        /// </summary>
        RestartCount,
        /// <summary>
        /// 
        /// </summary>
        ReplicaCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostProjectChartMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostProjectChartMetric value)
        {
            return value switch
            {
                HostProjectChartMetric.MemoryUsage => "memory_usage",
                HostProjectChartMetric.CpuUsage => "cpu_usage",
                HostProjectChartMetric.DiskUsage => "disk_usage",
                HostProjectChartMetric.RestartCount => "restart_count",
                HostProjectChartMetric.ReplicaCount => "replica_count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostProjectChartMetric? ToEnum(string value)
        {
            return value switch
            {
                "memory_usage" => HostProjectChartMetric.MemoryUsage,
                "cpu_usage" => HostProjectChartMetric.CpuUsage,
                "disk_usage" => HostProjectChartMetric.DiskUsage,
                "restart_count" => HostProjectChartMetric.RestartCount,
                "replica_count" => HostProjectChartMetric.ReplicaCount,
                _ => null,
            };
        }
    }
}