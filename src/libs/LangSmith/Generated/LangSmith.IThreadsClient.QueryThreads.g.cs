#nullable enable

namespace LangSmith
{
    public partial interface IThreadsClient
    {
        /// <summary>
        /// Query Threads<br/>
        /// **Alpha:** The request and response contract may change;<br/>
        /// Query threads within a project (session), with cursor-based pagination.<br/>
        /// Returns threads matching the given time range and optional filter.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadsQueryThreadsResponseBody> QueryThreadsAsync(

            global::LangSmith.ThreadsQueryThreadsRequestBody request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query Threads<br/>
        /// **Alpha:** The request and response contract may change;<br/>
        /// Query threads within a project (session), with cursor-based pagination.<br/>
        /// Returns threads matching the given time range and optional filter.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ThreadsQueryThreadsResponseBody>> QueryThreadsAsResponseAsync(

            global::LangSmith.ThreadsQueryThreadsRequestBody request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query Threads<br/>
        /// **Alpha:** The request and response contract may change;<br/>
        /// Query threads within a project (session), with cursor-based pagination.<br/>
        /// Returns threads matching the given time range and optional filter.
        /// </summary>
        /// <param name="cursor">
        /// `cursor` is the opaque string from a previous response's `next_cursor`. Omit on the first request; pass the returned cursor to fetch the next page.
        /// </param>
        /// <param name="filter">
        /// `filter` narrows which threads are returned, using a LangSmith filter expression evaluated against each thread's root run.<br/>
        /// For example: has(tags, "production") or eq(status, "error").<br/>
        /// See https://docs.langchain.com/langsmith/trace-query-syntax#filter-query-language for syntax.
        /// </param>
        /// <param name="maxStartTime">
        /// `max_start_time` is the exclusive upper bound on thread activity (RFC3339 date-time). Defaults to now (UTC) when omitted.
        /// </param>
        /// <param name="minStartTime">
        /// `min_start_time` is the inclusive lower bound on thread activity (RFC3339 date-time). Defaults to 1 day before now (UTC) when omitted.
        /// </param>
        /// <param name="pageSize">
        /// `page_size` is the maximum number of threads to return in this response. Defaults to 20 when omitted; must be between 1 and 100 inclusive when set. The response may contain fewer threads than `page_size` even when `next_cursor` is non-null.<br/>
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="projectId">
        /// `project_id` is the tracing project UUID.<br/>
        /// Example: 0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadsQueryThreadsResponseBody> QueryThreadsAsync(
            string? cursor = default,
            string? filter = default,
            global::System.DateTime? maxStartTime = default,
            global::System.DateTime? minStartTime = default,
            int? pageSize = default,
            global::System.Guid? projectId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}