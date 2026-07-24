#nullable enable

namespace LangSmith
{
    public partial interface IFleetTenantsClient
    {
        /// <summary>
        /// List tenants<br/>
        /// Returns the LangSmith tenants/workspaces visible to the authenticated caller in the requested organization. This endpoint does not require X-Tenant-Id and is intended for Fleet bootstrap.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="pageSize"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TenantsListTenantsResponse> ListTenantsAsync(
            string orgId,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List tenants<br/>
        /// Returns the LangSmith tenants/workspaces visible to the authenticated caller in the requested organization. This endpoint does not require X-Tenant-Id and is intended for Fleet bootstrap.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="pageSize"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TenantsListTenantsResponse>> ListTenantsAsResponseAsync(
            string orgId,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}