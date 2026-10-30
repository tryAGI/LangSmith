#nullable enable

namespace LangSmith
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Get a team's role in a workspace<br/>
        /// Gets an organization-wide team's grant in one workspace. A workspace scoped team<br/>
        /// returns 400, since its access to its own workspace is set when it is created.<br/>
        /// Needs organization:teams:read, or workspaces:teams:read in the workspace.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TeamsTeamWorkspaceGrant> GetATeamsRoleInAWorkspaceAsync(
            global::System.Guid teamId,
            global::System.Guid workspaceId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a team's role in a workspace<br/>
        /// Gets an organization-wide team's grant in one workspace. A workspace scoped team<br/>
        /// returns 400, since its access to its own workspace is set when it is created.<br/>
        /// Needs organization:teams:read, or workspaces:teams:read in the workspace.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TeamsTeamWorkspaceGrant>> GetATeamsRoleInAWorkspaceAsResponseAsync(
            global::System.Guid teamId,
            global::System.Guid workspaceId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}