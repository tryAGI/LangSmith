
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum ThreadsThreadStatsSelectField
    {
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectCompletionCost,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectCompletionCostDetails,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectCompletionTokens,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectCompletionTokenDetails,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectErrorRate,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectFirstTokenP50,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectFirstTokenP99,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectLatencyP50,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectLatencyP99,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectMedianTokens,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectPromptCost,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectPromptCostDetails,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectPromptTokens,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectPromptTokenDetails,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectStreamingRate,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectThreadCount,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectThreadFeedbackStats,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectTotalCost,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectTotalTokens,
        /// <summary>
        ///
        /// </summary>
        ThreadStatsSelectTraceCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadsThreadStatsSelectFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadsThreadStatsSelectField value)
        {
            return value switch
            {
                ThreadsThreadStatsSelectField.ThreadStatsSelectCompletionCost => "COMPLETION_COST",
                ThreadsThreadStatsSelectField.ThreadStatsSelectCompletionCostDetails => "COMPLETION_COST_DETAILS",
                ThreadsThreadStatsSelectField.ThreadStatsSelectCompletionTokens => "COMPLETION_TOKENS",
                ThreadsThreadStatsSelectField.ThreadStatsSelectCompletionTokenDetails => "COMPLETION_TOKEN_DETAILS",
                ThreadsThreadStatsSelectField.ThreadStatsSelectErrorRate => "ERROR_RATE",
                ThreadsThreadStatsSelectField.ThreadStatsSelectFirstTokenP50 => "FIRST_TOKEN_P50",
                ThreadsThreadStatsSelectField.ThreadStatsSelectFirstTokenP99 => "FIRST_TOKEN_P99",
                ThreadsThreadStatsSelectField.ThreadStatsSelectLatencyP50 => "LATENCY_P50",
                ThreadsThreadStatsSelectField.ThreadStatsSelectLatencyP99 => "LATENCY_P99",
                ThreadsThreadStatsSelectField.ThreadStatsSelectMedianTokens => "MEDIAN_TOKENS",
                ThreadsThreadStatsSelectField.ThreadStatsSelectPromptCost => "PROMPT_COST",
                ThreadsThreadStatsSelectField.ThreadStatsSelectPromptCostDetails => "PROMPT_COST_DETAILS",
                ThreadsThreadStatsSelectField.ThreadStatsSelectPromptTokens => "PROMPT_TOKENS",
                ThreadsThreadStatsSelectField.ThreadStatsSelectPromptTokenDetails => "PROMPT_TOKEN_DETAILS",
                ThreadsThreadStatsSelectField.ThreadStatsSelectStreamingRate => "STREAMING_RATE",
                ThreadsThreadStatsSelectField.ThreadStatsSelectThreadCount => "THREAD_COUNT",
                ThreadsThreadStatsSelectField.ThreadStatsSelectThreadFeedbackStats => "THREAD_FEEDBACK_STATS",
                ThreadsThreadStatsSelectField.ThreadStatsSelectTotalCost => "TOTAL_COST",
                ThreadsThreadStatsSelectField.ThreadStatsSelectTotalTokens => "TOTAL_TOKENS",
                ThreadsThreadStatsSelectField.ThreadStatsSelectTraceCount => "TRACE_COUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadsThreadStatsSelectField? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETION_COST" => ThreadsThreadStatsSelectField.ThreadStatsSelectCompletionCost,
                "COMPLETION_COST_DETAILS" => ThreadsThreadStatsSelectField.ThreadStatsSelectCompletionCostDetails,
                "COMPLETION_TOKENS" => ThreadsThreadStatsSelectField.ThreadStatsSelectCompletionTokens,
                "COMPLETION_TOKEN_DETAILS" => ThreadsThreadStatsSelectField.ThreadStatsSelectCompletionTokenDetails,
                "ERROR_RATE" => ThreadsThreadStatsSelectField.ThreadStatsSelectErrorRate,
                "FIRST_TOKEN_P50" => ThreadsThreadStatsSelectField.ThreadStatsSelectFirstTokenP50,
                "FIRST_TOKEN_P99" => ThreadsThreadStatsSelectField.ThreadStatsSelectFirstTokenP99,
                "LATENCY_P50" => ThreadsThreadStatsSelectField.ThreadStatsSelectLatencyP50,
                "LATENCY_P99" => ThreadsThreadStatsSelectField.ThreadStatsSelectLatencyP99,
                "MEDIAN_TOKENS" => ThreadsThreadStatsSelectField.ThreadStatsSelectMedianTokens,
                "PROMPT_COST" => ThreadsThreadStatsSelectField.ThreadStatsSelectPromptCost,
                "PROMPT_COST_DETAILS" => ThreadsThreadStatsSelectField.ThreadStatsSelectPromptCostDetails,
                "PROMPT_TOKENS" => ThreadsThreadStatsSelectField.ThreadStatsSelectPromptTokens,
                "PROMPT_TOKEN_DETAILS" => ThreadsThreadStatsSelectField.ThreadStatsSelectPromptTokenDetails,
                "STREAMING_RATE" => ThreadsThreadStatsSelectField.ThreadStatsSelectStreamingRate,
                "THREAD_COUNT" => ThreadsThreadStatsSelectField.ThreadStatsSelectThreadCount,
                "THREAD_FEEDBACK_STATS" => ThreadsThreadStatsSelectField.ThreadStatsSelectThreadFeedbackStats,
                "TOTAL_COST" => ThreadsThreadStatsSelectField.ThreadStatsSelectTotalCost,
                "TOTAL_TOKENS" => ThreadsThreadStatsSelectField.ThreadStatsSelectTotalTokens,
                "TRACE_COUNT" => ThreadsThreadStatsSelectField.ThreadStatsSelectTraceCount,
                _ => null,
            };
        }
    }
}