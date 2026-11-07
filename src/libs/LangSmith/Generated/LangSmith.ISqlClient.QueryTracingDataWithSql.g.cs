#nullable enable

namespace LangSmith
{
    public partial interface ISqlClient
    {
        /// <summary>
        /// Query tracing data with SQL<br/>
        /// **Beta:** This endpoint is in active development and may change without notice.<br/>
        /// GET with body payload — no resources created. Returns the rows matching the read-only SQL query passed as the request payload, limited to the given tracing projects. Results are limited to a configured number of rows, 1000 by default.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SqlqueryQueryResponse> QueryTracingDataWithSqlAsync(

            global::LangSmith.SqlqueryQueryRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query tracing data with SQL<br/>
        /// **Beta:** This endpoint is in active development and may change without notice.<br/>
        /// GET with body payload — no resources created. Returns the rows matching the read-only SQL query passed as the request payload, limited to the given tracing projects. Results are limited to a configured number of rows, 1000 by default.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SqlqueryQueryResponse>> QueryTracingDataWithSqlAsResponseAsync(

            global::LangSmith.SqlqueryQueryRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query tracing data with SQL<br/>
        /// **Beta:** This endpoint is in active development and may change without notice.<br/>
        /// GET with body payload — no resources created. Returns the rows matching the read-only SQL query passed as the request payload, limited to the given tracing projects. Results are limited to a configured number of rows, 1000 by default.
        /// </summary>
        /// <param name="projectIds">
        /// ProjectIDs are the tracing projects the query can read.
        /// </param>
        /// <param name="query">
        /// Query is a single read-only SQL statement. Queries over runs need a start_time lower bound.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SqlqueryQueryResponse> QueryTracingDataWithSqlAsync(
            global::System.Collections.Generic.IList<global::System.Guid> projectIds,
            string query,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}