#nullable enable

namespace LangSmith
{
    public partial interface ITenantClient
    {
        /// <summary>
        /// List Tenants<br/>
        /// Get all tenants visible to this auth
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.TenantForUser>> ListTenantsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}