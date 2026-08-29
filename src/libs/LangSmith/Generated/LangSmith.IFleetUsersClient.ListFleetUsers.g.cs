#nullable enable

namespace LangSmith
{
    public partial interface IFleetUsersClient
    {
        /// <summary>
        /// List Fleet users<br/>
        /// Lists members of the caller's current workspace, optionally filtered by a search string. Use this to resolve a colleague's email or full name into the user ID that agent sharing takes (`permissions.shared_users`). A member's `name` in the response can come from a separately configured display name, which `search` does not match. The tenant is taken from the X-Tenant-Id header. Members your organization hides from other members are omitted.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UsersListResponse> ListFleetUsersAsync(
            string? search = default,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Fleet users<br/>
        /// Lists members of the caller's current workspace, optionally filtered by a search string. Use this to resolve a colleague's email or full name into the user ID that agent sharing takes (`permissions.shared_users`). A member's `name` in the response can come from a separately configured display name, which `search` does not match. The tenant is taken from the X-Tenant-Id header. Members your organization hides from other members are omitted.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UsersListResponse>> ListFleetUsersAsResponseAsync(
            string? search = default,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}