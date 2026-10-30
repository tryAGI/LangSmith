#nullable enable

namespace LangSmith
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Attach an access policy to a team<br/>
        /// Attaches an existing access policy in the organization to a team. A workspace<br/>
        /// scoped team's policy applies in its workspace. An organization-wide team's policy applies<br/>
        /// in the workspace_id given, or in every workspace the team has access to when it is<br/>
        /// omitted. Returns 201 when the policy is attached, or 200 when it was already<br/>
        /// attached. A workspace scoped team needs workspaces:teams:manage-policies in its<br/>
        /// workspace. An organization scoped team needs organization:teams:manage-policies, and<br/>
        /// for a policy in one workspace the caller must also be a member of that workspace.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TeamsTeamAccessPolicy> AttachAnAccessPolicyToATeamAsync(
            global::System.Guid teamId,

            global::LangSmith.TeamsAttachTeamAccessPolicyPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach an access policy to a team<br/>
        /// Attaches an existing access policy in the organization to a team. A workspace<br/>
        /// scoped team's policy applies in its workspace. An organization-wide team's policy applies<br/>
        /// in the workspace_id given, or in every workspace the team has access to when it is<br/>
        /// omitted. Returns 201 when the policy is attached, or 200 when it was already<br/>
        /// attached. A workspace scoped team needs workspaces:teams:manage-policies in its<br/>
        /// workspace. An organization scoped team needs organization:teams:manage-policies, and<br/>
        /// for a policy in one workspace the caller must also be a member of that workspace.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TeamsTeamAccessPolicy>> AttachAnAccessPolicyToATeamAsResponseAsync(
            global::System.Guid teamId,

            global::LangSmith.TeamsAttachTeamAccessPolicyPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach an access policy to a team<br/>
        /// Attaches an existing access policy in the organization to a team. A workspace<br/>
        /// scoped team's policy applies in its workspace. An organization-wide team's policy applies<br/>
        /// in the workspace_id given, or in every workspace the team has access to when it is<br/>
        /// omitted. Returns 201 when the policy is attached, or 200 when it was already<br/>
        /// attached. A workspace scoped team needs workspaces:teams:manage-policies in its<br/>
        /// workspace. An organization scoped team needs organization:teams:manage-policies, and<br/>
        /// for a policy in one workspace the caller must also be a member of that workspace.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="accessPolicyId"></param>
        /// <param name="workspaceId">
        /// WorkspaceID limits an organization-wide team's policy to one workspace. Omit it to apply<br/>
        /// the policy in every workspace the team has access to. A workspace team's policy always<br/>
        /// applies in the team's workspace, so this must be omitted or match it.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TeamsTeamAccessPolicy> AttachAnAccessPolicyToATeamAsync(
            global::System.Guid teamId,
            global::System.Guid accessPolicyId,
            global::System.Guid? workspaceId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}