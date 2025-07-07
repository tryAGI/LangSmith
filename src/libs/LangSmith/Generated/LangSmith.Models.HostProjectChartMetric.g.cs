
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
        /// <summary>
        /// 
        /// </summary>
        WorkerCount,
        /// <summary>
        /// 
        /// </summary>
        LgRunCount,
        /// <summary>
        /// 
        /// </summary>
        ResponsesPerSecond,
        /// <summary>
        /// 
        /// </summary>
        ErrorResponsesPerSecond,
        /// <summary>
        /// 
        /// </summary>
        P95Latency,
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
                HostProjectChartMetric.WorkerCount => "worker_count",
                HostProjectChartMetric.LgRunCount => "lg_run_count",
                HostProjectChartMetric.ResponsesPerSecond => "responses_per_second",
                HostProjectChartMetric.ErrorResponsesPerSecond => "error_responses_per_second",
                HostProjectChartMetric.P95Latency => "p95_latency",
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
                "worker_count" => HostProjectChartMetric.WorkerCount,
                "lg_run_count" => HostProjectChartMetric.LgRunCount,
                "responses_per_second" => HostProjectChartMetric.ResponsesPerSecond,
                "error_responses_per_second" => HostProjectChartMetric.ErrorResponsesPerSecond,
                "p95_latency" => HostProjectChartMetric.P95Latency,
                _ => null,
            };
        }
    }
}