
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ThreadsQueryThreadStatsRequestBody
    {
        /// <summary>
        /// `max_start_time` is the exclusive upper bound on thread activity (RFC3339 date-time). Defaults to now (UTC) when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_start_time")]
        public global::System.DateTime? MaxStartTime { get; set; }

        /// <summary>
        /// `min_start_time` is the inclusive lower bound on thread activity (RFC3339 date-time). Defaults to 1 day before now (UTC) when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_start_time")]
        public global::System.DateTime? MinStartTime { get; set; }

        /// <summary>
        /// `project_id` is the tracing project UUID.<br/>
        /// Example: 0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328
        /// </summary>
        /// <example>0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// `select` lists the aggregate statistics to compute and return. At least one value is required.<br/>
        /// Example: [THREAD_COUNT, TRACE_COUNT, TOTAL_TOKENS, TOTAL_COST]
        /// </summary>
        /// <example>[THREAD_COUNT, TRACE_COUNT, TOTAL_TOKENS, TOTAL_COST]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("select")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadStatsSelectField> Select { get; set; }

        /// <summary>
        /// `thread_filter` narrows eligible threads using a LangSmith filter expression evaluated against the complete thread summary.<br/>
        /// Example: gte(turn_count, 3)
        /// </summary>
        /// <example>gte(turn_count, 3)</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_filter")]
        public string? ThreadFilter { get; set; }

        /// <summary>
        /// `trace_filter` narrows eligible threads to those containing a trace whose root run matches this LangSmith filter expression.<br/>
        /// Example: eq(status, "error")
        /// </summary>
        /// <example>eq(status, "error")</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_filter")]
        public string? TraceFilter { get; set; }

        /// <summary>
        /// `tree_filter` narrows eligible threads to those containing a matching run anywhere in a trace tree.<br/>
        /// Example: has(tags, "production")
        /// </summary>
        /// <example>has(tags, "production")</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree_filter")]
        public string? TreeFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQueryThreadStatsRequestBody" /> class.
        /// </summary>
        /// <param name="projectId">
        /// `project_id` is the tracing project UUID.<br/>
        /// Example: 0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328
        /// </param>
        /// <param name="select">
        /// `select` lists the aggregate statistics to compute and return. At least one value is required.<br/>
        /// Example: [THREAD_COUNT, TRACE_COUNT, TOTAL_TOKENS, TOTAL_COST]
        /// </param>
        /// <param name="maxStartTime">
        /// `max_start_time` is the exclusive upper bound on thread activity (RFC3339 date-time). Defaults to now (UTC) when omitted.
        /// </param>
        /// <param name="minStartTime">
        /// `min_start_time` is the inclusive lower bound on thread activity (RFC3339 date-time). Defaults to 1 day before now (UTC) when omitted.
        /// </param>
        /// <param name="threadFilter">
        /// `thread_filter` narrows eligible threads using a LangSmith filter expression evaluated against the complete thread summary.<br/>
        /// Example: gte(turn_count, 3)
        /// </param>
        /// <param name="traceFilter">
        /// `trace_filter` narrows eligible threads to those containing a trace whose root run matches this LangSmith filter expression.<br/>
        /// Example: eq(status, "error")
        /// </param>
        /// <param name="treeFilter">
        /// `tree_filter` narrows eligible threads to those containing a matching run anywhere in a trace tree.<br/>
        /// Example: has(tags, "production")
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsQueryThreadStatsRequestBody(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadStatsSelectField> select,
            global::System.DateTime? maxStartTime,
            global::System.DateTime? minStartTime,
            string? threadFilter,
            string? traceFilter,
            string? treeFilter)
        {
            this.MaxStartTime = maxStartTime;
            this.MinStartTime = minStartTime;
            this.ProjectId = projectId;
            this.Select = select ?? throw new global::System.ArgumentNullException(nameof(select));
            this.ThreadFilter = threadFilter;
            this.TraceFilter = traceFilter;
            this.TreeFilter = treeFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQueryThreadStatsRequestBody" /> class.
        /// </summary>
        public ThreadsQueryThreadStatsRequestBody()
        {
        }

    }
}