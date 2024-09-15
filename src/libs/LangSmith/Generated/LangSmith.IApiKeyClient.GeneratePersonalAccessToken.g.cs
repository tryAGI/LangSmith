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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.APIKeyCreateResponse> GeneratePersonalAccessTokenAsync(
            global::LangSmith.AllOf<global::LangSmith.APIKeyCreateRequest> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate Personal Access Token<br/>
        /// Generate a Personal Access Token the user
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.APIKeyCreateResponse> GeneratePersonalAccessTokenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}