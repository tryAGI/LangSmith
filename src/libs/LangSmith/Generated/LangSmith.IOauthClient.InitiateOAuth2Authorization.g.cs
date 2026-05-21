#nullable enable

namespace LangSmith
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Initiate OAuth2 authorization<br/>
        /// Validates authorization request parameters and redirects to the frontend consent page per RFC 6749.
        /// </summary>
        /// <param name="responseType"></param>
        /// <param name="clientId"></param>
        /// <param name="redirectUri"></param>
        /// <param name="codeChallenge"></param>
        /// <param name="codeChallengeMethod"></param>
        /// <param name="state"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task InitiateOAuth2AuthorizationAsync(
            string responseType,
            string clientId,
            string redirectUri,
            string codeChallenge,
            string codeChallengeMethod,
            string? state = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Initiate OAuth2 authorization<br/>
        /// Validates authorization request parameters and redirects to the frontend consent page per RFC 6749.
        /// </summary>
        /// <param name="responseType"></param>
        /// <param name="clientId"></param>
        /// <param name="redirectUri"></param>
        /// <param name="codeChallenge"></param>
        /// <param name="codeChallengeMethod"></param>
        /// <param name="state"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> InitiateOAuth2AuthorizationAsResponseAsync(
            string responseType,
            string clientId,
            string redirectUri,
            string codeChallenge,
            string codeChallengeMethod,
            string? state = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}