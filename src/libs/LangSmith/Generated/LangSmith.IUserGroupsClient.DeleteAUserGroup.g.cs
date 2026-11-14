#nullable enable

namespace LangSmith
{
    public partial interface IUserGroupsClient
    {
        /// <summary>
        /// Delete a user group<br/>
        /// Deletes an organization-wide user group with its members, workspace grants and access<br/>
        /// policies, and the workspace scoped user groups under it. A workspace scoped user group returns<br/>
        /// 400: removing its parent's grant in the workspace deletes it. Returns 204 also when<br/>
        /// the user group does not exist. Needs organization:user-groups:manage.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAUserGroupAsync(
            global::System.Guid userGroupId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a user group<br/>
        /// Deletes an organization-wide user group with its members, workspace grants and access<br/>
        /// policies, and the workspace scoped user groups under it. A workspace scoped user group returns<br/>
        /// 400: removing its parent's grant in the workspace deletes it. Returns 204 also when<br/>
        /// the user group does not exist. Needs organization:user-groups:manage.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> DeleteAUserGroupAsResponseAsync(
            global::System.Guid userGroupId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}