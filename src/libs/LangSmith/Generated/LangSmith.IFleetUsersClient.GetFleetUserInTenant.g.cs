#nullable enable

namespace LangSmith
{
    public partial interface IFleetUsersClient
    {
        /// <summary>
        /// Get Fleet user in tenant<br/>
        /// Resolves a LangSmith user by ID within a tenant/workspace the caller can access. This endpoint does not require X-Tenant-Id because the tenant is part of the path.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UsersUserRef> GetFleetUserInTenantAsync(
            string tenantId,
            string id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Fleet user in tenant<br/>
        /// Resolves a LangSmith user by ID within a tenant/workspace the caller can access. This endpoint does not require X-Tenant-Id because the tenant is part of the path.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UsersUserRef>> GetFleetUserInTenantAsResponseAsync(
            string tenantId,
            string id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}