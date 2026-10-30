#nullable enable

namespace LangSmith
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Remove a team's access to a workspace<br/>
        /// Removes an organization-wide team's grant in a workspace. This also detaches the<br/>
        /// team's access policies attached for that workspace and deletes the team's workspace<br/>
        /// scoped team there. Policies attached for every workspace stay. Returns 204 also when<br/>
        /// the team had no access to the workspace.<br/>
        /// Needs organization:teams:manage-grants.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveATeamsAccessToAWorkspaceAsync(
            global::System.Guid teamId,
            global::System.Guid workspaceId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a team's access to a workspace<br/>
        /// Removes an organization-wide team's grant in a workspace. This also detaches the<br/>
        /// team's access policies attached for that workspace and deletes the team's workspace<br/>
        /// scoped team there. Policies attached for every workspace stay. Returns 204 also when<br/>
        /// the team had no access to the workspace.<br/>
        /// Needs organization:teams:manage-grants.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> RemoveATeamsAccessToAWorkspaceAsResponseAsync(
            global::System.Guid teamId,
            global::System.Guid workspaceId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}