
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
        MetricFieldCompletionCostDetailsAudio,
        /// <summary>
        ///
        /// </summary>
        MetricFieldCompletionCostDetailsImage,
        /// <summary>
        ///
        /// </summary>
        MetricFieldCompletionCostDetailsReasoning,
        /// <summary>
        ///
        /// </summary>
        MetricFieldCompletionCostDetailsVideo,
        /// <summary>
        ///
        /// </summary>
        MetricFieldCompletionTokenDetailsAudio,
        /// <summary>
        ///
        /// </summary>
        MetricFieldCompletionTokenDetailsImage,
        /// <summary>
        ///
        /// </summary>
        MetricFieldCompletionTokenDetailsReasoning,
        /// <summary>
        ///
        /// </summary>
        MetricFieldCompletionTokenDetailsVideo,
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
        MetricFieldPromptCostDetailsAudio,
        /// <summary>
        ///
        /// </summary>
        MetricFieldPromptCostDetailsCacheCreation,
        /// <summary>
        ///
        /// </summary>
        MetricFieldPromptCostDetailsCacheRead,
        /// <summary>
        ///
        /// </summary>
        MetricFieldPromptCostDetailsEphemeral1H,
        /// <summary>
        ///
        /// </summary>
        MetricFieldPromptCostDetailsEphemeral5M,
        /// <summary>
        ///
        /// </summary>
        MetricFieldPromptCostDetailsImage,
        /// <summary>
        ///
        /// </summary>
        MetricFieldPromptCostDetailsVideo,
        /// <summary>
        ///
        /// </summary>
        MetricFieldPromptTokenDetailsAudio,
        /// <summary>
        ///
        /// </summary>
        MetricFieldPromptTokenDetailsCacheCreation,
        /// <summary>
        ///
        /// </summary>
        MetricFieldPromptTokenDetailsCacheRead,
        /// <summary>
        ///
        /// </summary>
        MetricFieldPromptTokenDetailsEphemeral1H,
        /// <summary>
        ///
        /// </summary>
        MetricFieldPromptTokenDetailsEphemeral5M,
        /// <summary>
        ///
        /// </summary>
        MetricFieldPromptTokenDetailsImage,
        /// <summary>
        ///
        /// </summary>
        MetricFieldPromptTokenDetailsVideo,
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
                RunsanalyticsMetricField.MetricFieldCompletionCostDetailsAudio => "completion_cost_details.audio",
                RunsanalyticsMetricField.MetricFieldCompletionCostDetailsImage => "completion_cost_details.image",
                RunsanalyticsMetricField.MetricFieldCompletionCostDetailsReasoning => "completion_cost_details.reasoning",
                RunsanalyticsMetricField.MetricFieldCompletionCostDetailsVideo => "completion_cost_details.video",
                RunsanalyticsMetricField.MetricFieldCompletionTokenDetailsAudio => "completion_token_details.audio",
                RunsanalyticsMetricField.MetricFieldCompletionTokenDetailsImage => "completion_token_details.image",
                RunsanalyticsMetricField.MetricFieldCompletionTokenDetailsReasoning => "completion_token_details.reasoning",
                RunsanalyticsMetricField.MetricFieldCompletionTokenDetailsVideo => "completion_token_details.video",
                RunsanalyticsMetricField.MetricFieldCompletionTokens => "completion_tokens",
                RunsanalyticsMetricField.MetricFieldFeedbackScore => "feedback_score",
                RunsanalyticsMetricField.MetricFieldFirstTokenSeconds => "first_token_seconds",
                RunsanalyticsMetricField.MetricFieldLatencySeconds => "latency_seconds",
                RunsanalyticsMetricField.MetricFieldPromptCost => "prompt_cost",
                RunsanalyticsMetricField.MetricFieldPromptCostDetailsAudio => "prompt_cost_details.audio",
                RunsanalyticsMetricField.MetricFieldPromptCostDetailsCacheCreation => "prompt_cost_details.cache_creation",
                RunsanalyticsMetricField.MetricFieldPromptCostDetailsCacheRead => "prompt_cost_details.cache_read",
                RunsanalyticsMetricField.MetricFieldPromptCostDetailsEphemeral1H => "prompt_cost_details.ephemeral_1h_input_tokens",
                RunsanalyticsMetricField.MetricFieldPromptCostDetailsEphemeral5M => "prompt_cost_details.ephemeral_5m_input_tokens",
                RunsanalyticsMetricField.MetricFieldPromptCostDetailsImage => "prompt_cost_details.image",
                RunsanalyticsMetricField.MetricFieldPromptCostDetailsVideo => "prompt_cost_details.video",
                RunsanalyticsMetricField.MetricFieldPromptTokenDetailsAudio => "prompt_token_details.audio",
                RunsanalyticsMetricField.MetricFieldPromptTokenDetailsCacheCreation => "prompt_token_details.cache_creation",
                RunsanalyticsMetricField.MetricFieldPromptTokenDetailsCacheRead => "prompt_token_details.cache_read",
                RunsanalyticsMetricField.MetricFieldPromptTokenDetailsEphemeral1H => "prompt_token_details.ephemeral_1h_input_tokens",
                RunsanalyticsMetricField.MetricFieldPromptTokenDetailsEphemeral5M => "prompt_token_details.ephemeral_5m_input_tokens",
                RunsanalyticsMetricField.MetricFieldPromptTokenDetailsImage => "prompt_token_details.image",
                RunsanalyticsMetricField.MetricFieldPromptTokenDetailsVideo => "prompt_token_details.video",
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
                "completion_cost_details.audio" => RunsanalyticsMetricField.MetricFieldCompletionCostDetailsAudio,
                "completion_cost_details.image" => RunsanalyticsMetricField.MetricFieldCompletionCostDetailsImage,
                "completion_cost_details.reasoning" => RunsanalyticsMetricField.MetricFieldCompletionCostDetailsReasoning,
                "completion_cost_details.video" => RunsanalyticsMetricField.MetricFieldCompletionCostDetailsVideo,
                "completion_token_details.audio" => RunsanalyticsMetricField.MetricFieldCompletionTokenDetailsAudio,
                "completion_token_details.image" => RunsanalyticsMetricField.MetricFieldCompletionTokenDetailsImage,
                "completion_token_details.reasoning" => RunsanalyticsMetricField.MetricFieldCompletionTokenDetailsReasoning,
                "completion_token_details.video" => RunsanalyticsMetricField.MetricFieldCompletionTokenDetailsVideo,
                "completion_tokens" => RunsanalyticsMetricField.MetricFieldCompletionTokens,
                "feedback_score" => RunsanalyticsMetricField.MetricFieldFeedbackScore,
                "first_token_seconds" => RunsanalyticsMetricField.MetricFieldFirstTokenSeconds,
                "latency_seconds" => RunsanalyticsMetricField.MetricFieldLatencySeconds,
                "prompt_cost" => RunsanalyticsMetricField.MetricFieldPromptCost,
                "prompt_cost_details.audio" => RunsanalyticsMetricField.MetricFieldPromptCostDetailsAudio,
                "prompt_cost_details.cache_creation" => RunsanalyticsMetricField.MetricFieldPromptCostDetailsCacheCreation,
                "prompt_cost_details.cache_read" => RunsanalyticsMetricField.MetricFieldPromptCostDetailsCacheRead,
                "prompt_cost_details.ephemeral_1h_input_tokens" => RunsanalyticsMetricField.MetricFieldPromptCostDetailsEphemeral1H,
                "prompt_cost_details.ephemeral_5m_input_tokens" => RunsanalyticsMetricField.MetricFieldPromptCostDetailsEphemeral5M,
                "prompt_cost_details.image" => RunsanalyticsMetricField.MetricFieldPromptCostDetailsImage,
                "prompt_cost_details.video" => RunsanalyticsMetricField.MetricFieldPromptCostDetailsVideo,
                "prompt_token_details.audio" => RunsanalyticsMetricField.MetricFieldPromptTokenDetailsAudio,
                "prompt_token_details.cache_creation" => RunsanalyticsMetricField.MetricFieldPromptTokenDetailsCacheCreation,
                "prompt_token_details.cache_read" => RunsanalyticsMetricField.MetricFieldPromptTokenDetailsCacheRead,
                "prompt_token_details.ephemeral_1h_input_tokens" => RunsanalyticsMetricField.MetricFieldPromptTokenDetailsEphemeral1H,
                "prompt_token_details.ephemeral_5m_input_tokens" => RunsanalyticsMetricField.MetricFieldPromptTokenDetailsEphemeral5M,
                "prompt_token_details.image" => RunsanalyticsMetricField.MetricFieldPromptTokenDetailsImage,
                "prompt_token_details.video" => RunsanalyticsMetricField.MetricFieldPromptTokenDetailsVideo,
                "prompt_tokens" => RunsanalyticsMetricField.MetricFieldPromptTokens,
                "total_cost" => RunsanalyticsMetricField.MetricFieldTotalCost,
                "total_tokens" => RunsanalyticsMetricField.MetricFieldTotalTokens,
                _ => null,
            };
        }
    }
}