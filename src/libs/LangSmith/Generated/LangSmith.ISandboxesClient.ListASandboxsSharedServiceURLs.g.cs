#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// List a sandbox's shared service URLs<br/>
        /// Returns one entry per port the sandbox is currently reachable on, so a caller can see what is shared before turning it off. Expired token grants are omitted.<br/>
        /// Cursors are opaque and only valid on this endpoint; do not parse or construct one.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesServiceURLGrantListResponse> ListASandboxsSharedServiceURLsAsync(
            string name,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List a sandbox's shared service URLs<br/>
        /// Returns one entry per port the sandbox is currently reachable on, so a caller can see what is shared before turning it off. Expired token grants are omitted.<br/>
        /// Cursors are opaque and only valid on this endpoint; do not parse or construct one.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesServiceURLGrantListResponse>> ListASandboxsSharedServiceURLsAsResponseAsync(
            string name,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}