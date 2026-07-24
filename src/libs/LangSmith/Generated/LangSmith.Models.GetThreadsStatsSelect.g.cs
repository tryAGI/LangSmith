
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetThreadsStatsSelect
    {
        /// <summary>
        /// 
        /// </summary>
        CompletionCost,
        /// <summary>
        /// 
        /// </summary>
        CompletionCostDetails,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokenDetails,
        /// <summary>
        /// 
        /// </summary>
        FeedbackStats,
        /// <summary>
        /// 
        /// </summary>
        FirstStartTime,
        /// <summary>
        /// 
        /// </summary>
        LastEndTime,
        /// <summary>
        /// 
        /// </summary>
        LastStartTime,
        /// <summary>
        /// 
        /// </summary>
        LatencyP50,
        /// <summary>
        /// 
        /// </summary>
        LatencyP99,
        /// <summary>
        /// 
        /// </summary>
        PromptCost,
        /// <summary>
        /// 
        /// </summary>
        PromptCostDetails,
        /// <summary>
        /// 
        /// </summary>
        PromptTokens,
        /// <summary>
        /// 
        /// </summary>
        PromptTokenDetails,
        /// <summary>
        /// 
        /// </summary>
        TotalCost,
        /// <summary>
        /// 
        /// </summary>
        TotalTokens,
        /// <summary>
        /// 
        /// </summary>
        Turns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetThreadsStatsSelectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetThreadsStatsSelect value)
        {
            return value switch
            {
                GetThreadsStatsSelect.CompletionCost => "COMPLETION_COST",
                GetThreadsStatsSelect.CompletionCostDetails => "COMPLETION_COST_DETAILS",
                GetThreadsStatsSelect.CompletionTokens => "COMPLETION_TOKENS",
                GetThreadsStatsSelect.CompletionTokenDetails => "COMPLETION_TOKEN_DETAILS",
                GetThreadsStatsSelect.FeedbackStats => "FEEDBACK_STATS",
                GetThreadsStatsSelect.FirstStartTime => "FIRST_START_TIME",
                GetThreadsStatsSelect.LastEndTime => "LAST_END_TIME",
                GetThreadsStatsSelect.LastStartTime => "LAST_START_TIME",
                GetThreadsStatsSelect.LatencyP50 => "LATENCY_P50",
                GetThreadsStatsSelect.LatencyP99 => "LATENCY_P99",
                GetThreadsStatsSelect.PromptCost => "PROMPT_COST",
                GetThreadsStatsSelect.PromptCostDetails => "PROMPT_COST_DETAILS",
                GetThreadsStatsSelect.PromptTokens => "PROMPT_TOKENS",
                GetThreadsStatsSelect.PromptTokenDetails => "PROMPT_TOKEN_DETAILS",
                GetThreadsStatsSelect.TotalCost => "TOTAL_COST",
                GetThreadsStatsSelect.TotalTokens => "TOTAL_TOKENS",
                GetThreadsStatsSelect.Turns => "TURNS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetThreadsStatsSelect? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETION_COST" => GetThreadsStatsSelect.CompletionCost,
                "COMPLETION_COST_DETAILS" => GetThreadsStatsSelect.CompletionCostDetails,
                "COMPLETION_TOKENS" => GetThreadsStatsSelect.CompletionTokens,
                "COMPLETION_TOKEN_DETAILS" => GetThreadsStatsSelect.CompletionTokenDetails,
                "FEEDBACK_STATS" => GetThreadsStatsSelect.FeedbackStats,
                "FIRST_START_TIME" => GetThreadsStatsSelect.FirstStartTime,
                "LAST_END_TIME" => GetThreadsStatsSelect.LastEndTime,
                "LAST_START_TIME" => GetThreadsStatsSelect.LastStartTime,
                "LATENCY_P50" => GetThreadsStatsSelect.LatencyP50,
                "LATENCY_P99" => GetThreadsStatsSelect.LatencyP99,
                "PROMPT_COST" => GetThreadsStatsSelect.PromptCost,
                "PROMPT_COST_DETAILS" => GetThreadsStatsSelect.PromptCostDetails,
                "PROMPT_TOKENS" => GetThreadsStatsSelect.PromptTokens,
                "PROMPT_TOKEN_DETAILS" => GetThreadsStatsSelect.PromptTokenDetails,
                "TOTAL_COST" => GetThreadsStatsSelect.TotalCost,
                "TOTAL_TOKENS" => GetThreadsStatsSelect.TotalTokens,
                "TURNS" => GetThreadsStatsSelect.Turns,
                _ => null,
            };
        }
    }
}