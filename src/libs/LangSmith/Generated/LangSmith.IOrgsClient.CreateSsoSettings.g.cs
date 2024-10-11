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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SSOProvider> CreateSsoSettingsAsync(
            global::LangSmith.SSOSettingsCreate request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SSOProvider> CreateSsoSettingsAsync(
            global::System.Guid defaultWorkspaceRoleId,
            global::System.Collections.Generic.IList<global::System.Guid> defaultWorkspaceIds,
            global::LangSmith.AnyOf<string, object>? metadataXml = default,
            global::LangSmith.AnyOf<string, object>? metadataUrl = default,
            global::System.Collections.Generic.Dictionary<string, string>? attributeMapping = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}