#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update Current Organization Info
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OrganizationInfo> UpdateCurrentOrganizationInfoAsync(

            global::LangSmith.OrganizationUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Current Organization Info
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="publicSharingDisabled"></param>
        /// <param name="patCreationDisabled"></param>
        /// <param name="unshareAll"></param>
        /// <param name="jitProvisioningEnabled"></param>
        /// <param name="workspaceAdminCanInviteToOrg"></param>
        /// <param name="invitesEnabled"></param>
        /// <param name="maxApiKeyExpiryDays"></param>
        /// <param name="securityContact"></param>
        /// <param name="maxPatExpiryDays"></param>
        /// <param name="maxServiceKeyExpiryDays"></param>
        /// <param name="scimGroupNameSeparator"></param>
        /// <param name="llmAuthProxyEnabled"></param>
        /// <param name="llmAuthProxyJwtAudience"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OrganizationInfo> UpdateCurrentOrganizationInfoAsync(
            string? displayName = default,
            bool? publicSharingDisabled = default,
            bool? patCreationDisabled = default,
            bool? unshareAll = default,
            bool? jitProvisioningEnabled = default,
            bool? workspaceAdminCanInviteToOrg = default,
            bool? invitesEnabled = default,
            int? maxApiKeyExpiryDays = default,
            string? securityContact = default,
            int? maxPatExpiryDays = default,
            int? maxServiceKeyExpiryDays = default,
            string? scimGroupNameSeparator = default,
            bool? llmAuthProxyEnabled = default,
            string? llmAuthProxyJwtAudience = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}