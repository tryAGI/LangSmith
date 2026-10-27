#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create links to a browser window (beta)<br/>
        /// Beta: mint a view link and an act link for one window, as every attachment response does, with a chosen lifetime and the origins allowed to embed the window's pages in an iframe. Without embed_origins no page may frame them. view_embed_url and act_embed_url carry the same tokens in the URL fragment, for an iframe, so no server sees them. An embedded page sends its parent window messages when control changes and when it connects or disconnects (see the browser guide). Either link opens the window to anyone who holds it until it expires; detaching the window ends it early. A stopped browser starts when links are minted and when a link is opened, and resumes with its windows. Minting takes being the browser's creator or a role with sandboxes:exec.
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
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesBrowserWindowLinks> CreateLinksToABrowserWindowBetaAsync(
            string name,
            string attachmentId,

            global::LangSmith.SandboxesCreateBrowserWindowLinksPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create links to a browser window (beta)<br/>
        /// Beta: mint a view link and an act link for one window, as every attachment response does, with a chosen lifetime and the origins allowed to embed the window's pages in an iframe. Without embed_origins no page may frame them. view_embed_url and act_embed_url carry the same tokens in the URL fragment, for an iframe, so no server sees them. An embedded page sends its parent window messages when control changes and when it connects or disconnects (see the browser guide). Either link opens the window to anyone who holds it until it expires; detaching the window ends it early. A stopped browser starts when links are minted and when a link is opened, and resumes with its windows. Minting takes being the browser's creator or a role with sandboxes:exec.
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
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesBrowserWindowLinks>> CreateLinksToABrowserWindowBetaAsResponseAsync(
            string name,
            string attachmentId,

            global::LangSmith.SandboxesCreateBrowserWindowLinksPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create links to a browser window (beta)<br/>
        /// Beta: mint a view link and an act link for one window, as every attachment response does, with a chosen lifetime and the origins allowed to embed the window's pages in an iframe. Without embed_origins no page may frame them. view_embed_url and act_embed_url carry the same tokens in the URL fragment, for an iframe, so no server sees them. An embedded page sends its parent window messages when control changes and when it connects or disconnects (see the browser guide). Either link opens the window to anyone who holds it until it expires; detaching the window ends it early. A stopped browser starts when links are minted and when a link is opened, and resumes with its windows. Minting takes being the browser's creator or a role with sandboxes:exec.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attachmentId"></param>
        /// <param name="embedOrigins">
        /// EmbedOrigins are the origins whose pages may show the window's pages in<br/>
        /// an iframe, such as https://app.example.com: https, or http on<br/>
        /// localhost, with no path. Without them no page may frame the window.
        /// </param>
        /// <param name="ttlSeconds">
        /// TTLSeconds is how long the links work, from 60 seconds to 24 hours.<br/>
        /// Defaults to 24 hours.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesBrowserWindowLinks> CreateLinksToABrowserWindowBetaAsync(
            string name,
            string attachmentId,
            global::System.Collections.Generic.IList<string>? embedOrigins = default,
            int? ttlSeconds = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}