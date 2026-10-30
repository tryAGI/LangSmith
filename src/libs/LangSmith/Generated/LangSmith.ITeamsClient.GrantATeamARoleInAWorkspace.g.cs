#nullable enable

namespace LangSmith
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Grant a team a role in a workspace<br/>
        /// Gives an organization-wide team a role in a workspace. Team members who are<br/>
        /// members of the workspace get the role's permissions there, and their workspace<br/>
        /// identities are recorded as the team's members in the workspace. The grant also<br/>
        /// creates the team's workspace scoped team in the workspace, named after the team and<br/>
        /// the workspace id, with no members or access policies. A team has at most one<br/>
        /// grant per workspace. A workspace scoped team's grant is set when it is created, so<br/>
        /// it cannot be granted. Needs organization:teams:manage-grants.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TeamsTeamWorkspaceGrant> GrantATeamARoleInAWorkspaceAsync(
            global::System.Guid teamId,

            global::LangSmith.TeamsCreateTeamWorkspaceGrantPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Grant a team a role in a workspace<br/>
        /// Gives an organization-wide team a role in a workspace. Team members who are<br/>
        /// members of the workspace get the role's permissions there, and their workspace<br/>
        /// identities are recorded as the team's members in the workspace. The grant also<br/>
        /// creates the team's workspace scoped team in the workspace, named after the team and<br/>
        /// the workspace id, with no members or access policies. A team has at most one<br/>
        /// grant per workspace. A workspace scoped team's grant is set when it is created, so<br/>
        /// it cannot be granted. Needs organization:teams:manage-grants.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TeamsTeamWorkspaceGrant>> GrantATeamARoleInAWorkspaceAsResponseAsync(
            global::System.Guid teamId,

            global::LangSmith.TeamsCreateTeamWorkspaceGrantPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Grant a team a role in a workspace<br/>
        /// Gives an organization-wide team a role in a workspace. Team members who are<br/>
        /// members of the workspace get the role's permissions there, and their workspace<br/>
        /// identities are recorded as the team's members in the workspace. The grant also<br/>
        /// creates the team's workspace scoped team in the workspace, named after the team and<br/>
        /// the workspace id, with no members or access policies. A team has at most one<br/>
        /// grant per workspace. A workspace scoped team's grant is set when it is created, so<br/>
        /// it cannot be granted. Needs organization:teams:manage-grants.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="roleId">
        /// RoleID is a workspace role: a built-in one, or a custom one in this organization.
        /// </param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TeamsTeamWorkspaceGrant> GrantATeamARoleInAWorkspaceAsync(
            global::System.Guid teamId,
            global::System.Guid roleId,
            global::System.Guid workspaceId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}