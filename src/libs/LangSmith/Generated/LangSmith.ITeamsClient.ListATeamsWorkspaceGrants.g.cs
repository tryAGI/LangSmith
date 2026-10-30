#nullable enable

namespace LangSmith
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// List a team's workspace grants<br/>
        /// Lists the workspaces an organization-wide team has access to and its role in each.<br/>
        /// A workspace scoped team returns 400, since its access to its own workspace is set<br/>
        /// when it is created. A page carries next_cursor, which is the value to send back as<br/>
        /// cursor for the next page, and null once the last page has been read. A cursor this<br/>
        /// endpoint did not issue for this team starts again at the first page. Needs<br/>
        /// organization:teams:read.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TeamsListTeamWorkspaceGrantsResponse> ListATeamsWorkspaceGrantsAsync(
            global::System.Guid teamId,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List a team's workspace grants<br/>
        /// Lists the workspaces an organization-wide team has access to and its role in each.<br/>
        /// A workspace scoped team returns 400, since its access to its own workspace is set<br/>
        /// when it is created. A page carries next_cursor, which is the value to send back as<br/>
        /// cursor for the next page, and null once the last page has been read. A cursor this<br/>
        /// endpoint did not issue for this team starts again at the first page. Needs<br/>
        /// organization:teams:read.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TeamsListTeamWorkspaceGrantsResponse>> ListATeamsWorkspaceGrantsAsResponseAsync(
            global::System.Guid teamId,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}