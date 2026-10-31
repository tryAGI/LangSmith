#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create Organization Roles
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Role> CreateOrganizationRolesAsync(

            global::LangSmith.CreateRoleRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Organization Roles
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.Role>> CreateOrganizationRolesAsResponseAsync(

            global::LangSmith.CreateRoleRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Organization Roles
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="permissions">
        /// Permissions to grant. Organization roles do not require organization:read or organization:read-metadata. Omitting these permissions may limit access to organization settings pages.
        /// </param>
        /// <param name="accessScope">
        /// Scope of the role. Cannot be changed after creation.<br/>
        /// Default Value: workspace
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Role> CreateOrganizationRolesAsync(
            string displayName,
            string description,
            global::System.Collections.Generic.IList<string> permissions,
            global::LangSmith.AccessScope? accessScope = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}