#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create Sso Settings<br/>
        /// Create SSO provider settings for the current organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SSOProvider> CreateSsoSettingsAsync(

            global::LangSmith.SSOSettingsCreate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Sso Settings<br/>
        /// Create SSO provider settings for the current organization.
        /// </summary>
        /// <param name="defaultWorkspaceRoleId"></param>
        /// <param name="defaultWorkspaceIds"></param>
        /// <param name="metadataXml"></param>
        /// <param name="metadataUrl"></param>
        /// <param name="attributeMapping"></param>
        /// <param name="ssoGroupsEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="ssoGroupsClaimField">
        /// Default Value: groups
        /// </param>
        /// <param name="ssoGroupsRequired">
        /// Default Value: false
        /// </param>
        /// <param name="ssoGroupsRoleSyncEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SSOProvider> CreateSsoSettingsAsync(
            global::System.Guid defaultWorkspaceRoleId,
            global::System.Collections.Generic.IList<global::System.Guid> defaultWorkspaceIds,
            string? metadataXml = default,
            string? metadataUrl = default,
            global::System.Collections.Generic.Dictionary<string, string>? attributeMapping = default,
            bool? ssoGroupsEnabled = default,
            string? ssoGroupsClaimField = default,
            bool? ssoGroupsRequired = default,
            bool? ssoGroupsRoleSyncEnabled = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}