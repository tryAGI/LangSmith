#nullable enable

namespace LangSmith
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// List team members<br/>
        /// Lists the members of a team. A page carries next_cursor, which is the value to send<br/>
        /// back as cursor for the next page, and null once the last page has been read. A<br/>
        /// cursor this endpoint did not issue for this team starts again at the first page.<br/>
        /// An organization scoped team needs organization:teams:read.<br/>
        /// A workspace scoped team needs workspaces:teams:read in its workspace.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TeamsListTeamMembersResponse> ListTeamMembersAsync(
            global::System.Guid teamId,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List team members<br/>
        /// Lists the members of a team. A page carries next_cursor, which is the value to send<br/>
        /// back as cursor for the next page, and null once the last page has been read. A<br/>
        /// cursor this endpoint did not issue for this team starts again at the first page.<br/>
        /// An organization scoped team needs organization:teams:read.<br/>
        /// A workspace scoped team needs workspaces:teams:read in its workspace.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TeamsListTeamMembersResponse>> ListTeamMembersAsResponseAsync(
            global::System.Guid teamId,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}