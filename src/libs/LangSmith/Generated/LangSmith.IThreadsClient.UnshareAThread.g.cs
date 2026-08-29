#nullable enable

namespace LangSmith
{
    public partial interface IThreadsClient
    {
        /// <summary>
        /// Unshare a thread<br/>
        /// Deletes the share token for a thread. Idempotent: returns 204<br/>
        /// whether or not a share token existed. Deliberately does not<br/>
        /// verify the thread still exists.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task UnshareAThreadAsync(
            string threadId,
            global::System.Guid projectId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unshare a thread<br/>
        /// Deletes the share token for a thread. Idempotent: returns 204<br/>
        /// whether or not a share token existed. Deliberately does not<br/>
        /// verify the thread still exists.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> UnshareAThreadAsResponseAsync(
            string threadId,
            global::System.Guid projectId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}