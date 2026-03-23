
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Metrics you can select from run stats endpoint.
    /// </summary>
    public enum RunStatsSelect
    {
        /// <summary>
        /// 
        /// </summary>
        AllRunStats,
        /// <summary>
        /// 
        /// </summary>
        AllTokenStats,
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
        CompletionTokenDetails,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokensP50,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokensP99,
        /// <summary>
        /// 
        /// </summary>
        CostP50,
        /// <summary>
        /// 
        /// </summary>
        CostP99,
        /// <summary>
        /// 
        /// </summary>
        ErrorRate,
        /// <summary>
        /// 
        /// </summary>
        FeedbackStats,
        /// <summary>
        /// 
        /// </summary>
        FirstTokenP50,
        /// <summary>
        /// 
        /// </summary>
        FirstTokenP99,
        /// <summary>
        /// 
        /// </summary>
        LastRunStartTime,
        /// <summary>
        /// 
        /// </summary>
        LatencyAvg,
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
        MedianTokens,
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
        PromptTokenDetails,
        /// <summary>
        /// 
        /// </summary>
        PromptTokens,
        /// <summary>
        /// 
        /// </summary>
        PromptTokensP50,
        /// <summary>
        /// 
        /// </summary>
        PromptTokensP99,
        /// <summary>
        /// 
        /// </summary>
        RunCount,
        /// <summary>
        /// 
        /// </summary>
        RunFacets,
        /// <summary>
        /// 
        /// </summary>
        SessionFeedbackStats,
        /// <summary>
        /// 
        /// </summary>
        StreamingRate,
        /// <summary>
        /// 
        /// </summary>
        ThreadFeedbackStats,
        /// <summary>
        /// 
        /// </summary>
        TokensP99,
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
    public static class RunStatsSelectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStatsSelect value)
        {
            return value switch
            {
                RunStatsSelect.AllRunStats => "all_run_stats",
                RunStatsSelect.AllTokenStats => "all_token_stats",
                RunStatsSelect.CompletionCost => "completion_cost",
                RunStatsSelect.CompletionCostDetails => "completion_cost_details",
                RunStatsSelect.CompletionTokenDetails => "completion_token_details",
                RunStatsSelect.CompletionTokens => "completion_tokens",
                RunStatsSelect.CompletionTokensP50 => "completion_tokens_p50",
                RunStatsSelect.CompletionTokensP99 => "completion_tokens_p99",
                RunStatsSelect.CostP50 => "cost_p50",
                RunStatsSelect.CostP99 => "cost_p99",
                RunStatsSelect.ErrorRate => "error_rate",
                RunStatsSelect.FeedbackStats => "feedback_stats",
                RunStatsSelect.FirstTokenP50 => "first_token_p50",
                RunStatsSelect.FirstTokenP99 => "first_token_p99",
                RunStatsSelect.LastRunStartTime => "last_run_start_time",
                RunStatsSelect.LatencyAvg => "latency_avg",
                RunStatsSelect.LatencyP50 => "latency_p50",
                RunStatsSelect.LatencyP99 => "latency_p99",
                RunStatsSelect.MedianTokens => "median_tokens",
                RunStatsSelect.PromptCost => "prompt_cost",
                RunStatsSelect.PromptCostDetails => "prompt_cost_details",
                RunStatsSelect.PromptTokenDetails => "prompt_token_details",
                RunStatsSelect.PromptTokens => "prompt_tokens",
                RunStatsSelect.PromptTokensP50 => "prompt_tokens_p50",
                RunStatsSelect.PromptTokensP99 => "prompt_tokens_p99",
                RunStatsSelect.RunCount => "run_count",
                RunStatsSelect.RunFacets => "run_facets",
                RunStatsSelect.SessionFeedbackStats => "session_feedback_stats",
                RunStatsSelect.StreamingRate => "streaming_rate",
                RunStatsSelect.ThreadFeedbackStats => "thread_feedback_stats",
                RunStatsSelect.TokensP99 => "tokens_p99",
                RunStatsSelect.TotalCost => "total_cost",
                RunStatsSelect.TotalTokens => "total_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStatsSelect? ToEnum(string value)
        {
            return value switch
            {
                "all_run_stats" => RunStatsSelect.AllRunStats,
                "all_token_stats" => RunStatsSelect.AllTokenStats,
                "completion_cost" => RunStatsSelect.CompletionCost,
                "completion_cost_details" => RunStatsSelect.CompletionCostDetails,
                "completion_token_details" => RunStatsSelect.CompletionTokenDetails,
                "completion_tokens" => RunStatsSelect.CompletionTokens,
                "completion_tokens_p50" => RunStatsSelect.CompletionTokensP50,
                "completion_tokens_p99" => RunStatsSelect.CompletionTokensP99,
                "cost_p50" => RunStatsSelect.CostP50,
                "cost_p99" => RunStatsSelect.CostP99,
                "error_rate" => RunStatsSelect.ErrorRate,
                "feedback_stats" => RunStatsSelect.FeedbackStats,
                "first_token_p50" => RunStatsSelect.FirstTokenP50,
                "first_token_p99" => RunStatsSelect.FirstTokenP99,
                "last_run_start_time" => RunStatsSelect.LastRunStartTime,
                "latency_avg" => RunStatsSelect.LatencyAvg,
                "latency_p50" => RunStatsSelect.LatencyP50,
                "latency_p99" => RunStatsSelect.LatencyP99,
                "median_tokens" => RunStatsSelect.MedianTokens,
                "prompt_cost" => RunStatsSelect.PromptCost,
                "prompt_cost_details" => RunStatsSelect.PromptCostDetails,
                "prompt_token_details" => RunStatsSelect.PromptTokenDetails,
                "prompt_tokens" => RunStatsSelect.PromptTokens,
                "prompt_tokens_p50" => RunStatsSelect.PromptTokensP50,
                "prompt_tokens_p99" => RunStatsSelect.PromptTokensP99,
                "run_count" => RunStatsSelect.RunCount,
                "run_facets" => RunStatsSelect.RunFacets,
                "session_feedback_stats" => RunStatsSelect.SessionFeedbackStats,
                "streaming_rate" => RunStatsSelect.StreamingRate,
                "thread_feedback_stats" => RunStatsSelect.ThreadFeedbackStats,
                "tokens_p99" => RunStatsSelect.TokensP99,
                "total_cost" => RunStatsSelect.TotalCost,
                "total_tokens" => RunStatsSelect.TotalTokens,
                _ => null,
            };
        }
    }
}