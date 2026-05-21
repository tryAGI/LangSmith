#nullable enable

namespace LangSmith
{
    public partial interface IFleetThreadsClient
    {
        /// <summary>
        /// Resolve an interrupted thread<br/>
        /// Completes a human-interrupt pause on the thread without sending new input, allowing execution to continue or finish. On success the response has no body.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task ResolveAnInterruptedThreadAsync(
            string threadId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve an interrupted thread<br/>
        /// Completes a human-interrupt pause on the thread without sending new input, allowing execution to continue or finish. On success the response has no body.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> ResolveAnInterruptedThreadAsResponseAsync(
            string threadId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}