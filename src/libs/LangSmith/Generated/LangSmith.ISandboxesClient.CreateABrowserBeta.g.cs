#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create a browser (beta)<br/>
        /// Beta: create a browser sandbox, which runs one persistent Chrome that other sandboxes attach to. Logins made in it persist across restarts. It keeps its memory when it stops. A stopped browser is deleted after the sandbox default, along with its logins, unless delete_after_stop_seconds sets another delay or 0 to keep it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesBrowserResponse> CreateABrowserBetaAsync(

            global::LangSmith.SandboxesCreateBrowserPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a browser (beta)<br/>
        /// Beta: create a browser sandbox, which runs one persistent Chrome that other sandboxes attach to. Logins made in it persist across restarts. It keeps its memory when it stops. A stopped browser is deleted after the sandbox default, along with its logins, unless delete_after_stop_seconds sets another delay or 0 to keep it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesBrowserResponse>> CreateABrowserBetaAsResponseAsync(

            global::LangSmith.SandboxesCreateBrowserPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a browser (beta)<br/>
        /// Beta: create a browser sandbox, which runs one persistent Chrome that other sandboxes attach to. Logins made in it persist across restarts. It keeps its memory when it stops. A stopped browser is deleted after the sandbox default, along with its logins, unless delete_after_stop_seconds sets another delay or 0 to keep it.
        /// </summary>
        /// <param name="deleteAfterStopSeconds">
        /// DeleteAfterStopSeconds deletes the browser this long after it stops.<br/>
        /// Defaults to the sandbox default; 0 keeps a stopped browser until it is<br/>
        /// deleted.
        /// </param>
        /// <param name="hidpi">
        /// HiDPI renders pages at twice the resolution, so the live view is sharp on<br/>
        /// HiDPI screens, at four times the pixels for the browser to render and<br/>
        /// stream. Off by default, and fixed once the browser is created.
        /// </param>
        /// <param name="idleTtlSeconds">
        /// IdleTTLSeconds stops the browser after this long without use. A stopped<br/>
        /// browser resumes with its memory on the next connection. Defaults to the<br/>
        /// sandbox default; 0 disables the idle stop.
        /// </param>
        /// <param name="memBytes"></param>
        /// <param name="name">
        /// Name of the browser sandbox. Generated when omitted, as "browser-"<br/>
        /// followed by the browser's ID.
        /// </param>
        /// <param name="proxyConfig">
        /// ProxyConfig applies a sandbox's proxy rules to the pages the browser<br/>
        /// loads: header injection, access control, and relay rules.
        /// </param>
        /// <param name="vcpus">
        /// VCPUs and MemBytes size the browser sandbox, as for any sandbox. With<br/>
        /// neither set, a browser gets 2 vCPUs and 8 GiB.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesBrowserResponse> CreateABrowserBetaAsync(
            int? deleteAfterStopSeconds = default,
            bool? hidpi = default,
            int? idleTtlSeconds = default,
            long? memBytes = default,
            string? name = default,
            global::LangSmith.SandboxesProxyConfig? proxyConfig = default,
            long? vcpus = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}