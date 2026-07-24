#nullable enable

namespace LangSmith
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Record a fix-verification verdict<br/>
        /// Records whether a fix resolved the issue when replayed against its preview deployment.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionIssuesFixVerification> RecordAFixVerificationVerdictAsync(
            string id,

            global::LangSmith.TracerSessionIssuesRecordFixVerdictRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Record a fix-verification verdict<br/>
        /// Records whether a fix resolved the issue when replayed against its preview deployment.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TracerSessionIssuesFixVerification>> RecordAFixVerificationVerdictAsResponseAsync(
            string id,

            global::LangSmith.TracerSessionIssuesRecordFixVerdictRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Record a fix-verification verdict<br/>
        /// Records whether a fix resolved the issue when replayed against its preview deployment.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="detail"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionIssuesFixVerification> RecordAFixVerificationVerdictAsync(
            string id,
            object? detail = default,
            string? status = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}