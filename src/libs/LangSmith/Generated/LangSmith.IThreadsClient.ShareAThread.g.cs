#nullable enable

namespace LangSmith
{
    public partial interface IThreadsClient
    {
        /// <summary>
        /// Share a thread<br/>
        /// Mints a public share token for a thread. Idempotent: sharing an<br/>
        /// already-shared thread returns the existing token.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadshareShareTokenResponseBody> ShareAThreadAsync(
            string threadId,

            global::LangSmith.ThreadshareCreateShareTokenRequestBody request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Share a thread<br/>
        /// Mints a public share token for a thread. Idempotent: sharing an<br/>
        /// already-shared thread returns the existing token.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ThreadshareShareTokenResponseBody>> ShareAThreadAsResponseAsync(
            string threadId,

            global::LangSmith.ThreadshareCreateShareTokenRequestBody request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Share a thread<br/>
        /// Mints a public share token for a thread. Idempotent: sharing an<br/>
        /// already-shared thread returns the existing token.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="projectId">
        /// project_id is the tracing project UUID containing the thread.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadshareShareTokenResponseBody> ShareAThreadAsync(
            string threadId,
            global::System.Guid projectId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}