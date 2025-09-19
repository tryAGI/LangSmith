
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
        RunCount,
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
        LatencyAvg,
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
        TotalTokens,
        /// <summary>
        /// 
        /// </summary>
        PromptTokens,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        MedianTokens,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokensP50,
        /// <summary>
        /// 
        /// </summary>
        PromptTokensP50,
        /// <summary>
        /// 
        /// </summary>
        TokensP99,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokensP99,
        /// <summary>
        /// 
        /// </summary>
        PromptTokensP99,
        /// <summary>
        /// 
        /// </summary>
        LastRunStartTime,
        /// <summary>
        /// 
        /// </summary>
        FeedbackStats,
        /// <summary>
        /// 
        /// </summary>
        RunFacets,
        /// <summary>
        /// 
        /// </summary>
        ErrorRate,
        /// <summary>
        /// 
        /// </summary>
        StreamingRate,
        /// <summary>
        /// 
        /// </summary>
        TotalCost,
        /// <summary>
        /// 
        /// </summary>
        PromptCost,
        /// <summary>
        /// 
        /// </summary>
        CompletionCost,
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
        SessionFeedbackStats,
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
        PromptTokenDetails,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokenDetails,
        /// <summary>
        /// 
        /// </summary>
        PromptCostDetails,
        /// <summary>
        /// 
        /// </summary>
        CompletionCostDetails,
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
                RunStatsSelect.RunCount => "run_count",
                RunStatsSelect.LatencyP50 => "latency_p50",
                RunStatsSelect.LatencyP99 => "latency_p99",
                RunStatsSelect.LatencyAvg => "latency_avg",
                RunStatsSelect.FirstTokenP50 => "first_token_p50",
                RunStatsSelect.FirstTokenP99 => "first_token_p99",
                RunStatsSelect.TotalTokens => "total_tokens",
                RunStatsSelect.PromptTokens => "prompt_tokens",
                RunStatsSelect.CompletionTokens => "completion_tokens",
                RunStatsSelect.MedianTokens => "median_tokens",
                RunStatsSelect.CompletionTokensP50 => "completion_tokens_p50",
                RunStatsSelect.PromptTokensP50 => "prompt_tokens_p50",
                RunStatsSelect.TokensP99 => "tokens_p99",
                RunStatsSelect.CompletionTokensP99 => "completion_tokens_p99",
                RunStatsSelect.PromptTokensP99 => "prompt_tokens_p99",
                RunStatsSelect.LastRunStartTime => "last_run_start_time",
                RunStatsSelect.FeedbackStats => "feedback_stats",
                RunStatsSelect.RunFacets => "run_facets",
                RunStatsSelect.ErrorRate => "error_rate",
                RunStatsSelect.StreamingRate => "streaming_rate",
                RunStatsSelect.TotalCost => "total_cost",
                RunStatsSelect.PromptCost => "prompt_cost",
                RunStatsSelect.CompletionCost => "completion_cost",
                RunStatsSelect.CostP50 => "cost_p50",
                RunStatsSelect.CostP99 => "cost_p99",
                RunStatsSelect.SessionFeedbackStats => "session_feedback_stats",
                RunStatsSelect.AllRunStats => "all_run_stats",
                RunStatsSelect.AllTokenStats => "all_token_stats",
                RunStatsSelect.PromptTokenDetails => "prompt_token_details",
                RunStatsSelect.CompletionTokenDetails => "completion_token_details",
                RunStatsSelect.PromptCostDetails => "prompt_cost_details",
                RunStatsSelect.CompletionCostDetails => "completion_cost_details",
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
                "run_count" => RunStatsSelect.RunCount,
                "latency_p50" => RunStatsSelect.LatencyP50,
                "latency_p99" => RunStatsSelect.LatencyP99,
                "latency_avg" => RunStatsSelect.LatencyAvg,
                "first_token_p50" => RunStatsSelect.FirstTokenP50,
                "first_token_p99" => RunStatsSelect.FirstTokenP99,
                "total_tokens" => RunStatsSelect.TotalTokens,
                "prompt_tokens" => RunStatsSelect.PromptTokens,
                "completion_tokens" => RunStatsSelect.CompletionTokens,
                "median_tokens" => RunStatsSelect.MedianTokens,
                "completion_tokens_p50" => RunStatsSelect.CompletionTokensP50,
                "prompt_tokens_p50" => RunStatsSelect.PromptTokensP50,
                "tokens_p99" => RunStatsSelect.TokensP99,
                "completion_tokens_p99" => RunStatsSelect.CompletionTokensP99,
                "prompt_tokens_p99" => RunStatsSelect.PromptTokensP99,
                "last_run_start_time" => RunStatsSelect.LastRunStartTime,
                "feedback_stats" => RunStatsSelect.FeedbackStats,
                "run_facets" => RunStatsSelect.RunFacets,
                "error_rate" => RunStatsSelect.ErrorRate,
                "streaming_rate" => RunStatsSelect.StreamingRate,
                "total_cost" => RunStatsSelect.TotalCost,
                "prompt_cost" => RunStatsSelect.PromptCost,
                "completion_cost" => RunStatsSelect.CompletionCost,
                "cost_p50" => RunStatsSelect.CostP50,
                "cost_p99" => RunStatsSelect.CostP99,
                "session_feedback_stats" => RunStatsSelect.SessionFeedbackStats,
                "all_run_stats" => RunStatsSelect.AllRunStats,
                "all_token_stats" => RunStatsSelect.AllTokenStats,
                "prompt_token_details" => RunStatsSelect.PromptTokenDetails,
                "completion_token_details" => RunStatsSelect.CompletionTokenDetails,
                "prompt_cost_details" => RunStatsSelect.PromptCostDetails,
                "completion_cost_details" => RunStatsSelect.CompletionCostDetails,
                _ => null,
            };
        }
    }
}