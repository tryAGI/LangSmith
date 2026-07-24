
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomChartMetricField
    {
        /// <summary>
        /// 
        /// </summary>
        CompletionCost,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        FeedbackScore,
        /// <summary>
        /// 
        /// </summary>
        FirstTokenSeconds,
        /// <summary>
        /// 
        /// </summary>
        LatencySeconds,
        /// <summary>
        /// 
        /// </summary>
        PromptCost,
        /// <summary>
        /// 
        /// </summary>
        PromptTokens,
        /// <summary>
        /// 
        /// </summary>
        TotalCost,
        /// <summary>
        /// 
        /// </summary>
        TotalTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomChartMetricFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomChartMetricField value)
        {
            return value switch
            {
                CustomChartMetricField.CompletionCost => "completion_cost",
                CustomChartMetricField.CompletionTokens => "completion_tokens",
                CustomChartMetricField.FeedbackScore => "feedback_score",
                CustomChartMetricField.FirstTokenSeconds => "first_token_seconds",
                CustomChartMetricField.LatencySeconds => "latency_seconds",
                CustomChartMetricField.PromptCost => "prompt_cost",
                CustomChartMetricField.PromptTokens => "prompt_tokens",
                CustomChartMetricField.TotalCost => "total_cost",
                CustomChartMetricField.TotalTokens => "total_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomChartMetricField? ToEnum(string value)
        {
            return value switch
            {
                "completion_cost" => CustomChartMetricField.CompletionCost,
                "completion_tokens" => CustomChartMetricField.CompletionTokens,
                "feedback_score" => CustomChartMetricField.FeedbackScore,
                "first_token_seconds" => CustomChartMetricField.FirstTokenSeconds,
                "latency_seconds" => CustomChartMetricField.LatencySeconds,
                "prompt_cost" => CustomChartMetricField.PromptCost,
                "prompt_tokens" => CustomChartMetricField.PromptTokens,
                "total_cost" => CustomChartMetricField.TotalCost,
                "total_tokens" => CustomChartMetricField.TotalTokens,
                _ => null,
            };
        }
    }
}