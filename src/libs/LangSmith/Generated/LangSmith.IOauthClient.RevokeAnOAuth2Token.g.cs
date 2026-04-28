#nullable enable

namespace LangSmith
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Revoke an OAuth2 token<br/>
        /// Revokes an access token or refresh token per RFC 7009. Always returns 200 regardless of whether the token was found.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task RevokeAnOAuth2TokenAsync(

            global::LangSmith.CreateOauthRevokeRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke an OAuth2 token<br/>
        /// Revokes an access token or refresh token per RFC 7009. Always returns 200 regardless of whether the token was found.
        /// </summary>
        /// <param name="token">
        /// Token to revoke (access token or refresh token)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task RevokeAnOAuth2TokenAsync(
            string token,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}