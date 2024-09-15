#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update Sso Settings<br/>
        /// Update SSO provider settings defaults for the current organization.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SSOProvider> UpdateSsoSettingsAsync(
            global::System.Guid id,
            global::LangSmith.SSOSettingsUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Sso Settings<br/>
        /// Update SSO provider settings defaults for the current organization.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="defaultWorkspaceRoleId"></param>
        /// <param name="defaultWorkspaceIds"></param>
        /// <param name="metadataUrl"></param>
        /// <param name="metadataXml"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SSOProvider> UpdateSsoSettingsAsync(
            global::System.Guid id,
            global::LangSmith.AnyOf<global::System.Guid?, object>? defaultWorkspaceRoleId = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? defaultWorkspaceIds = default,
            global::LangSmith.AnyOf<string, object>? metadataUrl = default,
            global::LangSmith.AnyOf<string, object>? metadataXml = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}