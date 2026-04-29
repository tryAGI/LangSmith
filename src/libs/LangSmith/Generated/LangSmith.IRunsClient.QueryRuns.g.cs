#nullable enable

namespace LangSmith
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Query runs<br/>
        /// **Alpha:** The request and response contract may change;<br/>
        /// Returns a paginated list of runs for the given projects within min/max start_time. Supports filters, cursor pagination, and `selects` to select fields to return.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.QueryQueryRunsResponseBody> QueryRunsAsync(

            global::LangSmith.QueryQueryRunsRequestBody request,
            string? accept = default,
            string? contentType = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query runs<br/>
        /// **Alpha:** The request and response contract may change;<br/>
        /// Returns a paginated list of runs for the given projects within min/max start_time. Supports filters, cursor pagination, and `selects` to select fields to return.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="aiQuery">
        /// `ai_query` is a natural-language query to filter runs using AI.<br/>
        /// Example: runs that used tool calls
        /// </param>
        /// <param name="cursor">
        /// `cursor` is the opaque string from a previous response's `next_cursor`.<br/>
        /// Example: eyJsYXN0X2lkIjoiMDE4ZTRjN2UtYTlmYi03ZWYwLWE1YjYtNmVhM2E4MmU5MzI3In0=
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
        /// Example: [018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327, 0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328]
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
        /// <param name="sortOrder">
        /// `sort_order` is the sort direction for `start_time` (`ASC` or `DESC`). Defaults to `DESC` when omitted. Maps to the SmithDB proto `Order` field.<br/>
        /// Default Value: DESC<br/>
        /// Example: DESC
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.QueryQueryRunsResponseBody> QueryRunsAsync(
            string? accept = default,
            string? contentType = default,
            string? aiQuery = default,
            string? cursor = default,
            string? filter = default,
            bool? hasError = default,
            global::System.Collections.Generic.IList<global::System.Guid>? ids = default,
            bool? isRoot = default,
            global::System.DateTime? maxStartTime = default,
            global::System.DateTime? minStartTime = default,
            int? pageSize = default,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceExamples = default,
            global::LangSmith.QueryRunType? runType = default,
            global::System.Collections.Generic.IList<global::LangSmith.QueryRunSelectField>? selects = default,
            global::LangSmith.QuerySortOrder? sortOrder = default,
            string? traceFilter = default,
            global::System.Guid? traceId = default,
            string? treeFilter = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}