#nullable enable

namespace LangSmith
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Update an OAuth client
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OauthOAuthClientView> UpdateAnOAuthClientAsync(
            string id,

            global::LangSmith.OauthUpdateOAuthClientRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an OAuth client
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.OauthOAuthClientView>> UpdateAnOAuthClientAsResponseAsync(
            string id,

            global::LangSmith.OauthUpdateOAuthClientRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an OAuth client
        /// </summary>
        /// <param name="id"></param>
        /// <param name="allowedScopes"></param>
        /// <param name="clientName"></param>
        /// <param name="clientUri"></param>
        /// <param name="disabled"></param>
        /// <param name="logoUri"></param>
        /// <param name="policyUri"></param>
        /// <param name="redirectUris"></param>
        /// <param name="tosUri"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OauthOAuthClientView> UpdateAnOAuthClientAsync(
            string id,
            global::System.Collections.Generic.IList<string>? allowedScopes = default,
            string? clientName = default,
            string? clientUri = default,
            bool? disabled = default,
            string? logoUri = default,
            string? policyUri = default,
            global::System.Collections.Generic.IList<string>? redirectUris = default,
            string? tosUri = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}