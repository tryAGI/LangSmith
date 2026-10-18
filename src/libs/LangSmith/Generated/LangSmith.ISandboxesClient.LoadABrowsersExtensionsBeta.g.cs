#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Load a browser's extensions (beta)<br/>
        /// Beta: load the unpacked extensions placed in the browser's /var/lib/browserd/extensions (one per directory) that its Chrome does not have yet. Chrome loads them while running, so windows, tabs and connections are left as they are. Extensions already loaded stay loaded, even if removed from the directory, until Chrome next launches.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesLoadBrowserExtensionsResponse> LoadABrowsersExtensionsBetaAsync(
            string name,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Load a browser's extensions (beta)<br/>
        /// Beta: load the unpacked extensions placed in the browser's /var/lib/browserd/extensions (one per directory) that its Chrome does not have yet. Chrome loads them while running, so windows, tabs and connections are left as they are. Extensions already loaded stay loaded, even if removed from the directory, until Chrome next launches.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesLoadBrowserExtensionsResponse>> LoadABrowsersExtensionsBetaAsResponseAsync(
            string name,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}