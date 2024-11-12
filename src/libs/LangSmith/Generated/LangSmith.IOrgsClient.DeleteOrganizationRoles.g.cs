#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Delete Organization Roles
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Role> DeleteOrganizationRolesAsync(
            global::System.Guid roleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}