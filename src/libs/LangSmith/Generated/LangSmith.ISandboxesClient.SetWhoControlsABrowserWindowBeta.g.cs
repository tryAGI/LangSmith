#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Set who controls a browser window (beta)<br/>
        /// Beta: give the window to a person ("user") or back to the attached sandbox ("agent"). It takes effect at once and does not wait for anyone. While a person has control, the attached sandbox's commands that read or act on the page fail with a "human has control" error, and it receives no page content. The window's current controller is in the browser's attachments.
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
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesBrowserAttachment> SetWhoControlsABrowserWindowBetaAsync(
            string name,
            string attachmentId,

            global::LangSmith.SandboxesSetBrowserControllerPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set who controls a browser window (beta)<br/>
        /// Beta: give the window to a person ("user") or back to the attached sandbox ("agent"). It takes effect at once and does not wait for anyone. While a person has control, the attached sandbox's commands that read or act on the page fail with a "human has control" error, and it receives no page content. The window's current controller is in the browser's attachments.
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
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesBrowserAttachment>> SetWhoControlsABrowserWindowBetaAsResponseAsync(
            string name,
            string attachmentId,

            global::LangSmith.SandboxesSetBrowserControllerPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set who controls a browser window (beta)<br/>
        /// Beta: give the window to a person ("user") or back to the attached sandbox ("agent"). It takes effect at once and does not wait for anyone. While a person has control, the attached sandbox's commands that read or act on the page fail with a "human has control" error, and it receives no page content. The window's current controller is in the browser's attachments.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attachmentId"></param>
        /// <param name="controller">
        /// Controller is "user" to give the window to a person, or "agent" to give<br/>
        /// it back to the attached sandbox.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesBrowserAttachment> SetWhoControlsABrowserWindowBetaAsync(
            string name,
            string attachmentId,
            global::LangSmith.SandboxesSetBrowserControllerPayloadController? controller = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}