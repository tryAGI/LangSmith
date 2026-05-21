#nullable enable

namespace LangSmith
{
    public partial interface IFleetThreadsClient
    {
        /// <summary>
        /// Stream a thread run<br/>
        /// Start a run on a thread and stream its output as Server-Sent Events. The connection stays open until the run completes; the client is responsible for closing it.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StreamAThreadRunAsync(
            string threadId,

            global::LangSmith.ThreadsStreamRunRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream a thread run<br/>
        /// Start a run on a thread and stream its output as Server-Sent Events. The connection stays open until the run completes; the client is responsible for closing it.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<string>> StreamAThreadRunAsResponseAsync(
            string threadId,

            global::LangSmith.ThreadsStreamRunRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream a thread run<br/>
        /// Start a run on a thread and stream its output as Server-Sent Events. The connection stays open until the run completes; the client is responsible for closing it.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="agentId"></param>
        /// <param name="messages"></param>
        /// <param name="streamMode"></param>
        /// <param name="streamSubgraphs"></param>
        /// <param name="userTimezone"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StreamAThreadRunAsync(
            string threadId,
            global::System.Guid? agentId = default,
            global::System.Collections.Generic.IList<global::LangSmith.ThreadsMessage>? messages = default,
            global::System.Collections.Generic.IList<string>? streamMode = default,
            bool? streamSubgraphs = default,
            string? userTimezone = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}