#nullable enable

namespace LangSmith
{
    public partial interface IThreadsClient
    {
        /// <summary>
        /// Query Threads<br/>
        /// Query threads within a project (session), with cursor-based pagination.<br/>
        /// Returns threads matching the given time range and optional filter,<br/>
        /// backed by the smithdb QueryThreads gRPC RPC.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> QueryThreadsAsync(

            global::LangSmith.ThreadsQueryThreadsRequestBody request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query Threads<br/>
        /// Query threads within a project (session), with cursor-based pagination.<br/>
        /// Returns threads matching the given time range and optional filter,<br/>
        /// backed by the smithdb QueryThreads gRPC RPC.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="filter"></param>
        /// <param name="limit"></param>
        /// <param name="maxStartTime"></param>
        /// <param name="minStartTime"></param>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> QueryThreadsAsync(
            string? cursor = default,
            string? filter = default,
            int? limit = default,
            string? maxStartTime = default,
            string? minStartTime = default,
            string? sessionId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}