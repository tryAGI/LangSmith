#nullable enable

namespace LangSmith
{
    public partial interface IUserGroupsClient
    {
        /// <summary>
        /// Update a user group<br/>
        /// Renames an organization-wide user group or changes its description or IdP group mapping.<br/>
        /// Omitted fields are left unchanged, and a null description or idp_group_name clears<br/>
        /// it. idp_sync_enabled needs an IdP group. A workspace scoped user group returns 400: its<br/>
        /// workspace grant creates and deletes it. Needs organization:user-groups:manage.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsUserGroup> UpdateAUserGroupAsync(
            global::System.Guid userGroupId,

            global::LangSmith.UserGroupsUpdateUserGroupPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a user group<br/>
        /// Renames an organization-wide user group or changes its description or IdP group mapping.<br/>
        /// Omitted fields are left unchanged, and a null description or idp_group_name clears<br/>
        /// it. idp_sync_enabled needs an IdP group. A workspace scoped user group returns 400: its<br/>
        /// workspace grant creates and deletes it. Needs organization:user-groups:manage.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UserGroupsUserGroup>> UpdateAUserGroupAsResponseAsync(
            global::System.Guid userGroupId,

            global::LangSmith.UserGroupsUpdateUserGroupPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a user group<br/>
        /// Renames an organization-wide user group or changes its description or IdP group mapping.<br/>
        /// Omitted fields are left unchanged, and a null description or idp_group_name clears<br/>
        /// it. idp_sync_enabled needs an IdP group. A workspace scoped user group returns 400: its<br/>
        /// workspace grant creates and deletes it. Needs organization:user-groups:manage.
        /// </summary>
        /// <param name="userGroupId"></param>
        /// <param name="description">
        /// Description is cleared by null.
        /// </param>
        /// <param name="idpGroupName">
        /// IdpGroupName is cleared by null. Workspace scoped user groups cannot have one.
        /// </param>
        /// <param name="idpSyncEnabled">
        /// IdpSyncEnabled can be true only while the user group has an IdpGroupName.
        /// </param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserGroupsUserGroup> UpdateAUserGroupAsync(
            global::System.Guid userGroupId,
            string? description = default,
            string? idpGroupName = default,
            bool? idpSyncEnabled = default,
            string? name = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}