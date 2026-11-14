#nullable enable

namespace LangSmith
{
    public partial interface IUserGroupsClient
    {
        /// <summary>
        /// Change a user group's role in a workspace<br/>
        /// Changes an organization-wide user group's role in a workspace it has access to. User Group<br/>
        /// members get the new role's permissions there in place of the old role's. Access<br/>
        /// policies attached to the user group for the workspace stay attached. Needs<br/>
        /// organization:user-groups:manage-grants.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsUserGroupWorkspaceGrant> ChangeAUserGroupsRoleInAWorkspaceAsync(
            global::System.Guid userGroupId,
            global::System.Guid workspaceId,

            global::LangSmith.UserGroupsUpdateUserGroupWorkspaceGrantPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change a user group's role in a workspace<br/>
        /// Changes an organization-wide user group's role in a workspace it has access to. User Group<br/>
        /// members get the new role's permissions there in place of the old role's. Access<br/>
        /// policies attached to the user group for the workspace stay attached. Needs<br/>
        /// organization:user-groups:manage-grants.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UserGroupsUserGroupWorkspaceGrant>> ChangeAUserGroupsRoleInAWorkspaceAsResponseAsync(
            global::System.Guid userGroupId,
            global::System.Guid workspaceId,

            global::LangSmith.UserGroupsUpdateUserGroupWorkspaceGrantPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change a user group's role in a workspace<br/>
        /// Changes an organization-wide user group's role in a workspace it has access to. User Group<br/>
        /// members get the new role's permissions there in place of the old role's. Access<br/>
        /// policies attached to the user group for the workspace stay attached. Needs<br/>
        /// organization:user-groups:manage-grants.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="roleId">
        /// RoleID is a workspace role: a built-in one, or a custom one in this organization.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsUserGroupWorkspaceGrant> ChangeAUserGroupsRoleInAWorkspaceAsync(
            global::System.Guid userGroupId,
            global::System.Guid workspaceId,
            global::System.Guid roleId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}