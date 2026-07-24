#nullable enable

namespace LangSmith
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Revoke an authorized application<br/>
        /// Revokes the authenticated user's authorization for an application and invalidates that application's active tokens for the user.
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task RevokeAnAuthorizedApplicationAsync(
            string clientID,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke an authorized application<br/>
        /// Revokes the authenticated user's authorization for an application and invalidates that application's active tokens for the user.
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> RevokeAnAuthorizedApplicationAsResponseAsync(
            string clientID,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}