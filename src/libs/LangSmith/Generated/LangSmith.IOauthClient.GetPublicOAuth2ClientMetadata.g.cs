#nullable enable

namespace LangSmith
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Get public OAuth2 client metadata<br/>
        /// Returns the display metadata (name, logo, homepage/terms/privacy links) for a registered OAuth2 client. Used by the consent screen to show a human-readable client identity instead of the raw client_id. Public endpoint; exposes only non-sensitive display fields.
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OauthClientPublicMetadata> GetPublicOAuth2ClientMetadataAsync(
            string clientID,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get public OAuth2 client metadata<br/>
        /// Returns the display metadata (name, logo, homepage/terms/privacy links) for a registered OAuth2 client. Used by the consent screen to show a human-readable client identity instead of the raw client_id. Public endpoint; exposes only non-sensitive display fields.
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.OauthClientPublicMetadata>> GetPublicOAuth2ClientMetadataAsResponseAsync(
            string clientID,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}