#nullable enable

namespace LangSmith
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Query traces<br/>
        /// Returns a paginated list of traces (root runs) for a single tracing project. Each item carries the trace's root run plus optional trace-wide aggregates (`total_tokens`, `total_cost`, `first_token_time`) under `trace_aggregates`, so clients never have to merge by `trace_id`.<br/>
        /// Traces are scanned within a `start_time` window: `min_start_time` defaults to 24 hours before the request, `max_start_time` defaults to the request time. Set either explicitly to widen or narrow the window.<br/>
        /// Supports filters (`trace_filter`, `tree_filter`), cursor pagination (`cursor`), and field projection (`selects`).
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.QueryQueryTracesResponseBody> QueryTracesAsync(

            global::LangSmith.QueryQueryTracesRequestBody request,
            string? contentType = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query traces<br/>
        /// Returns a paginated list of traces (root runs) for a single tracing project. Each item carries the trace's root run plus optional trace-wide aggregates (`total_tokens`, `total_cost`, `first_token_time`) under `trace_aggregates`, so clients never have to merge by `trace_id`.<br/>
        /// Traces are scanned within a `start_time` window: `min_start_time` defaults to 24 hours before the request, `max_start_time` defaults to the request time. Set either explicitly to widen or narrow the window.<br/>
        /// Supports filters (`trace_filter`, `tree_filter`), cursor pagination (`cursor`), and field projection (`selects`).
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.QueryQueryTracesResponseBody>> QueryTracesAsResponseAsync(

            global::LangSmith.QueryQueryTracesRequestBody request,
            string? contentType = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query traces<br/>
        /// Returns a paginated list of traces (root runs) for a single tracing project. Each item carries the trace's root run plus optional trace-wide aggregates (`total_tokens`, `total_cost`, `first_token_time`) under `trace_aggregates`, so clients never have to merge by `trace_id`.<br/>
        /// Traces are scanned within a `start_time` window: `min_start_time` defaults to 24 hours before the request, `max_start_time` defaults to the request time. Set either explicitly to widen or narrow the window.<br/>
        /// Supports filters (`trace_filter`, `tree_filter`), cursor pagination (`cursor`), and field projection (`selects`).
        /// </summary>
        /// <param name="contentType"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.QueryQueryTracesResponseBody> QueryTracesAsync(
            string? contentType = default,
            string? cursor = default,
            global::System.DateTime? maxStartTime = default,
            global::System.DateTime? minStartTime = default,
            int? pageSize = default,
            global::System.Guid? projectId = default,
            global::System.Collections.Generic.IList<global::LangSmith.QueryRunSelectField>? selects = default,
            string? traceFilter = default,
            global::System.Collections.Generic.IList<global::System.Guid>? traceIds = default,
            string? treeFilter = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}