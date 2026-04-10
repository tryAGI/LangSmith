#nullable enable

namespace LangSmith
{
    public partial interface IScimTokensClient
    {
        /// <summary>
        /// Create a SCIM token<br/>
        /// Create a new SCIM bearer token for the current organization. The full token value is only returned once upon creation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ScimScimTokenSensitiveResponse> CreateAScimTokenAsync(

            global::LangSmith.ScimCreateScimTokenPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a SCIM token<br/>
        /// Create a new SCIM bearer token for the current organization. The full token value is only returned once upon creation.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ScimScimTokenSensitiveResponse> CreateAScimTokenAsync(
            string? description = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}