#nullable enable

namespace LangSmith
{
    public partial interface IFleetThreadsClient
    {
        /// <summary>
        /// Create a thread<br/>
        /// Create a thread, optionally bound to an agent. Subsequent runs are started on it via `POST /v1/fleet/threads/{thread_id}/runs/stream`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadsThread> CreateAThreadAsync(

            global::LangSmith.ThreadsCreateThreadRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a thread<br/>
        /// Create a thread, optionally bound to an agent. Subsequent runs are started on it via `POST /v1/fleet/threads/{thread_id}/runs/stream`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ThreadsThread>> CreateAThreadAsResponseAsync(

            global::LangSmith.ThreadsCreateThreadRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a thread<br/>
        /// Create a thread, optionally bound to an agent. Subsequent runs are started on it via `POST /v1/fleet/threads/{thread_id}/runs/stream`.
        /// </summary>
        /// <param name="agentId">
        /// Example: 11111111-1111-1111-1111-111111111111
        /// </param>
        /// <param name="ifExists"></param>
        /// <param name="metadata"></param>
        /// <param name="options"></param>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadsThread> CreateAThreadAsync(
            string? agentId = default,
            global::LangSmith.ThreadsCreateThreadRequestIfExists? ifExists = default,
            object? metadata = default,
            global::LangSmith.ThreadsCreateThreadOptions? options = default,
            global::System.Guid? threadId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}