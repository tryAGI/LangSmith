#nullable enable

namespace LangSmith
{
    public partial interface ITenantClient
    {
        /// <summary>
        /// List Tenants<br/>
        /// Get all tenants visible to this auth
        /// </summary>
        /// <param name="skipCreate">
        /// Default Value: false
        /// </param>
        /// <param name="includeDeleted">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.TenantForUser>> ListTenantsAsync(
            bool? skipCreate = default,
            bool? includeDeleted = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}