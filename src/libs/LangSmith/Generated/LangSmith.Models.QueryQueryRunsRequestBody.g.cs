
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryQueryRunsRequestBody
    {
        /// <summary>
        /// `cursor` is the opaque string from a previous response's `next_cursor`. Treat it as opaque and pass it back unmodified.<br/>
        /// Example: eyJ2IjoxLCJhIjoicnVucy5xdWVyeSIsImsiOiJwYXNzIiwiYiI6InNkYiIsInQiOiJsdChjdXJzb3IsICcyMDI1LTEyLTEyIDE5OjAzOjI4LjQ4MTI1NTAxOWIxM2YyJykifQ
        /// </summary>
        /// <example>eyJ2IjoxLCJhIjoicnVucy5xdWVyeSIsImsiOiJwYXNzIiwiYiI6InNkYiIsInQiOiJsdChjdXJzb3IsICcyMDI1LTEyLTEyIDE5OjAzOjI4LjQ4MTI1NTAxOWIxM2YyJykifQ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// `filter` narrows results to runs matching this LangSmith filter expression, evaluated against each individual run.<br/>
        /// For example: and(eq(run_type, "llm"), gt(latency, 5)) or eq(status, "error").<br/>
        /// See https://docs.langchain.com/langsmith/trace-query-syntax#filter-query-language for syntax.<br/>
        /// Example: and(eq(run_type, "llm"), gt(latency, 5))
        /// </summary>
        /// <example>and(eq(run_type, "llm"), gt(latency, 5))</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// `has_error` filters to runs that errored (true) or completed without error (false).<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_error")]
        public bool? HasError { get; set; }

        /// <summary>
        /// `ids` optionally limits the request to these run UUIDs.<br/>
        /// Example: [018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327, f47ac10b-58cc-4372-a567-0e02b2c3d479]
        /// </summary>
        /// <example>[018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327, f47ac10b-58cc-4372-a567-0e02b2c3d479]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Ids { get; set; }

        /// <summary>
        /// `is_root` returns only root runs (true) or only non-root runs (false).<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_root")]
        public bool? IsRoot { get; set; }

        /// <summary>
        /// `max_start_time` is the upper bound for run `start_time` (RFC3339). Defaults to now.<br/>
        /// Example: 2024-12-31T23:59:59Z
        /// </summary>
        /// <example>2024-12-31T23:59:59Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_start_time")]
        public global::System.DateTime? MaxStartTime { get; set; }

        /// <summary>
        /// `min_start_time` is the lower bound for run `start_time` (RFC3339). Defaults to 1 day ago.<br/>
        /// Example: 2024-01-01T00:00:00Z
        /// </summary>
        /// <example>2024-01-01T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_start_time")]
        public global::System.DateTime? MinStartTime { get; set; }

        /// <summary>
        /// `page_size` is the maximum number of runs to return in this response. Defaults to 100 when omitted; must be between 1 and 1000 inclusive when set.<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// `project_ids` lists tracing project UUIDs to query.<br/>
        /// Required unless `reference_dataset_id` is set. Mutually exclusive with `reference_dataset_id` — set exactly one of them.<br/>
        /// Example: [018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327, 0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328]
        /// </summary>
        /// <example>[018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327, 0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ProjectIds { get; set; }

        /// <summary>
        /// `reference_dataset_id` resolves session IDs server-side from the dataset.<br/>
        /// Required unless `project_ids` is set. Mutually exclusive with `project_ids` — set exactly one of them.<br/>
        /// When provided and `min_start_time` is omitted, the server derives it from the earliest session creation date.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </summary>
        /// <example>018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_dataset_id")]
        public global::System.Guid? ReferenceDatasetId { get; set; }

        /// <summary>
        /// `reference_examples` optionally limits to runs linked to these dataset example UUIDs.<br/>
        /// Example: [b2c3d4e5-f6a7-4b5c-9d0e-1f2a3b4c5d6e, c3d4e5f6-a7b8-4c5d-0e1f-2a3b4c5d6e7f]
        /// </summary>
        /// <example>[b2c3d4e5-f6a7-4b5c-9d0e-1f2a3b4c5d6e, c3d4e5f6-a7b8-4c5d-0e1f-2a3b4c5d6e7f]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_examples")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceExamples { get; set; }

        /// <summary>
        /// `run_type`, when set, restricts results to runs whose `run_type` equals this value.<br/>
        /// Example: LLM
        /// </summary>
        /// <example>LLM</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.QueryRunTypeJsonConverter))]
        public global::LangSmith.QueryRunType? RunType { get; set; }

        /// <summary>
        /// `selects` lists which properties to include on each returned run. If omitted, only `id` is returned. Properties not listed are omitted from each run object.<br/>
        /// Example: [ID, NAME, PROJECT_ID, START_TIME, RUN_TYPE, STATUS]
        /// </summary>
        /// <example>[ID, NAME, PROJECT_ID, START_TIME, RUN_TYPE, STATUS]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("selects")]
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunSelectField>? Selects { get; set; }

        /// <summary>
        /// `trace_filter` narrows results to runs whose root trace matches this LangSmith filter expression.<br/>
        /// Use this to filter by properties of the trace's root run — for example eq(status, "success") to include only traces that completed without error.<br/>
        /// See https://docs.langchain.com/langsmith/trace-query-syntax#filter-query-language for syntax.<br/>
        /// Example: eq(status, "success")
        /// </summary>
        /// <example>eq(status, "success")</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_filter")]
        public string? TraceFilter { get; set; }

        /// <summary>
        /// `trace_id` optionally limits results to runs belonging to this trace UUID.<br/>
        /// Example: f47ac10b-58cc-4372-a567-0e02b2c3d479
        /// </summary>
        /// <example>f47ac10b-58cc-4372-a567-0e02b2c3d479</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public global::System.Guid? TraceId { get; set; }

        /// <summary>
        /// `tree_filter` narrows results to runs that belong to a trace containing at least one run matching this LangSmith filter expression anywhere in the run tree (not just the root).<br/>
        /// Use this to find runs inside traces that involved a specific tool, tag, or model — for example has(tags, "production") or eq(name, "my_tool").<br/>
        /// See https://docs.langchain.com/langsmith/trace-query-syntax#filter-query-language for syntax.<br/>
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
        /// Initializes a new instance of the <see cref="QueryQueryRunsRequestBody" /> class.
        /// </summary>
        /// <param name="cursor">
        /// `cursor` is the opaque string from a previous response's `next_cursor`. Treat it as opaque and pass it back unmodified.<br/>
        /// Example: eyJ2IjoxLCJhIjoicnVucy5xdWVyeSIsImsiOiJwYXNzIiwiYiI6InNkYiIsInQiOiJsdChjdXJzb3IsICcyMDI1LTEyLTEyIDE5OjAzOjI4LjQ4MTI1NTAxOWIxM2YyJykifQ
        /// </param>
        /// <param name="filter">
        /// `filter` narrows results to runs matching this LangSmith filter expression, evaluated against each individual run.<br/>
        /// For example: and(eq(run_type, "llm"), gt(latency, 5)) or eq(status, "error").<br/>
        /// See https://docs.langchain.com/langsmith/trace-query-syntax#filter-query-language for syntax.<br/>
        /// Example: and(eq(run_type, "llm"), gt(latency, 5))
        /// </param>
        /// <param name="hasError">
        /// `has_error` filters to runs that errored (true) or completed without error (false).<br/>
        /// Example: false
        /// </param>
        /// <param name="ids">
        /// `ids` optionally limits the request to these run UUIDs.<br/>
        /// Example: [018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327, f47ac10b-58cc-4372-a567-0e02b2c3d479]
        /// </param>
        /// <param name="isRoot">
        /// `is_root` returns only root runs (true) or only non-root runs (false).<br/>
        /// Example: true
        /// </param>
        /// <param name="maxStartTime">
        /// `max_start_time` is the upper bound for run `start_time` (RFC3339). Defaults to now.<br/>
        /// Example: 2024-12-31T23:59:59Z
        /// </param>
        /// <param name="minStartTime">
        /// `min_start_time` is the lower bound for run `start_time` (RFC3339). Defaults to 1 day ago.<br/>
        /// Example: 2024-01-01T00:00:00Z
        /// </param>
        /// <param name="pageSize">
        /// `page_size` is the maximum number of runs to return in this response. Defaults to 100 when omitted; must be between 1 and 1000 inclusive when set.<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </param>
        /// <param name="projectIds">
        /// `project_ids` lists tracing project UUIDs to query.<br/>
        /// Required unless `reference_dataset_id` is set. Mutually exclusive with `reference_dataset_id` — set exactly one of them.<br/>
        /// Example: [018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327, 0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328]
        /// </param>
        /// <param name="referenceDatasetId">
        /// `reference_dataset_id` resolves session IDs server-side from the dataset.<br/>
        /// Required unless `project_ids` is set. Mutually exclusive with `project_ids` — set exactly one of them.<br/>
        /// When provided and `min_start_time` is omitted, the server derives it from the earliest session creation date.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </param>
        /// <param name="referenceExamples">
        /// `reference_examples` optionally limits to runs linked to these dataset example UUIDs.<br/>
        /// Example: [b2c3d4e5-f6a7-4b5c-9d0e-1f2a3b4c5d6e, c3d4e5f6-a7b8-4c5d-0e1f-2a3b4c5d6e7f]
        /// </param>
        /// <param name="runType">
        /// `run_type`, when set, restricts results to runs whose `run_type` equals this value.<br/>
        /// Example: LLM
        /// </param>
        /// <param name="selects">
        /// `selects` lists which properties to include on each returned run. If omitted, only `id` is returned. Properties not listed are omitted from each run object.<br/>
        /// Example: [ID, NAME, PROJECT_ID, START_TIME, RUN_TYPE, STATUS]
        /// </param>
        /// <param name="traceFilter">
        /// `trace_filter` narrows results to runs whose root trace matches this LangSmith filter expression.<br/>
        /// Use this to filter by properties of the trace's root run — for example eq(status, "success") to include only traces that completed without error.<br/>
        /// See https://docs.langchain.com/langsmith/trace-query-syntax#filter-query-language for syntax.<br/>
        /// Example: eq(status, "success")
        /// </param>
        /// <param name="traceId">
        /// `trace_id` optionally limits results to runs belonging to this trace UUID.<br/>
        /// Example: f47ac10b-58cc-4372-a567-0e02b2c3d479
        /// </param>
        /// <param name="treeFilter">
        /// `tree_filter` narrows results to runs that belong to a trace containing at least one run matching this LangSmith filter expression anywhere in the run tree (not just the root).<br/>
        /// Use this to find runs inside traces that involved a specific tool, tag, or model — for example has(tags, "production") or eq(name, "my_tool").<br/>
        /// See https://docs.langchain.com/langsmith/trace-query-syntax#filter-query-language for syntax.<br/>
        /// Example: has(tags, "production")
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryQueryRunsRequestBody(
            string? cursor,
            string? filter,
            bool? hasError,
            global::System.Collections.Generic.IList<global::System.Guid>? ids,
            bool? isRoot,
            global::System.DateTime? maxStartTime,
            global::System.DateTime? minStartTime,
            int? pageSize,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds,
            global::System.Guid? referenceDatasetId,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceExamples,
            global::LangSmith.QueryRunType? runType,
            global::System.Collections.Generic.IList<global::LangSmith.QueryRunSelectField>? selects,
            string? traceFilter,
            global::System.Guid? traceId,
            string? treeFilter)
        {
            this.Cursor = cursor;
            this.Filter = filter;
            this.HasError = hasError;
            this.Ids = ids;
            this.IsRoot = isRoot;
            this.MaxStartTime = maxStartTime;
            this.MinStartTime = minStartTime;
            this.PageSize = pageSize;
            this.ProjectIds = projectIds;
            this.ReferenceDatasetId = referenceDatasetId;
            this.ReferenceExamples = referenceExamples;
            this.RunType = runType;
            this.Selects = selects;
            this.TraceFilter = traceFilter;
            this.TraceId = traceId;
            this.TreeFilter = treeFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryQueryRunsRequestBody" /> class.
        /// </summary>
        public QueryQueryRunsRequestBody()
        {
        }

    }
}