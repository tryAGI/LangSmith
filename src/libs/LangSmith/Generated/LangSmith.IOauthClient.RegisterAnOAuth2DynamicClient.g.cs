#nullable enable

namespace LangSmith
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Register an OAuth2 dynamic client<br/>
        /// Public RFC 7591 Dynamic Client Registration endpoint. Only mints public clients with loopback HTTP or HTTPS-with-domain redirect URIs. Body limit 8 KB.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OauthClientRegistrationResponse> RegisterAnOAuth2DynamicClientAsync(

            global::LangSmith.OauthClientRegistrationRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register an OAuth2 dynamic client<br/>
        /// Public RFC 7591 Dynamic Client Registration endpoint. Only mints public clients with loopback HTTP or HTTPS-with-domain redirect URIs. Body limit 8 KB.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.OauthClientRegistrationResponse>> RegisterAnOAuth2DynamicClientAsResponseAsync(

            global::LangSmith.OauthClientRegistrationRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register an OAuth2 dynamic client<br/>
        /// Public RFC 7591 Dynamic Client Registration endpoint. Only mints public clients with loopback HTTP or HTTPS-with-domain redirect URIs. Body limit 8 KB.
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="grantTypes"></param>
        /// <param name="redirectUris"></param>
        /// <param name="responseTypes"></param>
        /// <param name="scope"></param>
        /// <param name="tokenEndpointAuthMethod"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OauthClientRegistrationResponse> RegisterAnOAuth2DynamicClientAsync(
            string? clientName = default,
            global::System.Collections.Generic.IList<string>? grantTypes = default,
            global::System.Collections.Generic.IList<string>? redirectUris = default,
            global::System.Collections.Generic.IList<string>? responseTypes = default,
            string? scope = default,
            string? tokenEndpointAuthMethod = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}