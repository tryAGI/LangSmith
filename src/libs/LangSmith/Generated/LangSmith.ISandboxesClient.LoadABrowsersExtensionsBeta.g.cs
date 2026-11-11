#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Load a browser's extensions (beta)<br/>
        /// Beta: bring the browser's Chrome in line with the unpacked extensions in its /var/lib/browserd/extensions (one per directory). Of several with the same manifest name, only the highest manifest version is loaded, so a newer version installed beside an older one replaces it. Extensions placed there that Chrome does not have yet are loaded while it runs, so windows, tabs and connections are left as they are. When an extension Chrome has was removed or replaced, Chrome cannot unload it while running, so it is relaunched instead with the directory's extensions: logins stay, open tabs close and connections drop, and the call returns once every window is back.
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
        /// Beta: bring the browser's Chrome in line with the unpacked extensions in its /var/lib/browserd/extensions (one per directory). Of several with the same manifest name, only the highest manifest version is loaded, so a newer version installed beside an older one replaces it. Extensions placed there that Chrome does not have yet are loaded while it runs, so windows, tabs and connections are left as they are. When an extension Chrome has was removed or replaced, Chrome cannot unload it while running, so it is relaunched instead with the directory's extensions: logins stay, open tabs close and connections drop, and the call returns once every window is back.
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