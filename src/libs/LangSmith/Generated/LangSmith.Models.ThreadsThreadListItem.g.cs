
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsThreadListItem
    {
        /// <summary>
        /// `count` is how many root traces (conversation turns) fall in this thread for the query time range.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// `feedback_stats` is the aggregated feedback across traces in the thread, keyed by feedback key; shape matches `feedback_stats` on a single run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_stats")]
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.QueryRunFeedbackStat>? FeedbackStats { get; set; }

        /// <summary>
        /// `first_inputs` is a truncated preview of inputs from the earliest trace in the thread for the query window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_inputs")]
        public string? FirstInputs { get; set; }

        /// <summary>
        /// `first_trace_id` is the root trace UUID for the chronologically first trace in the query time window.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </summary>
        /// <example>018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_trace_id")]
        public global::System.Guid? FirstTraceId { get; set; }

        /// <summary>
        /// `last_error` is a short error summary from the most recent failing trace in the thread. Absent when there is no error in the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_error")]
        public string? LastError { get; set; }

        /// <summary>
        /// `last_outputs` is a truncated preview of outputs from the latest trace in the thread for the query window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_outputs")]
        public string? LastOutputs { get; set; }

        /// <summary>
        /// `last_trace_id` is the root trace UUID for the chronologically last trace in the query time window.<br/>
        /// Example: 0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328
        /// </summary>
        /// <example>0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_trace_id")]
        public global::System.Guid? LastTraceId { get; set; }

        /// <summary>
        /// `latency_p50` is the approximate median end-to-end latency of traces in the thread, in seconds.<br/>
        /// Example: 0.15F
        /// </summary>
        /// <example>0.15F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_p50")]
        public double? LatencyP50 { get; set; }

        /// <summary>
        /// `latency_p99` is the approximate 99th percentile end-to-end latency of traces in the thread, in seconds.<br/>
        /// Example: 0.42F
        /// </summary>
        /// <example>0.42F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_p99")]
        public double? LatencyP99 { get; set; }

        /// <summary>
        /// `max_start_time` is the latest trace start time in the thread (RFC3339 date-time).<br/>
        /// Example: 2025-01-15T12:05:00.000Z
        /// </summary>
        /// <example>2025-01-15T12:05:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_start_time")]
        public global::System.DateTime? MaxStartTime { get; set; }

        /// <summary>
        /// `min_start_time` is the earliest trace start time in the thread (RFC3339 date-time).<br/>
        /// Example: 2025-01-15T12:00:00.000Z
        /// </summary>
        /// <example>2025-01-15T12:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_start_time")]
        public global::System.DateTime? MinStartTime { get; set; }

        /// <summary>
        /// `start_time` is a reference start time for this row (RFC3339 date-time), such as for sorting.<br/>
        /// Example: 2025-01-15T12:00:00.000Z
        /// </summary>
        /// <example>2025-01-15T12:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// `thread_id` identifies this conversation thread within the project from the request body `project_id`.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </summary>
        /// <example>018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public global::System.Guid? ThreadId { get; set; }

        /// <summary>
        /// `total_cost` is the sum of estimated USD cost across those traces.<br/>
        /// Example: 0.045F
        /// </summary>
        /// <example>0.045F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// `total_cost_details` sums per-category estimated USD cost across traces in the thread. Keys mirror `total_token_details`.<br/>
        /// Example: `{"cache_read": 0.012, "reasoning": 0.008}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost_details")]
        public global::System.Collections.Generic.Dictionary<string, double>? TotalCostDetails { get; set; }

        /// <summary>
        /// `total_token_details` sums per-category token counts across traces in the thread. Keys are model-specific category names (for example `cache_read`, `cache_write`, `reasoning`, `audio`).<br/>
        /// Example: `{"cache_read": 400, "reasoning": 120}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_token_details")]
        public global::System.Collections.Generic.Dictionary<string, long>? TotalTokenDetails { get; set; }

        /// <summary>
        /// `total_tokens` is the sum of token usage across those traces.<br/>
        /// Example: 450
        /// </summary>
        /// <example>450</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// `trace_id` is a representative root trace UUID when the summary includes one, for example for deep links.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9328
        /// </summary>
        /// <example>018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9328</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public global::System.Guid? TraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsThreadListItem" /> class.
        /// </summary>
        /// <param name="count">
        /// `count` is how many root traces (conversation turns) fall in this thread for the query time range.<br/>
        /// Example: 3
        /// </param>
        /// <param name="feedbackStats">
        /// `feedback_stats` is the aggregated feedback across traces in the thread, keyed by feedback key; shape matches `feedback_stats` on a single run.
        /// </param>
        /// <param name="firstInputs">
        /// `first_inputs` is a truncated preview of inputs from the earliest trace in the thread for the query window.
        /// </param>
        /// <param name="firstTraceId">
        /// `first_trace_id` is the root trace UUID for the chronologically first trace in the query time window.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </param>
        /// <param name="lastError">
        /// `last_error` is a short error summary from the most recent failing trace in the thread. Absent when there is no error in the window.
        /// </param>
        /// <param name="lastOutputs">
        /// `last_outputs` is a truncated preview of outputs from the latest trace in the thread for the query window.
        /// </param>
        /// <param name="lastTraceId">
        /// `last_trace_id` is the root trace UUID for the chronologically last trace in the query time window.<br/>
        /// Example: 0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328
        /// </param>
        /// <param name="latencyP50">
        /// `latency_p50` is the approximate median end-to-end latency of traces in the thread, in seconds.<br/>
        /// Example: 0.15F
        /// </param>
        /// <param name="latencyP99">
        /// `latency_p99` is the approximate 99th percentile end-to-end latency of traces in the thread, in seconds.<br/>
        /// Example: 0.42F
        /// </param>
        /// <param name="maxStartTime">
        /// `max_start_time` is the latest trace start time in the thread (RFC3339 date-time).<br/>
        /// Example: 2025-01-15T12:05:00.000Z
        /// </param>
        /// <param name="minStartTime">
        /// `min_start_time` is the earliest trace start time in the thread (RFC3339 date-time).<br/>
        /// Example: 2025-01-15T12:00:00.000Z
        /// </param>
        /// <param name="startTime">
        /// `start_time` is a reference start time for this row (RFC3339 date-time), such as for sorting.<br/>
        /// Example: 2025-01-15T12:00:00.000Z
        /// </param>
        /// <param name="threadId">
        /// `thread_id` identifies this conversation thread within the project from the request body `project_id`.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </param>
        /// <param name="totalCost">
        /// `total_cost` is the sum of estimated USD cost across those traces.<br/>
        /// Example: 0.045F
        /// </param>
        /// <param name="totalCostDetails">
        /// `total_cost_details` sums per-category estimated USD cost across traces in the thread. Keys mirror `total_token_details`.<br/>
        /// Example: `{"cache_read": 0.012, "reasoning": 0.008}`.
        /// </param>
        /// <param name="totalTokenDetails">
        /// `total_token_details` sums per-category token counts across traces in the thread. Keys are model-specific category names (for example `cache_read`, `cache_write`, `reasoning`, `audio`).<br/>
        /// Example: `{"cache_read": 400, "reasoning": 120}`.
        /// </param>
        /// <param name="totalTokens">
        /// `total_tokens` is the sum of token usage across those traces.<br/>
        /// Example: 450
        /// </param>
        /// <param name="traceId">
        /// `trace_id` is a representative root trace UUID when the summary includes one, for example for deep links.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9328
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsThreadListItem(
            int? count,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.QueryRunFeedbackStat>? feedbackStats,
            string? firstInputs,
            global::System.Guid? firstTraceId,
            string? lastError,
            string? lastOutputs,
            global::System.Guid? lastTraceId,
            double? latencyP50,
            double? latencyP99,
            global::System.DateTime? maxStartTime,
            global::System.DateTime? minStartTime,
            global::System.DateTime? startTime,
            global::System.Guid? threadId,
            double? totalCost,
            global::System.Collections.Generic.Dictionary<string, double>? totalCostDetails,
            global::System.Collections.Generic.Dictionary<string, long>? totalTokenDetails,
            int? totalTokens,
            global::System.Guid? traceId)
        {
            this.Count = count;
            this.FeedbackStats = feedbackStats;
            this.FirstInputs = firstInputs;
            this.FirstTraceId = firstTraceId;
            this.LastError = lastError;
            this.LastOutputs = lastOutputs;
            this.LastTraceId = lastTraceId;
            this.LatencyP50 = latencyP50;
            this.LatencyP99 = latencyP99;
            this.MaxStartTime = maxStartTime;
            this.MinStartTime = minStartTime;
            this.StartTime = startTime;
            this.ThreadId = threadId;
            this.TotalCost = totalCost;
            this.TotalCostDetails = totalCostDetails;
            this.TotalTokenDetails = totalTokenDetails;
            this.TotalTokens = totalTokens;
            this.TraceId = traceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsThreadListItem" /> class.
        /// </summary>
        public ThreadsThreadListItem()
        {
        }
    }
}