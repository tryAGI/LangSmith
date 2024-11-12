#nullable enable

namespace LangSmith
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Set Tenant Handle<br/>
        /// Set tenant handle.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AppHubCrudTenantsTenant> SetTenantHandleAsync(
            global::LangSmith.SetTenantHandleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set Tenant Handle<br/>
        /// Set tenant handle.
        /// </summary>
        /// <param name="tenantHandle"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AppHubCrudTenantsTenant> SetTenantHandleAsync(
            string tenantHandle,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}