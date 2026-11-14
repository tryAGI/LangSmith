#nullable enable

namespace LangSmith
{
    public partial interface IUserGroupsClient
    {
        /// <summary>
        /// Remove a user group's access to a workspace<br/>
        /// Removes an organization-wide user group's grant in a workspace. This also detaches the<br/>
        /// user group's access policies attached for that workspace and deletes the user group's workspace<br/>
        /// scoped user group there. Policies attached for every workspace stay. Returns 204 also when<br/>
        /// the user group had no access to the workspace.<br/>
        /// Needs organization:user-groups:manage-grants.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveAUserGroupsAccessToAWorkspaceAsync(
            global::System.Guid userGroupId,
            global::System.Guid workspaceId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a user group's access to a workspace<br/>
        /// Removes an organization-wide user group's grant in a workspace. This also detaches the<br/>
        /// user group's access policies attached for that workspace and deletes the user group's workspace<br/>
        /// scoped user group there. Policies attached for every workspace stay. Returns 204 also when<br/>
        /// the user group had no access to the workspace.<br/>
        /// Needs organization:user-groups:manage-grants.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> RemoveAUserGroupsAccessToAWorkspaceAsResponseAsync(
            global::System.Guid userGroupId,
            global::System.Guid workspaceId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}