#nullable enable

namespace LangSmith
{
    public partial interface IFleetAuthClient
    {
        /// <summary>
        /// Get an OAuth provider<br/>
        /// Returns a single OAuth provider by ID.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task GetAnOAuthProviderAsync(
            string providerId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an OAuth provider<br/>
        /// Returns a single OAuth provider by ID.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> GetAnOAuthProviderAsResponseAsync(
            string providerId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}