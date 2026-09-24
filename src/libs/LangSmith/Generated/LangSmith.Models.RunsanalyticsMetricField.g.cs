
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum RunsanalyticsMetricField
    {
        /// <summary>
        ///
        /// </summary>
        MetricFieldCompletionCost,
        /// <summary>
        ///
        /// </summary>
        MetricFieldCompletionTokens,
        /// <summary>
        ///
        /// </summary>
        MetricFieldFeedbackScore,
        /// <summary>
        ///
        /// </summary>
        MetricFieldFirstTokenSeconds,
        /// <summary>
        ///
        /// </summary>
        MetricFieldLatencySeconds,
        /// <summary>
        ///
        /// </summary>
        MetricFieldPromptCost,
        /// <summary>
        ///
        /// </summary>
        MetricFieldPromptTokens,
        /// <summary>
        ///
        /// </summary>
        MetricFieldTotalCost,
        /// <summary>
        ///
        /// </summary>
        MetricFieldTotalTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunsanalyticsMetricFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunsanalyticsMetricField value)
        {
            return value switch
            {
                RunsanalyticsMetricField.MetricFieldCompletionCost => "completion_cost",
                RunsanalyticsMetricField.MetricFieldCompletionTokens => "completion_tokens",
                RunsanalyticsMetricField.MetricFieldFeedbackScore => "feedback_score",
                RunsanalyticsMetricField.MetricFieldFirstTokenSeconds => "first_token_seconds",
                RunsanalyticsMetricField.MetricFieldLatencySeconds => "latency_seconds",
                RunsanalyticsMetricField.MetricFieldPromptCost => "prompt_cost",
                RunsanalyticsMetricField.MetricFieldPromptTokens => "prompt_tokens",
                RunsanalyticsMetricField.MetricFieldTotalCost => "total_cost",
                RunsanalyticsMetricField.MetricFieldTotalTokens => "total_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunsanalyticsMetricField? ToEnum(string value)
        {
            return value switch
            {
                "completion_cost" => RunsanalyticsMetricField.MetricFieldCompletionCost,
                "completion_tokens" => RunsanalyticsMetricField.MetricFieldCompletionTokens,
                "feedback_score" => RunsanalyticsMetricField.MetricFieldFeedbackScore,
                "first_token_seconds" => RunsanalyticsMetricField.MetricFieldFirstTokenSeconds,
                "latency_seconds" => RunsanalyticsMetricField.MetricFieldLatencySeconds,
                "prompt_cost" => RunsanalyticsMetricField.MetricFieldPromptCost,
                "prompt_tokens" => RunsanalyticsMetricField.MetricFieldPromptTokens,
                "total_cost" => RunsanalyticsMetricField.MetricFieldTotalCost,
                "total_tokens" => RunsanalyticsMetricField.MetricFieldTotalTokens,
                _ => null,
            };
        }
    }
}