
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryQueryTracesRequestBody
    {
        /// <summary>
        /// `cursor` is the opaque string returned in a previous response's `next_cursor`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// `max_start_time` is the exclusive upper bound for the root-run start time scan (RFC3339). Defaults to the request time when omitted.<br/>
        /// Example: 2024-12-31T23:59:59Z
        /// </summary>
        /// <example>2024-12-31T23:59:59Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_start_time")]
        public global::System.DateTime? MaxStartTime { get; set; }

        /// <summary>
        /// `min_start_time` is the inclusive lower bound for the root-run start time scan (RFC3339). Defaults to 24 hours before the request when omitted.<br/>
        /// Example: 2024-01-01T00:00:00Z
        /// </summary>
        /// <example>2024-01-01T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_start_time")]
        public global::System.DateTime? MinStartTime { get; set; }

        /// <summary>
        /// `page_size` is the maximum number of traces to return per page. Defaults to 20; must be between 1 and 100 when set.<br/>
        /// Default Value: 20<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// `project_id` is the UUID of the tracing project that owns the traces. Required.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </summary>
        /// <example>018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// `selects` lists which properties to include on each returned trace. Properties listed here are routed to the appropriate sub-object on each item: `total_tokens`, `total_cost`, and `first_token_time` appear under `trace_aggregates`; everything else appears under `root_run`. If omitted, only `id` is returned on `root_run`.<br/>
        /// Example: [ID, NAME, START_TIME, STATUS, TOTAL_TOKENS, TOTAL_COST, FIRST_TOKEN_TIME]
        /// </summary>
        /// <example>[ID, NAME, START_TIME, STATUS, TOTAL_TOKENS, TOTAL_COST, FIRST_TOKEN_TIME]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("selects")]
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunSelectField>? Selects { get; set; }

        /// <summary>
        /// `trace_filter` narrows results to traces whose root run matches this LangSmith filter expression. This filter targets root runs only — `is_root = true` is implied.<br/>
        /// See https://docs.langchain.com/langsmith/trace-query-syntax#filter-query-language for syntax.<br/>
        /// Example: eq(status, "error")
        /// </summary>
        /// <example>eq(status, "error")</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_filter")]
        public string? TraceFilter { get; set; }

        /// <summary>
        /// `trace_ids` is an optional fast-path restriction to a known set of trace UUIDs. Equivalent in result to including each UUID in a `trace_filter`, but more efficient at scale.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? TraceIds { get; set; }

        /// <summary>
        /// `tree_filter` narrows results to traces containing at least one run anywhere in the run tree (root or descendant) that matches this LangSmith filter expression.<br/>
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
        /// Initializes a new instance of the <see cref="QueryQueryTracesRequestBody" /> class.
        /// </summary>
        /// <param name="cursor">
        /// `cursor` is the opaque string returned in a previous response's `next_cursor`.
        /// </param>
        /// <param name="maxStartTime">
        /// `max_start_time` is the exclusive upper bound for the root-run start time scan (RFC3339). Defaults to the request time when omitted.<br/>
        /// Example: 2024-12-31T23:59:59Z
        /// </param>
        /// <param name="minStartTime">
        /// `min_start_time` is the inclusive lower bound for the root-run start time scan (RFC3339). Defaults to 24 hours before the request when omitted.<br/>
        /// Example: 2024-01-01T00:00:00Z
        /// </param>
        /// <param name="pageSize">
        /// `page_size` is the maximum number of traces to return per page. Defaults to 20; must be between 1 and 100 when set.<br/>
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="projectId">
        /// `project_id` is the UUID of the tracing project that owns the traces. Required.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </param>
        /// <param name="selects">
        /// `selects` lists which properties to include on each returned trace. Properties listed here are routed to the appropriate sub-object on each item: `total_tokens`, `total_cost`, and `first_token_time` appear under `trace_aggregates`; everything else appears under `root_run`. If omitted, only `id` is returned on `root_run`.<br/>
        /// Example: [ID, NAME, START_TIME, STATUS, TOTAL_TOKENS, TOTAL_COST, FIRST_TOKEN_TIME]
        /// </param>
        /// <param name="traceFilter">
        /// `trace_filter` narrows results to traces whose root run matches this LangSmith filter expression. This filter targets root runs only — `is_root = true` is implied.<br/>
        /// See https://docs.langchain.com/langsmith/trace-query-syntax#filter-query-language for syntax.<br/>
        /// Example: eq(status, "error")
        /// </param>
        /// <param name="traceIds">
        /// `trace_ids` is an optional fast-path restriction to a known set of trace UUIDs. Equivalent in result to including each UUID in a `trace_filter`, but more efficient at scale.
        /// </param>
        /// <param name="treeFilter">
        /// `tree_filter` narrows results to traces containing at least one run anywhere in the run tree (root or descendant) that matches this LangSmith filter expression.<br/>
        /// Example: has(tags, "production")
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryQueryTracesRequestBody(
            string? cursor,
            global::System.DateTime? maxStartTime,
            global::System.DateTime? minStartTime,
            int? pageSize,
            global::System.Guid? projectId,
            global::System.Collections.Generic.IList<global::LangSmith.QueryRunSelectField>? selects,
            string? traceFilter,
            global::System.Collections.Generic.IList<global::System.Guid>? traceIds,
            string? treeFilter)
        {
            this.Cursor = cursor;
            this.MaxStartTime = maxStartTime;
            this.MinStartTime = minStartTime;
            this.PageSize = pageSize;
            this.ProjectId = projectId;
            this.Selects = selects;
            this.TraceFilter = traceFilter;
            this.TraceIds = traceIds;
            this.TreeFilter = treeFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryQueryTracesRequestBody" /> class.
        /// </summary>
        public QueryQueryTracesRequestBody()
        {
        }

    }
}