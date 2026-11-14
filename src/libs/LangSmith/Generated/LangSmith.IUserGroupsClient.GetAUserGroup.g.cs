#nullable enable

namespace LangSmith
{
    public partial interface IUserGroupsClient
    {
        /// <summary>
        /// Get a user group<br/>
        /// Gets one user group in the organization.<br/>
        /// An organization scoped user group needs organization:user-groups:read.<br/>
        /// A workspace scoped user group needs workspaces:user-groups:read in its workspace.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsUserGroup> GetAUserGroupAsync(
            global::System.Guid userGroupId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a user group<br/>
        /// Gets one user group in the organization.<br/>
        /// An organization scoped user group needs organization:user-groups:read.<br/>
        /// A workspace scoped user group needs workspaces:user-groups:read in its workspace.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UserGroupsUserGroup>> GetAUserGroupAsResponseAsync(
            global::System.Guid userGroupId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}