#nullable enable

namespace LangSmith
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Add members to a team<br/>
        /// Adds organization members to a team and returns a status for each identity:<br/>
        /// CREATED when it was added, UNCHANGED when it was already a member, and FAILED<br/>
        /// when it is not an organization identity in this organization. A workspace<br/>
        /// scoped team only takes people who are members of its workspace, and also records<br/>
        /// their workspace identity. An organization scoped team records each person's workspace<br/>
        /// identity in every workspace it is granted into. The other identities are still<br/>
        /// added. A workspace scoped team needs workspaces:teams:manage-members in its<br/>
        /// workspace, and an organization scoped team needs organization:teams:manage-members.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TeamsAddTeamMembersResponse> AddMembersToATeamAsync(
            global::System.Guid teamId,

            global::LangSmith.TeamsAddTeamMembersPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add members to a team<br/>
        /// Adds organization members to a team and returns a status for each identity:<br/>
        /// CREATED when it was added, UNCHANGED when it was already a member, and FAILED<br/>
        /// when it is not an organization identity in this organization. A workspace<br/>
        /// scoped team only takes people who are members of its workspace, and also records<br/>
        /// their workspace identity. An organization scoped team records each person's workspace<br/>
        /// identity in every workspace it is granted into. The other identities are still<br/>
        /// added. A workspace scoped team needs workspaces:teams:manage-members in its<br/>
        /// workspace, and an organization scoped team needs organization:teams:manage-members.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TeamsAddTeamMembersResponse>> AddMembersToATeamAsResponseAsync(
            global::System.Guid teamId,

            global::LangSmith.TeamsAddTeamMembersPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add members to a team<br/>
        /// Adds organization members to a team and returns a status for each identity:<br/>
        /// CREATED when it was added, UNCHANGED when it was already a member, and FAILED<br/>
        /// when it is not an organization identity in this organization. A workspace<br/>
        /// scoped team only takes people who are members of its workspace, and also records<br/>
        /// their workspace identity. An organization scoped team records each person's workspace<br/>
        /// identity in every workspace it is granted into. The other identities are still<br/>
        /// added. A workspace scoped team needs workspaces:teams:manage-members in its<br/>
        /// workspace, and an organization scoped team needs organization:teams:manage-members.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="identityIds">
        /// IdentityIDs are the organization identities of the users to add.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TeamsAddTeamMembersResponse> AddMembersToATeamAsync(
            global::System.Guid teamId,
            global::System.Collections.Generic.IList<global::System.Guid> identityIds,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}