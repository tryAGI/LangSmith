#nullable enable

namespace LangSmith
{
    public partial interface IIssuesAgentClient
    {
        /// <summary>
        /// [Beta] Save the agent overview for a session<br/>
        /// **Beta:** This endpoint is in active development and may change without notice.<br/>
        /// Saves the issues agent overview content server-side, creating or updating<br/>
        /// the backing private Prompt Hub repo and linking it to the issues agent config.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionIssuesAgentSaveOverviewResponse> SaveTheAgentOverviewForASessionAsync(
            string sessionId,

            global::LangSmith.TracerSessionIssuesAgentSaveOverviewRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Save the agent overview for a session<br/>
        /// **Beta:** This endpoint is in active development and may change without notice.<br/>
        /// Saves the issues agent overview content server-side, creating or updating<br/>
        /// the backing private Prompt Hub repo and linking it to the issues agent config.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TracerSessionIssuesAgentSaveOverviewResponse>> SaveTheAgentOverviewForASessionAsResponseAsync(
            string sessionId,

            global::LangSmith.TracerSessionIssuesAgentSaveOverviewRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Save the agent overview for a session<br/>
        /// **Beta:** This endpoint is in active development and may change without notice.<br/>
        /// Saves the issues agent overview content server-side, creating or updating<br/>
        /// the backing private Prompt Hub repo and linking it to the issues agent config.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="content"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionIssuesAgentSaveOverviewResponse> SaveTheAgentOverviewForASessionAsync(
            string sessionId,
            string? content = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}