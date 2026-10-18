#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Attach a sandbox to a browser (beta)<br/>
        /// Beta: give a sandbox its own window of the browser, or, with no sandbox, open a window for the person calling (or, with controller "agent", for a client to drive over api_cdp_url). The response's cdp_url is the Chrome DevTools endpoint the sandbox connects to, and api_cdp_url the same endpoint through the API; a client can open more tabs, which stay in its window. Windows share the browser's cookies and logins. Keeping each sandbox to its own window is best effort, not a security boundary: attach only sandboxes you would trust with every login in the browser. With share_localhost, the browser can also reach the servers the sandbox runs, at the response's localhost_alias. Attaching takes, for the browser and for the attached sandbox each, being its creator or a role with sandboxes:exec. With unrestricted, nothing is filtered: the window's CDP clients (its sandbox, or anyone using its api_cdp_url) get the whole browser, including people's windows, every site's cookies, and commands that close it. It needs nothing beyond what any attach needs.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesBrowserAttachment> AttachASandboxToABrowserBetaAsync(
            string name,

            global::LangSmith.SandboxesAttachBrowserPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach a sandbox to a browser (beta)<br/>
        /// Beta: give a sandbox its own window of the browser, or, with no sandbox, open a window for the person calling (or, with controller "agent", for a client to drive over api_cdp_url). The response's cdp_url is the Chrome DevTools endpoint the sandbox connects to, and api_cdp_url the same endpoint through the API; a client can open more tabs, which stay in its window. Windows share the browser's cookies and logins. Keeping each sandbox to its own window is best effort, not a security boundary: attach only sandboxes you would trust with every login in the browser. With share_localhost, the browser can also reach the servers the sandbox runs, at the response's localhost_alias. Attaching takes, for the browser and for the attached sandbox each, being its creator or a role with sandboxes:exec. With unrestricted, nothing is filtered: the window's CDP clients (its sandbox, or anyone using its api_cdp_url) get the whole browser, including people's windows, every site's cookies, and commands that close it. It needs nothing beyond what any attach needs.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesBrowserAttachment>> AttachASandboxToABrowserBetaAsResponseAsync(
            string name,

            global::LangSmith.SandboxesAttachBrowserPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach a sandbox to a browser (beta)<br/>
        /// Beta: give a sandbox its own window of the browser, or, with no sandbox, open a window for the person calling (or, with controller "agent", for a client to drive over api_cdp_url). The response's cdp_url is the Chrome DevTools endpoint the sandbox connects to, and api_cdp_url the same endpoint through the API; a client can open more tabs, which stay in its window. Windows share the browser's cookies and logins. Keeping each sandbox to its own window is best effort, not a security boundary: attach only sandboxes you would trust with every login in the browser. With share_localhost, the browser can also reach the servers the sandbox runs, at the response's localhost_alias. Attaching takes, for the browser and for the attached sandbox each, being its creator or a role with sandboxes:exec. With unrestricted, nothing is filtered: the window's CDP clients (its sandbox, or anyone using its api_cdp_url) get the whole browser, including people's windows, every site's cookies, and commands that close it. It needs nothing beyond what any attach needs.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="controller">
        /// Controller is who drives a window opened with no sandbox: "user"<br/>
        /// (default) for a person in the live view, or "agent" for a client that<br/>
        /// drives it over api_cdp_url. A sandbox's window always starts with<br/>
        /// "agent".
        /// </param>
        /// <param name="height"></param>
        /// <param name="requestName">
        /// Name labels the window in the live view; defaults to the sandbox name.
        /// </param>
        /// <param name="sandbox">
        /// Sandbox is the name or ID of the sandbox to attach. Leave it out to open a<br/>
        /// window for the person calling, to use from the live view.
        /// </param>
        /// <param name="shareLocalhost">
        /// ShareLocalhost shares the sandbox's localhost with the browser, so pages<br/>
        /// can open the servers it runs, such as dev servers, at the response's<br/>
        /// localhost_alias. It reaches every port of the sandbox, including servers<br/>
        /// bound only to its localhost. Off by default. Not available for a window<br/>
        /// opened with no sandbox, or when the sandbox is itself a browser.
        /// </param>
        /// <param name="unrestricted">
        /// Unrestricted gives the window's CDP clients (its sandbox, or anyone using<br/>
        /// its api_cdp_url) the whole browser, with nothing filtered: every window<br/>
        /// and tab including people's, every site's cookies, and commands that close<br/>
        /// or crash the browser. Taking over its window does not pause them.
        /// </param>
        /// <param name="width">
        /// Width and Height size the window's page in CSS pixels; set both or<br/>
        /// neither. Without them the window opens at 1280x800.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesBrowserAttachment> AttachASandboxToABrowserBetaAsync(
            string name,
            global::LangSmith.SandboxesAttachBrowserPayloadController? controller = default,
            int? height = default,
            string? requestName = default,
            string? sandbox = default,
            bool? shareLocalhost = default,
            bool? unrestricted = default,
            int? width = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}