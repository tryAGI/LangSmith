#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Generate a sandbox file download link<br/>
        /// Generate a tokenized link that downloads a single file from a sandbox with no further authentication. This mints a token rather than creating an addressable resource, so it returns 200 with no Location header. The token pins the sandbox, the file path, the response content type and disposition, and the sandbox flags, so a link cannot be repointed at another file or served under a weaker policy. The file is always served with a Content-Security-Policy: a sandbox directive, plus a default-src holding every fetch to the file's own download host and a set of pre-approved third-party origins. csp_sandbox_flags may loosen the sandbox with allow-downloads, allow-forms, allow-modals, allow-orientation-lock, allow-pointer-lock, allow-popups, allow-presentation, allow-same-origin, allow-scripts, or allow-top-navigation-by-user-activation. Every file is served from its own host, derived from the sandbox and the path, so allow-same-origin gives a page localStorage and IndexedDB that no other file can read, and re-minting a link for the same file keeps them. csp_sandbox set to false drops the sandbox directive altogether, and csp_sandbox_flags must then be omitted. csp_source_bundles selects the third-party origins: cdnjs, google-fonts, jsdelivr, and unpkg are all allowed when the field is omitted, 'none' holds the file to its own host, and 'any' sends no default-src at all. Links never expire unless expires_in_seconds is set. The link is served from the sandbox service domain, not the API host.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesDownloadURLResponse> GenerateASandboxFileDownloadLinkAsync(
            string name,

            global::LangSmith.SandboxesDownloadURLPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a sandbox file download link<br/>
        /// Generate a tokenized link that downloads a single file from a sandbox with no further authentication. This mints a token rather than creating an addressable resource, so it returns 200 with no Location header. The token pins the sandbox, the file path, the response content type and disposition, and the sandbox flags, so a link cannot be repointed at another file or served under a weaker policy. The file is always served with a Content-Security-Policy: a sandbox directive, plus a default-src holding every fetch to the file's own download host and a set of pre-approved third-party origins. csp_sandbox_flags may loosen the sandbox with allow-downloads, allow-forms, allow-modals, allow-orientation-lock, allow-pointer-lock, allow-popups, allow-presentation, allow-same-origin, allow-scripts, or allow-top-navigation-by-user-activation. Every file is served from its own host, derived from the sandbox and the path, so allow-same-origin gives a page localStorage and IndexedDB that no other file can read, and re-minting a link for the same file keeps them. csp_sandbox set to false drops the sandbox directive altogether, and csp_sandbox_flags must then be omitted. csp_source_bundles selects the third-party origins: cdnjs, google-fonts, jsdelivr, and unpkg are all allowed when the field is omitted, 'none' holds the file to its own host, and 'any' sends no default-src at all. Links never expire unless expires_in_seconds is set. The link is served from the sandbox service domain, not the API host.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesDownloadURLResponse>> GenerateASandboxFileDownloadLinkAsResponseAsync(
            string name,

            global::LangSmith.SandboxesDownloadURLPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a sandbox file download link<br/>
        /// Generate a tokenized link that downloads a single file from a sandbox with no further authentication. This mints a token rather than creating an addressable resource, so it returns 200 with no Location header. The token pins the sandbox, the file path, the response content type and disposition, and the sandbox flags, so a link cannot be repointed at another file or served under a weaker policy. The file is always served with a Content-Security-Policy: a sandbox directive, plus a default-src holding every fetch to the file's own download host and a set of pre-approved third-party origins. csp_sandbox_flags may loosen the sandbox with allow-downloads, allow-forms, allow-modals, allow-orientation-lock, allow-pointer-lock, allow-popups, allow-presentation, allow-same-origin, allow-scripts, or allow-top-navigation-by-user-activation. Every file is served from its own host, derived from the sandbox and the path, so allow-same-origin gives a page localStorage and IndexedDB that no other file can read, and re-minting a link for the same file keeps them. csp_sandbox set to false drops the sandbox directive altogether, and csp_sandbox_flags must then be omitted. csp_source_bundles selects the third-party origins: cdnjs, google-fonts, jsdelivr, and unpkg are all allowed when the field is omitted, 'none' holds the file to its own host, and 'any' sends no default-src at all. Links never expire unless expires_in_seconds is set. The link is served from the sandbox service domain, not the API host.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="contentDisposition"></param>
        /// <param name="contentType"></param>
        /// <param name="cspSandbox">
        /// CSPSandbox false serves the file with no CSP sandbox directive; omit to keep it.
        /// </param>
        /// <param name="cspSandboxFlags">
        /// CSPSandboxFlags loosen the CSP sandbox the file is served under; omit for the most restrictive policy.
        /// </param>
        /// <param name="cspSourceBundles">
        /// CSPSourceBundles allow the served file to fetch from named third-party origins; omit to send no fetch directive.
        /// </param>
        /// <param name="expiresInSeconds">
        /// ExpiresInSeconds is optional; a link with no expiry never expires.
        /// </param>
        /// <param name="path"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesDownloadURLResponse> GenerateASandboxFileDownloadLinkAsync(
            string name,
            string path,
            string? contentDisposition = default,
            string? contentType = default,
            bool? cspSandbox = default,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag>? cspSandboxFlags = default,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle>? cspSourceBundles = default,
            int? expiresInSeconds = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}