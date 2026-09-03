#nullable enable

namespace LangSmith
{
    public partial interface IThreadsClient
    {
        /// <summary>
        /// Read a thread's share state<br/>
        /// Returns the share token for a thread. The token is omitted when<br/>
        /// the thread is not shared. Gated on runs:share so the control's<br/>
        /// state matches the control's permission.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadshareShareTokenResponseBody> ReadAThreadsShareStateAsync(
            string threadId,
            global::System.Guid projectId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Read a thread's share state<br/>
        /// Returns the share token for a thread. The token is omitted when<br/>
        /// the thread is not shared. Gated on runs:share so the control's<br/>
        /// state matches the control's permission.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ThreadshareShareTokenResponseBody>> ReadAThreadsShareStateAsResponseAsync(
            string threadId,
            global::System.Guid projectId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}