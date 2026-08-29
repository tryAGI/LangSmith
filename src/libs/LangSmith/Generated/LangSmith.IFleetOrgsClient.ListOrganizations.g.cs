#nullable enable

namespace LangSmith
{
    public partial interface IFleetOrgsClient
    {
        /// <summary>
        /// List organizations<br/>
        /// Returns the organizations the authenticated caller belongs to. This endpoint does not require X-Tenant-Id and is the entry point for Fleet bootstrap: take an organization's `id` and list its workspaces via GET /v1/fleet/orgs/{org_id}/tenants, then call workspace-scoped endpoints with that tenant's id in X-Tenant-Id.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OrgsListOrgsResponse> ListOrganizationsAsync(
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List organizations<br/>
        /// Returns the organizations the authenticated caller belongs to. This endpoint does not require X-Tenant-Id and is the entry point for Fleet bootstrap: take an organization's `id` and list its workspaces via GET /v1/fleet/orgs/{org_id}/tenants, then call workspace-scoped endpoints with that tenant's id in X-Tenant-Id.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.OrgsListOrgsResponse>> ListOrganizationsAsResponseAsync(
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}