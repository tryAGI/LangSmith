
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ThreadsQueryThreadStatsResponseBody
    {
        /// <summary>
        /// `completion_cost` is the completion cost across matching traces in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost")]
        public double? CompletionCost { get; set; }

        /// <summary>
        /// `completion_cost_details` contains completion-cost totals by category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost_details")]
        public global::System.Collections.Generic.Dictionary<string, double>? CompletionCostDetails { get; set; }

        /// <summary>
        /// `completion_token_details` contains completion-token totals by category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_token_details")]
        public global::System.Collections.Generic.Dictionary<string, long>? CompletionTokenDetails { get; set; }

        /// <summary>
        /// `completion_tokens` is the sum of completion tokens across matching traces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// `error_rate` is the fraction of matching traces that contain an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_rate")]
        public double? ErrorRate { get; set; }

        /// <summary>
        /// `first_token_p50_seconds` is the approximate median time to first token in seconds. Populated when `FIRST_TOKEN_P50` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_token_p50_seconds")]
        public double? FirstTokenP50Seconds { get; set; }

        /// <summary>
        /// `first_token_p99_seconds` is the approximate p99 time to first token in seconds. Populated when `FIRST_TOKEN_P99` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_token_p99_seconds")]
        public double? FirstTokenP99Seconds { get; set; }

        /// <summary>
        /// `latency_p50_seconds` is the approximate median trace latency in seconds. Populated when `LATENCY_P50` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_p50_seconds")]
        public double? LatencyP50Seconds { get; set; }

        /// <summary>
        /// `latency_p99_seconds` is the approximate p99 trace latency in seconds. Populated when `LATENCY_P99` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_p99_seconds")]
        public double? LatencyP99Seconds { get; set; }

        /// <summary>
        /// `median_tokens` is the approximate median of total tokens across matching traces. Populated when `MEDIAN_TOKENS` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("median_tokens")]
        public int? MedianTokens { get; set; }

        /// <summary>
        /// `prompt_cost` is the prompt cost across matching traces in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost")]
        public double? PromptCost { get; set; }

        /// <summary>
        /// `prompt_cost_details` contains prompt-cost totals by category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost_details")]
        public global::System.Collections.Generic.Dictionary<string, double>? PromptCostDetails { get; set; }

        /// <summary>
        /// `prompt_token_details` contains prompt-token totals by category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_token_details")]
        public global::System.Collections.Generic.Dictionary<string, long>? PromptTokenDetails { get; set; }

        /// <summary>
        /// `prompt_tokens` is the sum of prompt tokens across matching traces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// `streaming_rate` is the fraction of completed matching traces that streamed tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming_rate")]
        public double? StreamingRate { get; set; }

        /// <summary>
        /// `thread_count` is the number of distinct threads matching the query. Populated when `THREAD_COUNT` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_count")]
        public int? ThreadCount { get; set; }

        /// <summary>
        /// `thread_feedback_stats` contains aggregate thread-level feedback statistics keyed by feedback key. Populated when `THREAD_FEEDBACK_STATS` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_feedback_stats")]
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.QueryRunFeedbackStat>? ThreadFeedbackStats { get; set; }

        /// <summary>
        /// `total_cost` is the total cost across matching traces in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// `total_tokens` is the sum of all tokens across matching traces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// `trace_count` is the number of traces in the matching threads. Populated when `TRACE_COUNT` is selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_count")]
        public int? TraceCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQueryThreadStatsResponseBody" /> class.
        /// </summary>
        /// <param name="completionCost">
        /// `completion_cost` is the completion cost across matching traces in USD.
        /// </param>
        /// <param name="completionCostDetails">
        /// `completion_cost_details` contains completion-cost totals by category.
        /// </param>
        /// <param name="completionTokenDetails">
        /// `completion_token_details` contains completion-token totals by category.
        /// </param>
        /// <param name="completionTokens">
        /// `completion_tokens` is the sum of completion tokens across matching traces.
        /// </param>
        /// <param name="errorRate">
        /// `error_rate` is the fraction of matching traces that contain an error.
        /// </param>
        /// <param name="firstTokenP50Seconds">
        /// `first_token_p50_seconds` is the approximate median time to first token in seconds. Populated when `FIRST_TOKEN_P50` is selected.
        /// </param>
        /// <param name="firstTokenP99Seconds">
        /// `first_token_p99_seconds` is the approximate p99 time to first token in seconds. Populated when `FIRST_TOKEN_P99` is selected.
        /// </param>
        /// <param name="latencyP50Seconds">
        /// `latency_p50_seconds` is the approximate median trace latency in seconds. Populated when `LATENCY_P50` is selected.
        /// </param>
        /// <param name="latencyP99Seconds">
        /// `latency_p99_seconds` is the approximate p99 trace latency in seconds. Populated when `LATENCY_P99` is selected.
        /// </param>
        /// <param name="medianTokens">
        /// `median_tokens` is the approximate median of total tokens across matching traces. Populated when `MEDIAN_TOKENS` is selected.
        /// </param>
        /// <param name="promptCost">
        /// `prompt_cost` is the prompt cost across matching traces in USD.
        /// </param>
        /// <param name="promptCostDetails">
        /// `prompt_cost_details` contains prompt-cost totals by category.
        /// </param>
        /// <param name="promptTokenDetails">
        /// `prompt_token_details` contains prompt-token totals by category.
        /// </param>
        /// <param name="promptTokens">
        /// `prompt_tokens` is the sum of prompt tokens across matching traces.
        /// </param>
        /// <param name="streamingRate">
        /// `streaming_rate` is the fraction of completed matching traces that streamed tokens.
        /// </param>
        /// <param name="threadCount">
        /// `thread_count` is the number of distinct threads matching the query. Populated when `THREAD_COUNT` is selected.
        /// </param>
        /// <param name="threadFeedbackStats">
        /// `thread_feedback_stats` contains aggregate thread-level feedback statistics keyed by feedback key. Populated when `THREAD_FEEDBACK_STATS` is selected.
        /// </param>
        /// <param name="totalCost">
        /// `total_cost` is the total cost across matching traces in USD.
        /// </param>
        /// <param name="totalTokens">
        /// `total_tokens` is the sum of all tokens across matching traces.
        /// </param>
        /// <param name="traceCount">
        /// `trace_count` is the number of traces in the matching threads. Populated when `TRACE_COUNT` is selected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsQueryThreadStatsResponseBody(
            double? completionCost,
            global::System.Collections.Generic.Dictionary<string, double>? completionCostDetails,
            global::System.Collections.Generic.Dictionary<string, long>? completionTokenDetails,
            int? completionTokens,
            double? errorRate,
            double? firstTokenP50Seconds,
            double? firstTokenP99Seconds,
            double? latencyP50Seconds,
            double? latencyP99Seconds,
            int? medianTokens,
            double? promptCost,
            global::System.Collections.Generic.Dictionary<string, double>? promptCostDetails,
            global::System.Collections.Generic.Dictionary<string, long>? promptTokenDetails,
            int? promptTokens,
            double? streamingRate,
            int? threadCount,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.QueryRunFeedbackStat>? threadFeedbackStats,
            double? totalCost,
            int? totalTokens,
            int? traceCount)
        {
            this.CompletionCost = completionCost;
            this.CompletionCostDetails = completionCostDetails;
            this.CompletionTokenDetails = completionTokenDetails;
            this.CompletionTokens = completionTokens;
            this.ErrorRate = errorRate;
            this.FirstTokenP50Seconds = firstTokenP50Seconds;
            this.FirstTokenP99Seconds = firstTokenP99Seconds;
            this.LatencyP50Seconds = latencyP50Seconds;
            this.LatencyP99Seconds = latencyP99Seconds;
            this.MedianTokens = medianTokens;
            this.PromptCost = promptCost;
            this.PromptCostDetails = promptCostDetails;
            this.PromptTokenDetails = promptTokenDetails;
            this.PromptTokens = promptTokens;
            this.StreamingRate = streamingRate;
            this.ThreadCount = threadCount;
            this.ThreadFeedbackStats = threadFeedbackStats;
            this.TotalCost = totalCost;
            this.TotalTokens = totalTokens;
            this.TraceCount = traceCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQueryThreadStatsResponseBody" /> class.
        /// </summary>
        public ThreadsQueryThreadStatsResponseBody()
        {
        }

    }
}