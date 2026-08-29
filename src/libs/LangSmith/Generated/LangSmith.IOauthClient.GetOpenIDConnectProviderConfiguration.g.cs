#nullable enable

namespace LangSmith
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Get OpenID Connect provider configuration<br/>
        /// Returns the OpenID Connect discovery document (OpenID Connect Discovery 1.0), advertising the authorization, token, userinfo, and JWKS endpoints plus supported scopes, response types, and signing algorithms.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OauthOIDCProviderMetadata> GetOpenIDConnectProviderConfigurationAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get OpenID Connect provider configuration<br/>
        /// Returns the OpenID Connect discovery document (OpenID Connect Discovery 1.0), advertising the authorization, token, userinfo, and JWKS endpoints plus supported scopes, response types, and signing algorithms.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.OauthOIDCProviderMetadata>> GetOpenIDConnectProviderConfigurationAsResponseAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}