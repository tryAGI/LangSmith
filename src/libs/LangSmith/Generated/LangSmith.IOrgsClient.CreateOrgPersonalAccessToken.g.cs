#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create Org Personal Access Token
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.APIKeyCreateResponse> CreateOrgPersonalAccessTokenAsync(
            global::LangSmith.APIKeyCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Org Personal Access Token
        /// </summary>
        /// <param name="description">
        /// Default Value: Default API key
        /// </param>
        /// <param name="readOnly">
        /// Default Value: false
        /// </param>
        /// <param name="expiresAt"></param>
        /// <param name="workspaces"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.APIKeyCreateResponse> CreateOrgPersonalAccessTokenAsync(
            string? description = default,
            bool? readOnly = default,
            global::System.DateTime? expiresAt = default,
            global::System.Collections.Generic.IList<global::System.Guid>? workspaces = default,
            global::System.Guid? roleId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}