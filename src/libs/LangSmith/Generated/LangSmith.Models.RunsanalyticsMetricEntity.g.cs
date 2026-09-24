
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum RunsanalyticsMetricEntity
    {
        /// <summary>
        ///
        /// </summary>
        MetricEntityFeedback,
        /// <summary>
        ///
        /// </summary>
        MetricEntityRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunsanalyticsMetricEntityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunsanalyticsMetricEntity value)
        {
            return value switch
            {
                RunsanalyticsMetricEntity.MetricEntityFeedback => "feedback",
                RunsanalyticsMetricEntity.MetricEntityRun => "run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunsanalyticsMetricEntity? ToEnum(string value)
        {
            return value switch
            {
                "feedback" => RunsanalyticsMetricEntity.MetricEntityFeedback,
                "run" => RunsanalyticsMetricEntity.MetricEntityRun,
                _ => null,
            };
        }
    }
}