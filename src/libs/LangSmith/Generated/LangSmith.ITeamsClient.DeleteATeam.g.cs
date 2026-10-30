#nullable enable

namespace LangSmith
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Delete a team<br/>
        /// Deletes an organization-wide team with its members, workspace grants and access<br/>
        /// policies, and the workspace scoped teams under it. A workspace scoped team returns<br/>
        /// 400: removing its parent's grant in the workspace deletes it. Returns 204 also when<br/>
        /// the team does not exist. Needs organization:teams:manage.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteATeamAsync(
            global::System.Guid teamId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a team<br/>
        /// Deletes an organization-wide team with its members, workspace grants and access<br/>
        /// policies, and the workspace scoped teams under it. A workspace scoped team returns<br/>
        /// 400: removing its parent's grant in the workspace deletes it. Returns 204 also when<br/>
        /// the team does not exist. Needs organization:teams:manage.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> DeleteATeamAsResponseAsync(
            global::System.Guid teamId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}