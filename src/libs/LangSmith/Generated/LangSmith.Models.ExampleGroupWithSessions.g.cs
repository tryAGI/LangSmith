
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Group of examples with a specific metadata value across multiple sessions.<br/>
    /// Extends RunGroupBase with:<br/>
    /// - group_key: metadata value that defines this group<br/>
    /// - sessions: per-session stats for runs matching this metadata value<br/>
    /// - examples: shared examples across all sessions (intersection logic)<br/>
    ///             with flat array of runs (each run has session_id field for frontend to determine column)<br/>
    /// - example_count: unique example count (pagination-aware, same across all sessions due to intersection)<br/>
    /// Inherited from RunGroupBase:<br/>
    /// - filter: metadata filter for this group (e.g., "and(eq(is_root, true), and(eq(metadata_key, 'model'), eq(metadata_value, 'gpt-4')))")<br/>
    /// - count: total run count across all sessions (includes duplicate runs)<br/>
    /// - total_tokens, total_cost: aggregate across sessions<br/>
    /// - min_start_time, max_start_time: time range across sessions<br/>
    /// - latency_p50, latency_p99: aggregate latency stats across sessions<br/>
    /// - feedback_stats: weighted average feedback across sessions<br/>
    /// Additional aggregate stats (from ExampleWithRunsGroup):<br/>
    /// - prompt_tokens, completion_tokens: separate token counts<br/>
    /// - prompt_cost, completion_cost: separate costs<br/>
    /// - error_rate: average error rate
    /// </summary>
    public sealed partial class ExampleGroupWithSessions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        public string? TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_start_time")]
        public global::System.DateTime? MinStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_start_time")]
        public global::System.DateTime? MaxStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_p50")]
        public double? LatencyP50 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_p99")]
        public double? LatencyP99 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_stats")]
        public object? FeedbackStats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, int?, double?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AnyOf<string, int?, double?> GroupKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.GroupedRunsSessionStats> Sessions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH> Examples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExampleCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost")]
        public string? PromptCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost")]
        public string? CompletionCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_rate")]
        public double? ErrorRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleGroupWithSessions" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="count"></param>
        /// <param name="totalTokens"></param>
        /// <param name="totalCost"></param>
        /// <param name="minStartTime"></param>
        /// <param name="maxStartTime"></param>
        /// <param name="latencyP50"></param>
        /// <param name="latencyP99"></param>
        /// <param name="feedbackStats"></param>
        /// <param name="groupKey"></param>
        /// <param name="sessions"></param>
        /// <param name="examples"></param>
        /// <param name="exampleCount"></param>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="promptCost"></param>
        /// <param name="completionCost"></param>
        /// <param name="errorRate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExampleGroupWithSessions(
            string filter,
            global::LangSmith.AnyOf<string, int?, double?> groupKey,
            global::System.Collections.Generic.IList<global::LangSmith.GroupedRunsSessionStats> sessions,
            global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH> examples,
            int exampleCount,
            int? count,
            int? totalTokens,
            string? totalCost,
            global::System.DateTime? minStartTime,
            global::System.DateTime? maxStartTime,
            double? latencyP50,
            double? latencyP99,
            object? feedbackStats,
            int? promptTokens,
            int? completionTokens,
            string? promptCost,
            string? completionCost,
            double? errorRate)
        {
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.GroupKey = groupKey;
            this.Sessions = sessions ?? throw new global::System.ArgumentNullException(nameof(sessions));
            this.Examples = examples ?? throw new global::System.ArgumentNullException(nameof(examples));
            this.ExampleCount = exampleCount;
            this.Count = count;
            this.TotalTokens = totalTokens;
            this.TotalCost = totalCost;
            this.MinStartTime = minStartTime;
            this.MaxStartTime = maxStartTime;
            this.LatencyP50 = latencyP50;
            this.LatencyP99 = latencyP99;
            this.FeedbackStats = feedbackStats;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.PromptCost = promptCost;
            this.CompletionCost = completionCost;
            this.ErrorRate = errorRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleGroupWithSessions" /> class.
        /// </summary>
        public ExampleGroupWithSessions()
        {
        }
    }
}