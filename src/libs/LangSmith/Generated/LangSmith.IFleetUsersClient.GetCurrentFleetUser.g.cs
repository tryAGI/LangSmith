#nullable enable

namespace LangSmith
{
    public partial interface IFleetUsersClient
    {
        /// <summary>
        /// Get current Fleet user<br/>
        /// Returns the authenticated Fleet caller's user profile. This endpoint does not require X-Tenant-Id and is intended for Fleet bootstrap.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UsersUser> GetCurrentFleetUserAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get current Fleet user<br/>
        /// Returns the authenticated Fleet caller's user profile. This endpoint does not require X-Tenant-Id and is intended for Fleet bootstrap.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UsersUser>> GetCurrentFleetUserAsResponseAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}