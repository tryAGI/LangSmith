#nullable enable

namespace LangSmith
{
    public partial interface IUserGroupsClient
    {
        /// <summary>
        /// List a user group's workspace grants<br/>
        /// Lists the workspaces an organization-wide user group has access to and its role in each.<br/>
        /// A workspace scoped user group returns 400, since its access to its own workspace is set<br/>
        /// when it is created. A page carries next_cursor, which is the value to send back as<br/>
        /// cursor for the next page, and null once the last page has been read. A cursor this<br/>
        /// endpoint did not issue for this user group starts again at the first page. Needs<br/>
        /// organization:user-groups:read.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsListUserGroupWorkspaceGrantsResponse> ListAUserGroupsWorkspaceGrantsAsync(
            global::System.Guid userGroupId,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List a user group's workspace grants<br/>
        /// Lists the workspaces an organization-wide user group has access to and its role in each.<br/>
        /// A workspace scoped user group returns 400, since its access to its own workspace is set<br/>
        /// when it is created. A page carries next_cursor, which is the value to send back as<br/>
        /// cursor for the next page, and null once the last page has been read. A cursor this<br/>
        /// endpoint did not issue for this user group starts again at the first page. Needs<br/>
        /// organization:user-groups:read.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UserGroupsListUserGroupWorkspaceGrantsResponse>> ListAUserGroupsWorkspaceGrantsAsResponseAsync(
            global::System.Guid userGroupId,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}