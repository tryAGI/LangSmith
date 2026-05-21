#nullable enable

namespace LangSmith
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// [Beta] List viewed issues for a session<br/>
        /// **Beta:** Returns the issues in this session that the current<br/>
        /// user has opened, with timestamps. Used by the UI to derive<br/>
        /// the per-row "unread" indicator and the Engine tab badge.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionIssuesListViewsResponse> ListViewedIssuesForASessionAsync(
            string sessionId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] List viewed issues for a session<br/>
        /// **Beta:** Returns the issues in this session that the current<br/>
        /// user has opened, with timestamps. Used by the UI to derive<br/>
        /// the per-row "unread" indicator and the Engine tab badge.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TracerSessionIssuesListViewsResponse>> ListViewedIssuesForASessionAsResponseAsync(
            string sessionId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}