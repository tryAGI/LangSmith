#nullable enable

namespace LangSmith
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// Generate Personal Access Token<br/>
        /// Generate a Personal Access Token the user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.APIKeyCreateResponse> GeneratePersonalAccessTokenAsync(
            global::LangSmith.APIKeyCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate Personal Access Token<br/>
        /// Generate a Personal Access Token the user
        /// </summary>
        /// <param name="description">
        /// Default Value: Default API key
        /// </param>
        /// <param name="readOnly">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.APIKeyCreateResponse> GeneratePersonalAccessTokenAsync(
            string? description = default,
            bool? readOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}