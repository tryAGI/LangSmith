#nullable enable

namespace LangSmith
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Get OpenID Connect userinfo<br/>
        /// Returns identity claims for the user represented by a LangSmith access token whose audience is the identity resource or the API resource. The token is passed as a Bearer credential in the Authorization header (OpenID Connect Core 1.0 §5.3).
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OauthUserinfoResponse> GetOpenIDConnectUserinfoAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get OpenID Connect userinfo<br/>
        /// Returns identity claims for the user represented by a LangSmith access token whose audience is the identity resource or the API resource. The token is passed as a Bearer credential in the Authorization header (OpenID Connect Core 1.0 §5.3).
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.OauthUserinfoResponse>> GetOpenIDConnectUserinfoAsResponseAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}