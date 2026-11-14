#nullable enable

namespace LangSmith
{
    public partial interface IUserGroupsClient
    {
        /// <summary>
        /// List a user group's access policies<br/>
        /// Lists the access policies attached to a user group. A page carries next_cursor, which is<br/>
        /// the value to send back as cursor for the next page, and null once the last page<br/>
        /// has been read. A cursor this endpoint did not issue for this user group starts again at<br/>
        /// the first page.<br/>
        /// An organization scoped user group needs organization:user-groups:read.<br/>
        /// A workspace scoped user group needs workspaces:user-groups:read in its workspace.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsListUserGroupAccessPoliciesResponse> ListAUserGroupsAccessPoliciesAsync(
            global::System.Guid userGroupId,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List a user group's access policies<br/>
        /// Lists the access policies attached to a user group. A page carries next_cursor, which is<br/>
        /// the value to send back as cursor for the next page, and null once the last page<br/>
        /// has been read. A cursor this endpoint did not issue for this user group starts again at<br/>
        /// the first page.<br/>
        /// An organization scoped user group needs organization:user-groups:read.<br/>
        /// A workspace scoped user group needs workspaces:user-groups:read in its workspace.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UserGroupsListUserGroupAccessPoliciesResponse>> ListAUserGroupsAccessPoliciesAsResponseAsync(
            global::System.Guid userGroupId,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}