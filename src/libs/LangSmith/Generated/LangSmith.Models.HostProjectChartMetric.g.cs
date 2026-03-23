
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
        CpuUsage,
        /// <summary>
        /// 
        /// </summary>
        DiskUsage,
        /// <summary>
        /// 
        /// </summary>
        ErrorResponsesPerSecond,
        /// <summary>
        /// 
        /// </summary>
        LgRunCount,
        /// <summary>
        /// 
        /// </summary>
        MemoryUsage,
        /// <summary>
        /// 
        /// </summary>
        P95Latency,
        /// <summary>
        /// 
        /// </summary>
        ReplicaCount,
        /// <summary>
        /// 
        /// </summary>
        ResponsesPerSecond,
        /// <summary>
        /// 
        /// </summary>
        RestartCount,
        /// <summary>
        /// 
        /// </summary>
        WorkerCount,
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
                HostProjectChartMetric.CpuUsage => "cpu_usage",
                HostProjectChartMetric.DiskUsage => "disk_usage",
                HostProjectChartMetric.ErrorResponsesPerSecond => "error_responses_per_second",
                HostProjectChartMetric.LgRunCount => "lg_run_count",
                HostProjectChartMetric.MemoryUsage => "memory_usage",
                HostProjectChartMetric.P95Latency => "p95_latency",
                HostProjectChartMetric.ReplicaCount => "replica_count",
                HostProjectChartMetric.ResponsesPerSecond => "responses_per_second",
                HostProjectChartMetric.RestartCount => "restart_count",
                HostProjectChartMetric.WorkerCount => "worker_count",
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
                "cpu_usage" => HostProjectChartMetric.CpuUsage,
                "disk_usage" => HostProjectChartMetric.DiskUsage,
                "error_responses_per_second" => HostProjectChartMetric.ErrorResponsesPerSecond,
                "lg_run_count" => HostProjectChartMetric.LgRunCount,
                "memory_usage" => HostProjectChartMetric.MemoryUsage,
                "p95_latency" => HostProjectChartMetric.P95Latency,
                "replica_count" => HostProjectChartMetric.ReplicaCount,
                "responses_per_second" => HostProjectChartMetric.ResponsesPerSecond,
                "restart_count" => HostProjectChartMetric.RestartCount,
                "worker_count" => HostProjectChartMetric.WorkerCount,
                _ => null,
            };
        }
    }
}