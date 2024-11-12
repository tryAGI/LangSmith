#nullable enable

namespace LangSmith
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// Get Personal Access Tokens<br/>
        /// Get the current users PATs for this tenant
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.APIKeyGetResponse>> GetPersonalAccessTokensAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}