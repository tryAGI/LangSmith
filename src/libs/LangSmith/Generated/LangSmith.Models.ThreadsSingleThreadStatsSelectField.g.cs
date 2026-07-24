
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ThreadsSingleThreadStatsSelectField
    {
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectCompletionCost,
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectCompletionCostDetails,
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectCompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectCompletionTokenDetails,
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectFeedbackStats,
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectFirstStartTime,
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectLastEndTime,
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectLastStartTime,
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectLatencyP50,
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectLatencyP99,
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectPromptCost,
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectPromptCostDetails,
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectPromptTokens,
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectPromptTokenDetails,
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectTotalCost,
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectTotalTokens,
        /// <summary>
        /// 
        /// </summary>
        SingleThreadStatsSelectTurns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadsSingleThreadStatsSelectFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadsSingleThreadStatsSelectField value)
        {
            return value switch
            {
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectCompletionCost => "COMPLETION_COST",
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectCompletionCostDetails => "COMPLETION_COST_DETAILS",
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectCompletionTokens => "COMPLETION_TOKENS",
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectCompletionTokenDetails => "COMPLETION_TOKEN_DETAILS",
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectFeedbackStats => "FEEDBACK_STATS",
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectFirstStartTime => "FIRST_START_TIME",
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectLastEndTime => "LAST_END_TIME",
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectLastStartTime => "LAST_START_TIME",
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectLatencyP50 => "LATENCY_P50",
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectLatencyP99 => "LATENCY_P99",
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectPromptCost => "PROMPT_COST",
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectPromptCostDetails => "PROMPT_COST_DETAILS",
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectPromptTokens => "PROMPT_TOKENS",
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectPromptTokenDetails => "PROMPT_TOKEN_DETAILS",
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectTotalCost => "TOTAL_COST",
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectTotalTokens => "TOTAL_TOKENS",
                ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectTurns => "TURNS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadsSingleThreadStatsSelectField? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETION_COST" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectCompletionCost,
                "COMPLETION_COST_DETAILS" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectCompletionCostDetails,
                "COMPLETION_TOKENS" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectCompletionTokens,
                "COMPLETION_TOKEN_DETAILS" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectCompletionTokenDetails,
                "FEEDBACK_STATS" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectFeedbackStats,
                "FIRST_START_TIME" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectFirstStartTime,
                "LAST_END_TIME" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectLastEndTime,
                "LAST_START_TIME" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectLastStartTime,
                "LATENCY_P50" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectLatencyP50,
                "LATENCY_P99" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectLatencyP99,
                "PROMPT_COST" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectPromptCost,
                "PROMPT_COST_DETAILS" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectPromptCostDetails,
                "PROMPT_TOKENS" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectPromptTokens,
                "PROMPT_TOKEN_DETAILS" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectPromptTokenDetails,
                "TOTAL_COST" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectTotalCost,
                "TOTAL_TOKENS" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectTotalTokens,
                "TURNS" => ThreadsSingleThreadStatsSelectField.SingleThreadStatsSelectTurns,
                _ => null,
            };
        }
    }
}