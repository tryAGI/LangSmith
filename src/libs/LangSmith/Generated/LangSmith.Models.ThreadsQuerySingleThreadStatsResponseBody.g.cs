
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsQuerySingleThreadStatsResponseBody
    {
        /// <summary>
        /// `completion_cost` is the sum of per-trace completion costs across the thread, in USD. Populated when `COMPLETION_COST` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost")]
        public double? CompletionCost { get; set; }

        /// <summary>
        /// `completion_cost_details` is the per-sub-category sum of completion cost details across the thread. Populated when `COMPLETION_COST_DETAILS` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost_details")]
        public global::LangSmith.QueryRunCompletionCostDetails? CompletionCostDetails { get; set; }

        /// <summary>
        /// `completion_token_details` is the per-sub-category sum of completion token details across the thread. Populated when `COMPLETION_TOKEN_DETAILS` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_token_details")]
        public global::LangSmith.QueryRunCompletionTokenDetails? CompletionTokenDetails { get; set; }

        /// <summary>
        /// `completion_tokens` is the sum of per-trace completion token counts across the thread. Populated when `COMPLETION_TOKENS` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// `first_start_time` is the earliest trace start time in the thread (RFC3339). Populated when `FIRST_START_TIME` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_start_time")]
        public global::System.DateTime? FirstStartTime { get; set; }

        /// <summary>
        /// `last_end_time` is the latest trace end time in the thread (RFC3339). Populated when `LAST_END_TIME` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_end_time")]
        public global::System.DateTime? LastEndTime { get; set; }

        /// <summary>
        /// `last_start_time` is the latest trace start time in the thread (RFC3339). Populated when `LAST_START_TIME` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_start_time")]
        public global::System.DateTime? LastStartTime { get; set; }

        /// <summary>
        /// `latency_p50_seconds` is the approximate p50 of trace latency across the thread, in seconds. Populated when `LATENCY_P50` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_p50_seconds")]
        public double? LatencyP50Seconds { get; set; }

        /// <summary>
        /// `latency_p99_seconds` is the approximate p99 of trace latency across the thread, in seconds. Populated when `LATENCY_P99` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_p99_seconds")]
        public double? LatencyP99Seconds { get; set; }

        /// <summary>
        /// `prompt_cost` is the sum of per-trace prompt costs across the thread, in USD. Populated when `PROMPT_COST` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost")]
        public double? PromptCost { get; set; }

        /// <summary>
        /// `prompt_cost_details` is the per-sub-category sum of prompt cost details across the thread. Populated when `PROMPT_COST_DETAILS` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost_details")]
        public global::LangSmith.QueryRunPromptCostDetails? PromptCostDetails { get; set; }

        /// <summary>
        /// `prompt_token_details` is the per-sub-category sum of prompt token details across the thread. Populated when `PROMPT_TOKEN_DETAILS` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_token_details")]
        public global::LangSmith.QueryRunPromptTokenDetails? PromptTokenDetails { get; set; }

        /// <summary>
        /// `prompt_tokens` is the sum of per-trace prompt token counts across the thread. Populated when `PROMPT_TOKENS` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// `total_cost` is the sum of per-trace total costs across the thread, in USD. Populated when `TOTAL_COST` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// `total_tokens` is the sum of per-trace total token counts across the thread. Populated when `TOTAL_TOKENS` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// `turns` is the number of distinct traces (turns) in the thread. Populated when `TURNS` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turns")]
        public int? Turns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQuerySingleThreadStatsResponseBody" /> class.
        /// </summary>
        /// <param name="completionCost">
        /// `completion_cost` is the sum of per-trace completion costs across the thread, in USD. Populated when `COMPLETION_COST` is selected.
        /// </param>
        /// <param name="completionCostDetails">
        /// `completion_cost_details` is the per-sub-category sum of completion cost details across the thread. Populated when `COMPLETION_COST_DETAILS` is selected.
        /// </param>
        /// <param name="completionTokenDetails">
        /// `completion_token_details` is the per-sub-category sum of completion token details across the thread. Populated when `COMPLETION_TOKEN_DETAILS` is selected.
        /// </param>
        /// <param name="completionTokens">
        /// `completion_tokens` is the sum of per-trace completion token counts across the thread. Populated when `COMPLETION_TOKENS` is selected.
        /// </param>
        /// <param name="firstStartTime">
        /// `first_start_time` is the earliest trace start time in the thread (RFC3339). Populated when `FIRST_START_TIME` is selected.
        /// </param>
        /// <param name="lastEndTime">
        /// `last_end_time` is the latest trace end time in the thread (RFC3339). Populated when `LAST_END_TIME` is selected.
        /// </param>
        /// <param name="lastStartTime">
        /// `last_start_time` is the latest trace start time in the thread (RFC3339). Populated when `LAST_START_TIME` is selected.
        /// </param>
        /// <param name="latencyP50Seconds">
        /// `latency_p50_seconds` is the approximate p50 of trace latency across the thread, in seconds. Populated when `LATENCY_P50` is selected.
        /// </param>
        /// <param name="latencyP99Seconds">
        /// `latency_p99_seconds` is the approximate p99 of trace latency across the thread, in seconds. Populated when `LATENCY_P99` is selected.
        /// </param>
        /// <param name="promptCost">
        /// `prompt_cost` is the sum of per-trace prompt costs across the thread, in USD. Populated when `PROMPT_COST` is selected.
        /// </param>
        /// <param name="promptCostDetails">
        /// `prompt_cost_details` is the per-sub-category sum of prompt cost details across the thread. Populated when `PROMPT_COST_DETAILS` is selected.
        /// </param>
        /// <param name="promptTokenDetails">
        /// `prompt_token_details` is the per-sub-category sum of prompt token details across the thread. Populated when `PROMPT_TOKEN_DETAILS` is selected.
        /// </param>
        /// <param name="promptTokens">
        /// `prompt_tokens` is the sum of per-trace prompt token counts across the thread. Populated when `PROMPT_TOKENS` is selected.
        /// </param>
        /// <param name="totalCost">
        /// `total_cost` is the sum of per-trace total costs across the thread, in USD. Populated when `TOTAL_COST` is selected.
        /// </param>
        /// <param name="totalTokens">
        /// `total_tokens` is the sum of per-trace total token counts across the thread. Populated when `TOTAL_TOKENS` is selected.
        /// </param>
        /// <param name="turns">
        /// `turns` is the number of distinct traces (turns) in the thread. Populated when `TURNS` is selected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsQuerySingleThreadStatsResponseBody(
            double? completionCost,
            global::LangSmith.QueryRunCompletionCostDetails? completionCostDetails,
            global::LangSmith.QueryRunCompletionTokenDetails? completionTokenDetails,
            int? completionTokens,
            global::System.DateTime? firstStartTime,
            global::System.DateTime? lastEndTime,
            global::System.DateTime? lastStartTime,
            double? latencyP50Seconds,
            double? latencyP99Seconds,
            double? promptCost,
            global::LangSmith.QueryRunPromptCostDetails? promptCostDetails,
            global::LangSmith.QueryRunPromptTokenDetails? promptTokenDetails,
            int? promptTokens,
            double? totalCost,
            int? totalTokens,
            int? turns)
        {
            this.CompletionCost = completionCost;
            this.CompletionCostDetails = completionCostDetails;
            this.CompletionTokenDetails = completionTokenDetails;
            this.CompletionTokens = completionTokens;
            this.FirstStartTime = firstStartTime;
            this.LastEndTime = lastEndTime;
            this.LastStartTime = lastStartTime;
            this.LatencyP50Seconds = latencyP50Seconds;
            this.LatencyP99Seconds = latencyP99Seconds;
            this.PromptCost = promptCost;
            this.PromptCostDetails = promptCostDetails;
            this.PromptTokenDetails = promptTokenDetails;
            this.PromptTokens = promptTokens;
            this.TotalCost = totalCost;
            this.TotalTokens = totalTokens;
            this.Turns = turns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQuerySingleThreadStatsResponseBody" /> class.
        /// </summary>
        public ThreadsQuerySingleThreadStatsResponseBody()
        {
        }

    }
}