#nullable enable

namespace LangSmith
{
    public partial interface IFleetThreadsClient
    {
        /// <summary>
        /// Create a thread and start a run<br/>
        /// Creates a thread bound to `agent_id` and starts a run on it in one call. Returns the upstream run record (pending/running, not yet complete). Run kwargs are passed through; thread-creation flags go in the optional `thread` envelope. The new thread is rolled back if the run fails to start.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateAThreadAndStartARunAsync(

            global::LangSmith.ThreadsCreateThreadAndRunRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a thread and start a run<br/>
        /// Creates a thread bound to `agent_id` and starts a run on it in one call. Returns the upstream run record (pending/running, not yet complete). Run kwargs are passed through; thread-creation flags go in the optional `thread` envelope. The new thread is rolled back if the run fails to start.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<string>> CreateAThreadAndStartARunAsResponseAsync(

            global::LangSmith.ThreadsCreateThreadAndRunRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a thread and start a run<br/>
        /// Creates a thread bound to `agent_id` and starts a run on it in one call. Returns the upstream run record (pending/running, not yet complete). Run kwargs are passed through; thread-creation flags go in the optional `thread` envelope. The new thread is rolled back if the run fails to start.
        /// </summary>
        /// <param name="agentId">
        /// Example: 11111111-1111-1111-1111-111111111111
        /// </param>
        /// <param name="thread"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateAThreadAndStartARunAsync(
            string? agentId = default,
            global::LangSmith.ThreadsCreateThreadAndRunThread? thread = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}