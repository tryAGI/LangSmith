#nullable enable

namespace LangSmith
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// Delete Personal Access Token<br/>
        /// Delete a Personal Access Token for the user
        /// </summary>
        /// <param name="patId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.APIKeyGetResponse> DeletePersonalAccessTokenAsync(
            global::System.Guid patId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}