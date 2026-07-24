#nullable enable

namespace LangSmith
{
    public partial interface IIssuesAgentClient
    {
        /// <summary>
        /// [Beta] Create the issues agent for a session<br/>
        /// **Beta:** This endpoint is in active development and may change without notice.<br/>
        /// Configures the issues agent for the given tracer session and enqueues<br/>
        /// the initial scan. Fails if an agent already exists for the session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionIssuesAgentIssuesAgent> CreateTheIssuesAgentForASessionAsync(
            string sessionId,

            global::LangSmith.TracerSessionIssuesAgentCreateIssuesAgentRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Create the issues agent for a session<br/>
        /// **Beta:** This endpoint is in active development and may change without notice.<br/>
        /// Configures the issues agent for the given tracer session and enqueues<br/>
        /// the initial scan. Fails if an agent already exists for the session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TracerSessionIssuesAgentIssuesAgent>> CreateTheIssuesAgentForASessionAsResponseAsync(
            string sessionId,

            global::LangSmith.TracerSessionIssuesAgentCreateIssuesAgentRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] Create the issues agent for a session<br/>
        /// **Beta:** This endpoint is in active development and may change without notice.<br/>
        /// Configures the issues agent for the given tracer session and enqueues<br/>
        /// the initial scan. Fails if an agent already exists for the session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="contextHubRepoHandle"></param>
        /// <param name="githubBaseBranch"></param>
        /// <param name="githubRepoSubdir"></param>
        /// <param name="githubRepoUrl"></param>
        /// <param name="priorities"></param>
        /// <param name="runFilter">
        /// Runs-filter-DSL trace scope; omit/null/empty for no scope.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionIssuesAgentIssuesAgent> CreateTheIssuesAgentForASessionAsync(
            string sessionId,
            string? contextHubRepoHandle = default,
            string? githubBaseBranch = default,
            string? githubRepoSubdir = default,
            string? githubRepoUrl = default,
            global::System.Collections.Generic.IList<string>? priorities = default,
            string? runFilter = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}