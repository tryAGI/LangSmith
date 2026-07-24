#nullable enable

namespace LangSmith
{
    public partial interface IIssuesAgentClient
    {
        /// <summary>
        /// [Beta] Update the issues agent config for a session<br/>
        /// **Beta:** This endpoint is in active development and may change without notice.<br/>
        /// Patches the agent config. All side effects (clearing fix fields when<br/>
        /// the GitHub repo changes, setting agent_overview_repo_id) happen in a<br/>
        /// single CRUD transaction. Omitted fields are left unchanged.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionIssuesAgentIssuesAgent> UpdateTheIssuesAgentConfigForASessionAsync(
            string sessionId,

            global::LangSmith.TracerSessionIssuesAgentUpdateIssuesAgentRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Update the issues agent config for a session<br/>
        /// **Beta:** This endpoint is in active development and may change without notice.<br/>
        /// Patches the agent config. All side effects (clearing fix fields when<br/>
        /// the GitHub repo changes, setting agent_overview_repo_id) happen in a<br/>
        /// single CRUD transaction. Omitted fields are left unchanged.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TracerSessionIssuesAgentIssuesAgent>> UpdateTheIssuesAgentConfigForASessionAsResponseAsync(
            string sessionId,

            global::LangSmith.TracerSessionIssuesAgentUpdateIssuesAgentRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Update the issues agent config for a session<br/>
        /// **Beta:** This endpoint is in active development and may change without notice.<br/>
        /// Patches the agent config. All side effects (clearing fix fields when<br/>
        /// the GitHub repo changes, setting agent_overview_repo_id) happen in a<br/>
        /// single CRUD transaction. Omitted fields are left unchanged.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="agentOverviewAccepted"></param>
        /// <param name="contextHubRepoHandle"></param>
        /// <param name="cronEnabled"></param>
        /// <param name="githubBaseBranch"></param>
        /// <param name="githubRepoSubdir"></param>
        /// <param name="githubRepoUrl"></param>
        /// <param name="previewVerifyEnabled"></param>
        /// <param name="priorities"></param>
        /// <param name="runFilter">
        /// Trace-scope DSL. nil = don't change; "" clears it.
        /// </param>
        /// <param name="sessionAgentOverviewRepoId"></param>
        /// <param name="sessionLcuSpendLimitMonthly">
        /// SessionLCUSpendLimitMonthly sets the per-project monthly LCU spend limit.<br/>
        /// Tri-state: absent (nil) = don't change; 0 or positive = monthly cap (a cap<br/>
        /// of 0 is always reached, blocking new runs); negative clears it (stored as<br/>
        /// NULL = no limit). The frontend sends a negative number to clear rather<br/>
        /// than null, since null is indistinguishable from "absent". Serialized as a<br/>
        /// string to preserve NUMERIC precision.
        /// </param>
        /// <param name="userInstructions">
        /// Freeform user preferences. Send "" to clear (the frontend must not send null).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionIssuesAgentIssuesAgent> UpdateTheIssuesAgentConfigForASessionAsync(
            string sessionId,
            bool? agentOverviewAccepted = default,
            string? contextHubRepoHandle = default,
            bool? cronEnabled = default,
            string? githubBaseBranch = default,
            string? githubRepoSubdir = default,
            string? githubRepoUrl = default,
            bool? previewVerifyEnabled = default,
            global::System.Collections.Generic.IList<string>? priorities = default,
            string? runFilter = default,
            string? sessionAgentOverviewRepoId = default,
            string? sessionLcuSpendLimitMonthly = default,
            string? userInstructions = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}