#nullable enable

namespace LangSmith
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Change a team's role in a workspace<br/>
        /// Changes an organization-wide team's role in a workspace it has access to. Team<br/>
        /// members get the new role's permissions there in place of the old role's. Access<br/>
        /// policies attached to the team for the workspace stay attached. Needs<br/>
        /// organization:teams:manage-grants.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TeamsTeamWorkspaceGrant> ChangeATeamsRoleInAWorkspaceAsync(
            global::System.Guid teamId,
            global::System.Guid workspaceId,

            global::LangSmith.TeamsUpdateTeamWorkspaceGrantPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change a team's role in a workspace<br/>
        /// Changes an organization-wide team's role in a workspace it has access to. Team<br/>
        /// members get the new role's permissions there in place of the old role's. Access<br/>
        /// policies attached to the team for the workspace stay attached. Needs<br/>
        /// organization:teams:manage-grants.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TeamsTeamWorkspaceGrant>> ChangeATeamsRoleInAWorkspaceAsResponseAsync(
            global::System.Guid teamId,
            global::System.Guid workspaceId,

            global::LangSmith.TeamsUpdateTeamWorkspaceGrantPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change a team's role in a workspace<br/>
        /// Changes an organization-wide team's role in a workspace it has access to. Team<br/>
        /// members get the new role's permissions there in place of the old role's. Access<br/>
        /// policies attached to the team for the workspace stay attached. Needs<br/>
        /// organization:teams:manage-grants.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="roleId">
        /// RoleID is a workspace role: a built-in one, or a custom one in this organization.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TeamsTeamWorkspaceGrant> ChangeATeamsRoleInAWorkspaceAsync(
            global::System.Guid teamId,
            global::System.Guid workspaceId,
            global::System.Guid roleId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}