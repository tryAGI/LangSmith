#nullable enable

namespace LangSmith
{
    public partial interface IUserGroupsClient
    {
        /// <summary>
        /// Remove a member from a user group<br/>
        /// Removes an organization member from a user group, along with the workspace identities<br/>
        /// the user group recorded for them. Returns 204 also when the identity was not a member.<br/>
        /// Needs the same permissions as adding members.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="identityId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveAMemberFromAUserGroupAsync(
            global::System.Guid userGroupId,
            global::System.Guid identityId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a member from a user group<br/>
        /// Removes an organization member from a user group, along with the workspace identities<br/>
        /// the user group recorded for them. Returns 204 also when the identity was not a member.<br/>
        /// Needs the same permissions as adding members.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="identityId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> RemoveAMemberFromAUserGroupAsResponseAsync(
            global::System.Guid userGroupId,
            global::System.Guid identityId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}