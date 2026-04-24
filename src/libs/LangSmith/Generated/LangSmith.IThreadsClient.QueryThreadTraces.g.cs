#nullable enable

namespace LangSmith
{
    public partial interface IThreadsClient
    {
        /// <summary>
        /// Query Thread Traces<br/>
        /// Retrieve all traces belonging to a specific thread within a project.<br/>
        /// Returns trace data decoded from Arrow IPC format via the smithdb<br/>
        /// QueryThreadTraces gRPC RPC.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="sessionId"></param>
        /// <param name="filter"></param>
        /// <param name="select"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="order"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> QueryThreadTracesAsync(
            string threadId,
            string sessionId,
            string? filter = default,
            string? select = default,
            int? limit = default,
            string? cursor = default,
            string? order = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}