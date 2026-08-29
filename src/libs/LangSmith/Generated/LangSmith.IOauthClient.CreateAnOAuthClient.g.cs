#nullable enable

namespace LangSmith
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Create an OAuth client<br/>
        /// Registers a new OAuth 2.0 / OIDC client owned by the caller's organization. For confidential clients the response includes a client_secret that is shown only once.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OauthOAuthClientCredentialsResponse> CreateAnOAuthClientAsync(

            global::LangSmith.OauthCreateOAuthClientRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an OAuth client<br/>
        /// Registers a new OAuth 2.0 / OIDC client owned by the caller's organization. For confidential clients the response includes a client_secret that is shown only once.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.OauthOAuthClientCredentialsResponse>> CreateAnOAuthClientAsResponseAsync(

            global::LangSmith.OauthCreateOAuthClientRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an OAuth client<br/>
        /// Registers a new OAuth 2.0 / OIDC client owned by the caller's organization. For confidential clients the response includes a client_secret that is shown only once.
        /// </summary>
        /// <param name="allowedScopes"></param>
        /// <param name="clientName"></param>
        /// <param name="clientType">
        /// "public" or "confidential"
        /// </param>
        /// <param name="clientUri"></param>
        /// <param name="grantTypes"></param>
        /// <param name="logoUri"></param>
        /// <param name="policyUri"></param>
        /// <param name="redirectUris"></param>
        /// <param name="tosUri"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OauthOAuthClientCredentialsResponse> CreateAnOAuthClientAsync(
            global::System.Collections.Generic.IList<string>? allowedScopes = default,
            string? clientName = default,
            string? clientType = default,
            string? clientUri = default,
            global::System.Collections.Generic.IList<string>? grantTypes = default,
            string? logoUri = default,
            string? policyUri = default,
            global::System.Collections.Generic.IList<string>? redirectUris = default,
            string? tosUri = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}