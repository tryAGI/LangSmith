#nullable enable

namespace LangSmith
{
    public partial interface IUserGroupsClient
    {
        /// <summary>
        /// Create a user group<br/>
        /// Creates an organization-wide user group. Needs organization:user-groups:manage. Workspace scoped<br/>
        /// user groups are not created here: granting an organization-wide user group access to a<br/>
        /// workspace creates its workspace scoped user group there, so workspace_id and<br/>
        /// parent_user_group_id return 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsUserGroup> CreateAUserGroupAsync(

            global::LangSmith.UserGroupsCreateUserGroupPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a user group<br/>
        /// Creates an organization-wide user group. Needs organization:user-groups:manage. Workspace scoped<br/>
        /// user groups are not created here: granting an organization-wide user group access to a<br/>
        /// workspace creates its workspace scoped user group there, so workspace_id and<br/>
        /// parent_user_group_id return 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UserGroupsUserGroup>> CreateAUserGroupAsResponseAsync(

            global::LangSmith.UserGroupsCreateUserGroupPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a user group<br/>
        /// Creates an organization-wide user group. Needs organization:user-groups:manage. Workspace scoped<br/>
        /// user groups are not created here: granting an organization-wide user group access to a<br/>
        /// workspace creates its workspace scoped user group there, so workspace_id and<br/>
        /// parent_user_group_id return 400.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="parentUserGroupId"></param>
        /// <param name="workspaceId">
        /// Rejected with 400, so a request for a workspace user group does not create an<br/>
        /// organization-wide user group. Granting a user group a workspace creates its workspace user group.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsUserGroup> CreateAUserGroupAsync(
            string name,
            string? description = default,
            global::System.Guid? parentUserGroupId = default,
            global::System.Guid? workspaceId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}