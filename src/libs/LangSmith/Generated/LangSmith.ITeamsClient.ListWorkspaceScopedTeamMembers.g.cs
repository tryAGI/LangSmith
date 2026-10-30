#nullable enable

namespace LangSmith
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// List workspace scoped team members<br/>
        /// Lists the workspace identities of a workspace scoped team's members. A page carries<br/>
        /// next_cursor, which is the value to send back as cursor for the next page, and null<br/>
        /// once the last page has been read. A cursor this endpoint did not issue for this<br/>
        /// team starts again at the first page. Needs workspaces:teams:read in<br/>
        /// the team's workspace.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TeamsListTeamWorkspaceMembersResponse> ListWorkspaceScopedTeamMembersAsync(
            global::System.Guid teamId,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List workspace scoped team members<br/>
        /// Lists the workspace identities of a workspace scoped team's members. A page carries<br/>
        /// next_cursor, which is the value to send back as cursor for the next page, and null<br/>
        /// once the last page has been read. A cursor this endpoint did not issue for this<br/>
        /// team starts again at the first page. Needs workspaces:teams:read in<br/>
        /// the team's workspace.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TeamsListTeamWorkspaceMembersResponse>> ListWorkspaceScopedTeamMembersAsResponseAsync(
            global::System.Guid teamId,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}