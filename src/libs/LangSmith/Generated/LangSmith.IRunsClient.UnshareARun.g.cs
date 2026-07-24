#nullable enable

namespace LangSmith
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Unshare a run<br/>
        /// Deletes the share token for the trace identified by trace_id and session_id. Idempotent: returns 204 whether or not a share token existed.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task UnshareARunAsync(
            global::System.Guid traceId,

            global::LangSmith.ShareDeleteShareTokenRequestBody request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unshare a run<br/>
        /// Deletes the share token for the trace identified by trace_id and session_id. Idempotent: returns 204 whether or not a share token existed.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> UnshareARunAsResponseAsync(
            global::System.Guid traceId,

            global::LangSmith.ShareDeleteShareTokenRequestBody request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unshare a run<br/>
        /// Deletes the share token for the trace identified by trace_id and session_id. Idempotent: returns 204 whether or not a share token existed.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="sessionId">
        /// session_id is the tracing project UUID containing the trace.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UnshareARunAsync(
            global::System.Guid traceId,
            global::System.Guid? sessionId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}