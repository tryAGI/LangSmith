#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// Generate Personal Access Token<br/>
        /// DEPRECATED: Use /orgs/current/personal-access-tokens instead
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.APIKeyCreateResponse> GeneratePersonalAccessTokenAsync(

            global::LangSmith.APIKeyCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Personal Access Token<br/>
        /// DEPRECATED: Use /orgs/current/personal-access-tokens instead
        /// </summary>
        /// <param name="description">
        /// Default Value: Default API key
        /// </param>
        /// <param name="expiresAt"></param>
        /// <param name="workspaces"></param>
        /// <param name="roleId"></param>
        /// <param name="orgRoleId"></param>
        /// <param name="defaultWorkspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.APIKeyCreateResponse> GeneratePersonalAccessTokenAsync(
            string? description = default,
            global::System.DateTime? expiresAt = default,
            global::System.Collections.Generic.IList<global::System.Guid>? workspaces = default,
            global::System.Guid? roleId = default,
            global::System.Guid? orgRoleId = default,
            global::System.Guid? defaultWorkspaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}