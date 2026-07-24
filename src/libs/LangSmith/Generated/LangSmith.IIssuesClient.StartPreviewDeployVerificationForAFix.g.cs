#nullable enable

namespace LangSmith
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Start preview-deploy verification for a fix<br/>
        /// Opens/reuses the fix PR, applies the preview label, and schedules the poll that resumes the fix run when the preview is up.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionIssuesStartPreviewResponse> StartPreviewDeployVerificationForAFixAsync(
            string id,

            global::LangSmith.TracerSessionIssuesStartPreviewRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start preview-deploy verification for a fix<br/>
        /// Opens/reuses the fix PR, applies the preview label, and schedules the poll that resumes the fix run when the preview is up.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TracerSessionIssuesStartPreviewResponse>> StartPreviewDeployVerificationForAFixAsResponseAsync(
            string id,

            global::LangSmith.TracerSessionIssuesStartPreviewRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start preview-deploy verification for a fix<br/>
        /// Opens/reuses the fix PR, applies the preview label, and schedules the poll that resumes the fix run when the preview is up.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="commitSha"></param>
        /// <param name="runId"></param>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionIssuesStartPreviewResponse> StartPreviewDeployVerificationForAFixAsync(
            string id,
            string? commitSha = default,
            string? runId = default,
            string? threadId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}