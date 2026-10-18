#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Open a tab in a browser window (beta)<br/>
        /// Beta: open a tab in the window, at about:blank when no URL is given.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attachmentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesBrowserTab> OpenATabInABrowserWindowBetaAsync(
            string name,
            string attachmentId,

            global::LangSmith.SandboxesOpenBrowserTabPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Open a tab in a browser window (beta)<br/>
        /// Beta: open a tab in the window, at about:blank when no URL is given.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attachmentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesBrowserTab>> OpenATabInABrowserWindowBetaAsResponseAsync(
            string name,
            string attachmentId,

            global::LangSmith.SandboxesOpenBrowserTabPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Open a tab in a browser window (beta)<br/>
        /// Beta: open a tab in the window, at about:blank when no URL is given.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attachmentId"></param>
        /// <param name="url">
        /// URL to open; about:blank when empty.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesBrowserTab> OpenATabInABrowserWindowBetaAsync(
            string name,
            string attachmentId,
            string? url = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}