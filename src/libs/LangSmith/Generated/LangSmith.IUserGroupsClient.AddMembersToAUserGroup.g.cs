#nullable enable

namespace LangSmith
{
    public partial interface IUserGroupsClient
    {
        /// <summary>
        /// Add members to a user group<br/>
        /// Adds organization members to a user group and returns a status for each identity:<br/>
        /// CREATED when it was added, UNCHANGED when it was already a member, and FAILED<br/>
        /// when it is not an organization identity in this organization. A workspace<br/>
        /// scoped user group only takes people who are members of its workspace, and also records<br/>
        /// their workspace identity. An organization scoped user group records each person's workspace<br/>
        /// identity in every workspace it is granted into. The other identities are still<br/>
        /// added. A workspace scoped user group needs workspaces:user-groups:manage-members in its<br/>
        /// workspace, and an organization scoped user group needs organization:user-groups:manage-members.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsAddUserGroupMembersResponse> AddMembersToAUserGroupAsync(
            global::System.Guid userGroupId,

            global::LangSmith.UserGroupsAddUserGroupMembersPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add members to a user group<br/>
        /// Adds organization members to a user group and returns a status for each identity:<br/>
        /// CREATED when it was added, UNCHANGED when it was already a member, and FAILED<br/>
        /// when it is not an organization identity in this organization. A workspace<br/>
        /// scoped user group only takes people who are members of its workspace, and also records<br/>
        /// their workspace identity. An organization scoped user group records each person's workspace<br/>
        /// identity in every workspace it is granted into. The other identities are still<br/>
        /// added. A workspace scoped user group needs workspaces:user-groups:manage-members in its<br/>
        /// workspace, and an organization scoped user group needs organization:user-groups:manage-members.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UserGroupsAddUserGroupMembersResponse>> AddMembersToAUserGroupAsResponseAsync(
            global::System.Guid userGroupId,

            global::LangSmith.UserGroupsAddUserGroupMembersPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add members to a user group<br/>
        /// Adds organization members to a user group and returns a status for each identity:<br/>
        /// CREATED when it was added, UNCHANGED when it was already a member, and FAILED<br/>
        /// when it is not an organization identity in this organization. A workspace<br/>
        /// scoped user group only takes people who are members of its workspace, and also records<br/>
        /// their workspace identity. An organization scoped user group records each person's workspace<br/>
        /// identity in every workspace it is granted into. The other identities are still<br/>
        /// added. A workspace scoped user group needs workspaces:user-groups:manage-members in its<br/>
        /// workspace, and an organization scoped user group needs organization:user-groups:manage-members.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="identityIds">
        /// IdentityIDs are the organization identities of the users to add.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsAddUserGroupMembersResponse> AddMembersToAUserGroupAsync(
            global::System.Guid userGroupId,
            global::System.Collections.Generic.IList<global::System.Guid> identityIds,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}