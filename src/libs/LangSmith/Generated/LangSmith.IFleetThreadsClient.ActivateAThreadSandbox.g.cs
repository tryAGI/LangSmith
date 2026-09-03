#nullable enable

namespace LangSmith
{
    public partial interface IFleetThreadsClient
    {
        /// <summary>
        /// Activate a thread sandbox<br/>
        /// Starts or resumes the sandbox referenced by the thread and returns when it is ready. The operation is idempotent. The thread must include sandbox.sandbox_slug.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadsSandboxRef> ActivateAThreadSandboxAsync(
            global::System.Guid threadId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Activate a thread sandbox<br/>
        /// Starts or resumes the sandbox referenced by the thread and returns when it is ready. The operation is idempotent. The thread must include sandbox.sandbox_slug.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ThreadsSandboxRef>> ActivateAThreadSandboxAsResponseAsync(
            global::System.Guid threadId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}