#nullable enable

namespace LangSmith
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Create a team<br/>
        /// Creates an organization-wide team. Needs organization:teams:manage. Workspace scoped<br/>
        /// teams are not created here: granting an organization-wide team access to a<br/>
        /// workspace creates its workspace scoped team there, so workspace_id and<br/>
        /// parent_team_id return 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TeamsTeam> CreateATeamAsync(

            global::LangSmith.TeamsCreateTeamPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a team<br/>
        /// Creates an organization-wide team. Needs organization:teams:manage. Workspace scoped<br/>
        /// teams are not created here: granting an organization-wide team access to a<br/>
        /// workspace creates its workspace scoped team there, so workspace_id and<br/>
        /// parent_team_id return 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TeamsTeam>> CreateATeamAsResponseAsync(

            global::LangSmith.TeamsCreateTeamPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a team<br/>
        /// Creates an organization-wide team. Needs organization:teams:manage. Workspace scoped<br/>
        /// teams are not created here: granting an organization-wide team access to a<br/>
        /// workspace creates its workspace scoped team there, so workspace_id and<br/>
        /// parent_team_id return 400.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="parentTeamId"></param>
        /// <param name="workspaceId">
        /// Rejected with 400, so a request for a workspace team does not create an<br/>
        /// organization-wide team. Granting a team a workspace creates its workspace team.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TeamsTeam> CreateATeamAsync(
            string name,
            string? description = default,
            global::System.Guid? parentTeamId = default,
            global::System.Guid? workspaceId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}