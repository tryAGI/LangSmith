#nullable enable

namespace LangSmith
{
    public partial interface IFleetAuthClient
    {
        /// <summary>
        /// Update an OAuth provider<br/>
        /// Updates an OAuth provider's configuration. Sent fields replace the stored values; absent fields are left unchanged.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateAnOAuthProviderAsync(
            string providerId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an OAuth provider<br/>
        /// Updates an OAuth provider's configuration. Sent fields replace the stored values; absent fields are left unchanged.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> UpdateAnOAuthProviderAsResponseAsync(
            string providerId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}