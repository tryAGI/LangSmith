#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Get sandbox access decision<br/>
        /// Combines authn + per-sandbox authz for runtime access. Returns the caller's PublicAuthInfo on allow (HTTP 200) or a 403 with the deny reason on deny.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="action"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AuthnPublicAuthInfo> GetSandboxAccessDecisionAsync(
            string sandboxId,
            string action,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get sandbox access decision<br/>
        /// Combines authn + per-sandbox authz for runtime access. Returns the caller's PublicAuthInfo on allow (HTTP 200) or a 403 with the deny reason on deny.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="action"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AuthnPublicAuthInfo>> GetSandboxAccessDecisionAsResponseAsync(
            string sandboxId,
            string action,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}