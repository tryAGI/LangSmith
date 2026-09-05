#nullable enable

namespace LangSmith
{
    public partial interface IThreadsClient
    {
        /// <summary>
        /// Query Thread Stats<br/>
        /// GET with body payload — no resources created. Returns aggregate statistics for threads in a tracing project.<br/>
        /// The response includes the thread counts, run counts, latency percentiles, rates, token totals, and cost totals requested in `select`.<br/>
        /// Self-hosted deployments require LangSmith `v0.17` or later.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadsQueryThreadStatsResponseBody> QueryThreadStatsAsync(

            global::LangSmith.ThreadsQueryThreadStatsRequestBody request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query Thread Stats<br/>
        /// GET with body payload — no resources created. Returns aggregate statistics for threads in a tracing project.<br/>
        /// The response includes the thread counts, run counts, latency percentiles, rates, token totals, and cost totals requested in `select`.<br/>
        /// Self-hosted deployments require LangSmith `v0.17` or later.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ThreadsQueryThreadStatsResponseBody>> QueryThreadStatsAsResponseAsync(

            global::LangSmith.ThreadsQueryThreadStatsRequestBody request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query Thread Stats<br/>
        /// GET with body payload — no resources created. Returns aggregate statistics for threads in a tracing project.<br/>
        /// The response includes the thread counts, run counts, latency percentiles, rates, token totals, and cost totals requested in `select`.<br/>
        /// Self-hosted deployments require LangSmith `v0.17` or later.
        /// </summary>
        /// <param name="maxStartTime">
        /// `max_start_time` is the exclusive upper bound on thread activity (RFC3339 date-time). Defaults to now (UTC) when omitted.
        /// </param>
        /// <param name="minStartTime">
        /// `min_start_time` is the inclusive lower bound on thread activity (RFC3339 date-time). Defaults to 1 day before now (UTC) when omitted.
        /// </param>
        /// <param name="projectId">
        /// `project_id` is the tracing project UUID.<br/>
        /// Example: 0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328
        /// </param>
        /// <param name="select">
        /// `select` lists the aggregate statistics to compute and return. At least one value is required.<br/>
        /// Example: [THREAD_COUNT, TRACE_COUNT, TOTAL_TOKENS, TOTAL_COST]
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadsQueryThreadStatsResponseBody> QueryThreadStatsAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadStatsSelectField> select,
            global::System.DateTime? maxStartTime = default,
            global::System.DateTime? minStartTime = default,
            string? threadFilter = default,
            string? traceFilter = default,
            string? treeFilter = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}