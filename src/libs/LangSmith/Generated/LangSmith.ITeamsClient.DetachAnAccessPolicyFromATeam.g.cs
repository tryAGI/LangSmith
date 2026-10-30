#nullable enable

namespace LangSmith
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Detach an access policy from a team<br/>
        /// Detaches an access policy from a team. A workspace scoped team's policy is detached<br/>
        /// from its workspace. An organization-wide team's policy is detached from the<br/>
        /// workspace_id given, or from every workspace the team has access to when it is<br/>
        /// omitted. Returns 204 also when the policy was not attached. Needs the same<br/>
        /// permissions as attaching the policy.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="accessPolicyId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DetachAnAccessPolicyFromATeamAsync(
            global::System.Guid teamId,
            global::System.Guid accessPolicyId,
            global::System.Guid? workspaceId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detach an access policy from a team<br/>
        /// Detaches an access policy from a team. A workspace scoped team's policy is detached<br/>
        /// from its workspace. An organization-wide team's policy is detached from the<br/>
        /// workspace_id given, or from every workspace the team has access to when it is<br/>
        /// omitted. Returns 204 also when the policy was not attached. Needs the same<br/>
        /// permissions as attaching the policy.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="accessPolicyId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> DetachAnAccessPolicyFromATeamAsResponseAsync(
            global::System.Guid teamId,
            global::System.Guid accessPolicyId,
            global::System.Guid? workspaceId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}