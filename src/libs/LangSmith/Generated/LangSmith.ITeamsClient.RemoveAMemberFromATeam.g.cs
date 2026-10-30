#nullable enable

namespace LangSmith
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Remove a member from a team<br/>
        /// Removes an organization member from a team, along with the workspace identities<br/>
        /// the team recorded for them. Returns 204 also when the identity was not a member.<br/>
        /// Needs the same permissions as adding members.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="identityId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveAMemberFromATeamAsync(
            global::System.Guid teamId,
            global::System.Guid identityId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a member from a team<br/>
        /// Removes an organization member from a team, along with the workspace identities<br/>
        /// the team recorded for them. Returns 204 also when the identity was not a member.<br/>
        /// Needs the same permissions as adding members.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="identityId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> RemoveAMemberFromATeamAsResponseAsync(
            global::System.Guid teamId,
            global::System.Guid identityId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}