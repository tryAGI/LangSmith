#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create Organization Roles
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Role> CreateOrganizationRolesAsync(
            global::LangSmith.CreateRoleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Organization Roles
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="permissions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Role> CreateOrganizationRolesAsync(
            string displayName,
            string description,
            global::System.Collections.Generic.IList<string> permissions,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}