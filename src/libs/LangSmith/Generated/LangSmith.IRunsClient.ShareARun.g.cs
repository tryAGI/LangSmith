#nullable enable

namespace LangSmith
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Share a run<br/>
        /// Creates or returns a share token for a run. Child runs share their trace root.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ShareCreateShareTokenResponseBody> ShareARunAsync(
            global::System.Guid runId,

            global::LangSmith.ShareCreateShareTokenRequestBody request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Share a run<br/>
        /// Creates or returns a share token for a run. Child runs share their trace root.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ShareCreateShareTokenResponseBody>> ShareARunAsResponseAsync(
            global::System.Guid runId,

            global::LangSmith.ShareCreateShareTokenRequestBody request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Share a run<br/>
        /// Creates or returns a share token for a run. Child runs share their trace root.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="sessionId">
        /// session_id is the tracing project UUID containing the trace.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </param>
        /// <param name="traceId">
        /// trace_id is the root trace UUID to share.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ShareCreateShareTokenResponseBody> ShareARunAsync(
            global::System.Guid runId,
            global::System.Guid? sessionId = default,
            global::System.Guid? traceId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}