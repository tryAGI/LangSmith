#nullable enable

namespace LangSmith
{
    public partial interface IUserGroupsClient
    {
        /// <summary>
        /// Attach an access policy to a user group<br/>
        /// Attaches an existing access policy in the organization to a user group. A workspace<br/>
        /// scoped user group's policy applies in its workspace. An organization-wide user group's policy applies<br/>
        /// in the workspace_id given, or in every workspace the user group has access to when it is<br/>
        /// omitted. Returns 201 when the policy is attached, or 200 when it was already<br/>
        /// attached. A workspace scoped user group needs workspaces:user-groups:manage-policies in its<br/>
        /// workspace. An organization scoped user group needs organization:user-groups:manage-policies, and<br/>
        /// for a policy in one workspace the caller must also be a member of that workspace.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsUserGroupAccessPolicy> AttachAnAccessPolicyToAUserGroupAsync(
            global::System.Guid userGroupId,

            global::LangSmith.UserGroupsAttachUserGroupAccessPolicyPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach an access policy to a user group<br/>
        /// Attaches an existing access policy in the organization to a user group. A workspace<br/>
        /// scoped user group's policy applies in its workspace. An organization-wide user group's policy applies<br/>
        /// in the workspace_id given, or in every workspace the user group has access to when it is<br/>
        /// omitted. Returns 201 when the policy is attached, or 200 when it was already<br/>
        /// attached. A workspace scoped user group needs workspaces:user-groups:manage-policies in its<br/>
        /// workspace. An organization scoped user group needs organization:user-groups:manage-policies, and<br/>
        /// for a policy in one workspace the caller must also be a member of that workspace.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UserGroupsUserGroupAccessPolicy>> AttachAnAccessPolicyToAUserGroupAsResponseAsync(
            global::System.Guid userGroupId,

            global::LangSmith.UserGroupsAttachUserGroupAccessPolicyPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach an access policy to a user group<br/>
        /// Attaches an existing access policy in the organization to a user group. A workspace<br/>
        /// scoped user group's policy applies in its workspace. An organization-wide user group's policy applies<br/>
        /// in the workspace_id given, or in every workspace the user group has access to when it is<br/>
        /// omitted. Returns 201 when the policy is attached, or 200 when it was already<br/>
        /// attached. A workspace scoped user group needs workspaces:user-groups:manage-policies in its<br/>
        /// workspace. An organization scoped user group needs organization:user-groups:manage-policies, and<br/>
        /// for a policy in one workspace the caller must also be a member of that workspace.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="accessPolicyId"></param>
        /// <param name="workspaceId">
        /// WorkspaceID limits an organization-wide user group's policy to one workspace. Omit it to apply<br/>
        /// the policy in every workspace the user group has access to. A workspace user group's policy always<br/>
        /// applies in the user group's workspace, so this must be omitted or match it.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsUserGroupAccessPolicy> AttachAnAccessPolicyToAUserGroupAsync(
            global::System.Guid userGroupId,
            global::System.Guid accessPolicyId,
            global::System.Guid? workspaceId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}