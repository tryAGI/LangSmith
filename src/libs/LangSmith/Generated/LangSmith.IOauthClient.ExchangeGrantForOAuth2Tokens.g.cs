#nullable enable

namespace LangSmith
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Exchange grant for OAuth2 tokens<br/>
        /// Token endpoint that dispatches by grant_type: authorization_code, urn:ietf:params:oauth:grant-type:device_code, or refresh_token.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OauthTokenResponse> ExchangeGrantForOAuth2TokensAsync(

            global::LangSmith.CreateOauthTokenRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Exchange grant for OAuth2 tokens<br/>
        /// Token endpoint that dispatches by grant_type: authorization_code, urn:ietf:params:oauth:grant-type:device_code, or refresh_token.
        /// </summary>
        /// <param name="grantType">
        /// Grant type: authorization_code, urn:ietf:params:oauth:grant-type:device_code, or refresh_token
        /// </param>
        /// <param name="clientId">
        /// OAuth2 client ID
        /// </param>
        /// <param name="code">
        /// Authorization code (authorization_code grant)
        /// </param>
        /// <param name="codeVerifier">
        /// PKCE code verifier (authorization_code grant)
        /// </param>
        /// <param name="redirectUri">
        /// Redirect URI (authorization_code grant)
        /// </param>
        /// <param name="deviceCode">
        /// Device code (device_code grant)
        /// </param>
        /// <param name="refreshToken">
        /// Refresh token (refresh_token grant)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OauthTokenResponse> ExchangeGrantForOAuth2TokensAsync(
            string grantType,
            string clientId,
            string? code = default,
            string? codeVerifier = default,
            string? redirectUri = default,
            string? deviceCode = default,
            string? refreshToken = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}