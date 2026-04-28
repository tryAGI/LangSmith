#nullable enable

namespace LangSmith
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Approve OAuth2 authorization request<br/>
        /// Issues an authorization code after the authenticated user approves the request. Called by the frontend consent page. Requires authentication.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> ApproveOAuth2AuthorizationRequestAsync(

            global::LangSmith.CreateOauthAuthorizeApproveRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Approve OAuth2 authorization request<br/>
        /// Issues an authorization code after the authenticated user approves the request. Called by the frontend consent page. Requires authentication.
        /// </summary>
        /// <param name="organizationId">
        /// Organization ID; must match the authenticated org
        /// </param>
        /// <param name="clientId">
        /// OAuth2 client ID
        /// </param>
        /// <param name="redirectUri">
        /// Redirect URI registered with the client
        /// </param>
        /// <param name="codeChallenge">
        /// PKCE code challenge
        /// </param>
        /// <param name="codeChallengeMethod">
        /// PKCE method, must be 'S256'
        /// </param>
        /// <param name="state">
        /// Opaque state value to prevent CSRF
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> ApproveOAuth2AuthorizationRequestAsync(
            string organizationId,
            string clientId,
            string redirectUri,
            string codeChallenge,
            string codeChallengeMethod,
            string? state = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}