
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum RunsanalyticsMetricType
    {
        /// <summary>
        ///
        /// </summary>
        MetricTypeAvg,
        /// <summary>
        ///
        /// </summary>
        MetricTypeCount,
        /// <summary>
        ///
        /// </summary>
        MetricTypeHistogram,
        /// <summary>
        ///
        /// </summary>
        MetricTypeMax,
        /// <summary>
        ///
        /// </summary>
        MetricTypeMin,
        /// <summary>
        ///
        /// </summary>
        MetricTypePercentile,
        /// <summary>
        ///
        /// </summary>
        MetricTypeRatio,
        /// <summary>
        ///
        /// </summary>
        MetricTypeSum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunsanalyticsMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunsanalyticsMetricType value)
        {
            return value switch
            {
                RunsanalyticsMetricType.MetricTypeAvg => "avg",
                RunsanalyticsMetricType.MetricTypeCount => "count",
                RunsanalyticsMetricType.MetricTypeHistogram => "histogram",
                RunsanalyticsMetricType.MetricTypeMax => "max",
                RunsanalyticsMetricType.MetricTypeMin => "min",
                RunsanalyticsMetricType.MetricTypePercentile => "percentile",
                RunsanalyticsMetricType.MetricTypeRatio => "ratio",
                RunsanalyticsMetricType.MetricTypeSum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunsanalyticsMetricType? ToEnum(string value)
        {
            return value switch
            {
                "avg" => RunsanalyticsMetricType.MetricTypeAvg,
                "count" => RunsanalyticsMetricType.MetricTypeCount,
                "histogram" => RunsanalyticsMetricType.MetricTypeHistogram,
                "max" => RunsanalyticsMetricType.MetricTypeMax,
                "min" => RunsanalyticsMetricType.MetricTypeMin,
                "percentile" => RunsanalyticsMetricType.MetricTypePercentile,
                "ratio" => RunsanalyticsMetricType.MetricTypeRatio,
                "sum" => RunsanalyticsMetricType.MetricTypeSum,
                _ => null,
            };
        }
    }
}