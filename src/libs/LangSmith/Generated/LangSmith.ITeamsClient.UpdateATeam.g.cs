#nullable enable

namespace LangSmith
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Update a team<br/>
        /// Renames an organization-wide team or changes its description or IdP group mapping.<br/>
        /// Omitted fields are left unchanged, and a null description or idp_group_name clears<br/>
        /// it. idp_sync_enabled needs an IdP group. A workspace scoped team returns 400: its<br/>
        /// workspace grant creates and deletes it. Needs organization:teams:manage.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TeamsTeam> UpdateATeamAsync(
            global::System.Guid teamId,

            global::LangSmith.TeamsUpdateTeamPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a team<br/>
        /// Renames an organization-wide team or changes its description or IdP group mapping.<br/>
        /// Omitted fields are left unchanged, and a null description or idp_group_name clears<br/>
        /// it. idp_sync_enabled needs an IdP group. A workspace scoped team returns 400: its<br/>
        /// workspace grant creates and deletes it. Needs organization:teams:manage.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TeamsTeam>> UpdateATeamAsResponseAsync(
            global::System.Guid teamId,

            global::LangSmith.TeamsUpdateTeamPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a team<br/>
        /// Renames an organization-wide team or changes its description or IdP group mapping.<br/>
        /// Omitted fields are left unchanged, and a null description or idp_group_name clears<br/>
        /// it. idp_sync_enabled needs an IdP group. A workspace scoped team returns 400: its<br/>
        /// workspace grant creates and deletes it. Needs organization:teams:manage.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="description">
        /// Description is cleared by null.
        /// </param>
        /// <param name="idpGroupName">
        /// IdpGroupName is cleared by null. Workspace scoped teams cannot have one.
        /// </param>
        /// <param name="idpSyncEnabled">
        /// IdpSyncEnabled can be true only while the team has an IdpGroupName.
        /// </param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TeamsTeam> UpdateATeamAsync(
            global::System.Guid teamId,
            string? description = default,
            string? idpGroupName = default,
            bool? idpSyncEnabled = default,
            string? name = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}