#nullable enable

namespace LangSmith
{
    public partial interface IUserGroupsClient
    {
        /// <summary>
        /// Grant a user group a role in a workspace<br/>
        /// Gives an organization-wide user group a role in a workspace. User Group members who are<br/>
        /// members of the workspace get the role's permissions there, and their workspace<br/>
        /// identities are recorded as the user group's members in the workspace. The grant also<br/>
        /// creates the user group's workspace scoped user group in the workspace, named after the user group and<br/>
        /// the workspace id, with no members or access policies. A user group has at most one<br/>
        /// grant per workspace. A workspace scoped user group's grant is set when it is created, so<br/>
        /// it cannot be granted. Needs organization:user-groups:manage-grants.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsUserGroupWorkspaceGrant> GrantAUserGroupARoleInAWorkspaceAsync(
            global::System.Guid userGroupId,

            global::LangSmith.UserGroupsCreateUserGroupWorkspaceGrantPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Grant a user group a role in a workspace<br/>
        /// Gives an organization-wide user group a role in a workspace. User Group members who are<br/>
        /// members of the workspace get the role's permissions there, and their workspace<br/>
        /// identities are recorded as the user group's members in the workspace. The grant also<br/>
        /// creates the user group's workspace scoped user group in the workspace, named after the user group and<br/>
        /// the workspace id, with no members or access policies. A user group has at most one<br/>
        /// grant per workspace. A workspace scoped user group's grant is set when it is created, so<br/>
        /// it cannot be granted. Needs organization:user-groups:manage-grants.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UserGroupsUserGroupWorkspaceGrant>> GrantAUserGroupARoleInAWorkspaceAsResponseAsync(
            global::System.Guid userGroupId,

            global::LangSmith.UserGroupsCreateUserGroupWorkspaceGrantPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Grant a user group a role in a workspace<br/>
        /// Gives an organization-wide user group a role in a workspace. User Group members who are<br/>
        /// members of the workspace get the role's permissions there, and their workspace<br/>
        /// identities are recorded as the user group's members in the workspace. The grant also<br/>
        /// creates the user group's workspace scoped user group in the workspace, named after the user group and<br/>
        /// the workspace id, with no members or access policies. A user group has at most one<br/>
        /// grant per workspace. A workspace scoped user group's grant is set when it is created, so<br/>
        /// it cannot be granted. Needs organization:user-groups:manage-grants.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="roleId">
        /// RoleID is a workspace role: a built-in one, or a custom one in this organization.
        /// </param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsUserGroupWorkspaceGrant> GrantAUserGroupARoleInAWorkspaceAsync(
            global::System.Guid userGroupId,
            global::System.Guid roleId,
            global::System.Guid workspaceId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}