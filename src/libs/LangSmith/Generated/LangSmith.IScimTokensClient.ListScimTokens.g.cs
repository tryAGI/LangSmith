#nullable enable

namespace LangSmith
{
    public partial interface IScimTokensClient
    {
        /// <summary>
        /// List SCIM tokens<br/>
        /// List all SCIM bearer tokens for the current organization. The full token values are not returned.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.ScimScimTokenResponse>> ListScimTokensAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}