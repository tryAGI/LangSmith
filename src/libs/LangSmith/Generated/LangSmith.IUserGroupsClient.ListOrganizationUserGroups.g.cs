#nullable enable

namespace LangSmith
{
    public partial interface IUserGroupsClient
    {
        /// <summary>
        /// List organization user groups<br/>
        /// Lists the organization's user groups in name order. A page carries next_cursor, which is<br/>
        /// the value to send back as cursor for the next page, and null once the last page<br/>
        /// has been read. A cursor this endpoint did not issue, or one issued for different<br/>
        /// filters, starts again at the first page. Organization scoped user groups are listed when<br/>
        /// the caller has organization:user-groups:read. Workspace scoped user groups are listed only in<br/>
        /// workspaces where the caller has workspaces:user-groups:read. With workspace_id, the list<br/>
        /// has the workspace's own user groups and the organization scoped user groups granted into it,<br/>
        /// each with role_id and role_name; granted user groups are also listed when the caller has<br/>
        /// workspaces:user-groups:read in that workspace.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="parentUserGroupId"></param>
        /// <param name="identityId"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsListUserGroupsResponse> ListOrganizationUserGroupsAsync(
            global::System.Guid? workspaceId = default,
            global::System.Guid? parentUserGroupId = default,
            global::System.Guid? identityId = default,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List organization user groups<br/>
        /// Lists the organization's user groups in name order. A page carries next_cursor, which is<br/>
        /// the value to send back as cursor for the next page, and null once the last page<br/>
        /// has been read. A cursor this endpoint did not issue, or one issued for different<br/>
        /// filters, starts again at the first page. Organization scoped user groups are listed when<br/>
        /// the caller has organization:user-groups:read. Workspace scoped user groups are listed only in<br/>
        /// workspaces where the caller has workspaces:user-groups:read. With workspace_id, the list<br/>
        /// has the workspace's own user groups and the organization scoped user groups granted into it,<br/>
        /// each with role_id and role_name; granted user groups are also listed when the caller has<br/>
        /// workspaces:user-groups:read in that workspace.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="parentUserGroupId"></param>
        /// <param name="identityId"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UserGroupsListUserGroupsResponse>> ListOrganizationUserGroupsAsResponseAsync(
            global::System.Guid? workspaceId = default,
            global::System.Guid? parentUserGroupId = default,
            global::System.Guid? identityId = default,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}