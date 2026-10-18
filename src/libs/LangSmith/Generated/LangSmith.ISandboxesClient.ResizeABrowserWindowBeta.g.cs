#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Resize a browser window (beta)<br/>
        /// Beta: size a window so its page is width by height CSS pixels. The window keeps that size until resized again, through this call or over CDP with Browser.setWindowBounds; the live view scales to fit it rather than resizing it. A browser that is not running cannot be resized.
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
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesBrowserAttachment> ResizeABrowserWindowBetaAsync(
            string name,
            string attachmentId,

            global::LangSmith.SandboxesUpdateBrowserAttachmentPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resize a browser window (beta)<br/>
        /// Beta: size a window so its page is width by height CSS pixels. The window keeps that size until resized again, through this call or over CDP with Browser.setWindowBounds; the live view scales to fit it rather than resizing it. A browser that is not running cannot be resized.
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
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesBrowserAttachment>> ResizeABrowserWindowBetaAsResponseAsync(
            string name,
            string attachmentId,

            global::LangSmith.SandboxesUpdateBrowserAttachmentPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resize a browser window (beta)<br/>
        /// Beta: size a window so its page is width by height CSS pixels. The window keeps that size until resized again, through this call or over CDP with Browser.setWindowBounds; the live view scales to fit it rather than resizing it. A browser that is not running cannot be resized.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attachmentId"></param>
        /// <param name="height"></param>
        /// <param name="width">
        /// Width and Height are the window's new page size in CSS pixels.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesBrowserAttachment> ResizeABrowserWindowBetaAsync(
            string name,
            string attachmentId,
            int? height = default,
            int? width = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}