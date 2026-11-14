#nullable enable

namespace LangSmith
{
    public partial interface IUserGroupsClient
    {
        /// <summary>
        /// Get a user group's role in a workspace<br/>
        /// Gets an organization-wide user group's grant in one workspace. A workspace scoped user group<br/>
        /// returns 400, since its access to its own workspace is set when it is created.<br/>
        /// Needs organization:user-groups:read, or workspaces:user-groups:read in the workspace.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsUserGroupWorkspaceGrant> GetAUserGroupsRoleInAWorkspaceAsync(
            global::System.Guid userGroupId,
            global::System.Guid workspaceId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a user group's role in a workspace<br/>
        /// Gets an organization-wide user group's grant in one workspace. A workspace scoped user group<br/>
        /// returns 400, since its access to its own workspace is set when it is created.<br/>
        /// Needs organization:user-groups:read, or workspaces:user-groups:read in the workspace.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UserGroupsUserGroupWorkspaceGrant>> GetAUserGroupsRoleInAWorkspaceAsResponseAsync(
            global::System.Guid userGroupId,
            global::System.Guid workspaceId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}