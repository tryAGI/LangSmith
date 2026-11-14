#nullable enable

namespace LangSmith
{
    public partial interface IUserGroupsClient
    {
        /// <summary>
        /// Detach an access policy from a user group<br/>
        /// Detaches an access policy from a user group. A workspace scoped user group's policy is detached<br/>
        /// from its workspace. An organization-wide user group's policy is detached from the<br/>
        /// workspace_id given, or from every workspace the user group has access to when it is<br/>
        /// omitted. Returns 204 also when the policy was not attached. Needs the same<br/>
        /// permissions as attaching the policy.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="accessPolicyId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DetachAnAccessPolicyFromAUserGroupAsync(
            global::System.Guid userGroupId,
            global::System.Guid accessPolicyId,
            global::System.Guid? workspaceId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detach an access policy from a user group<br/>
        /// Detaches an access policy from a user group. A workspace scoped user group's policy is detached<br/>
        /// from its workspace. An organization-wide user group's policy is detached from the<br/>
        /// workspace_id given, or from every workspace the user group has access to when it is<br/>
        /// omitted. Returns 204 also when the policy was not attached. Needs the same<br/>
        /// permissions as attaching the policy.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="accessPolicyId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> DetachAnAccessPolicyFromAUserGroupAsResponseAsync(
            global::System.Guid userGroupId,
            global::System.Guid accessPolicyId,
            global::System.Guid? workspaceId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}