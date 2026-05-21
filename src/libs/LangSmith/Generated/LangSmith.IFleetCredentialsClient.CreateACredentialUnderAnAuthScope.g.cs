#nullable enable

namespace LangSmith
{
    public partial interface IFleetCredentialsClient
    {
        /// <summary>
        /// Create a credential under an auth scope<br/>
        /// Registers a credential (e.g. a static bearer token) under an auth scope and binds it to one or more targets such as MCP servers. The response never includes the secret token.
        /// </summary>
        /// <param name="scopeSlug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CredentialsResponse> CreateACredentialUnderAnAuthScopeAsync(
            string scopeSlug,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a credential under an auth scope<br/>
        /// Registers a credential (e.g. a static bearer token) under an auth scope and binds it to one or more targets such as MCP servers. The response never includes the secret token.
        /// </summary>
        /// <param name="scopeSlug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.CredentialsResponse>> CreateACredentialUnderAnAuthScopeAsResponseAsync(
            string scopeSlug,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}