#nullable enable

namespace LangSmith
{
    public partial interface IScimTokensClient
    {
        /// <summary>
        /// Update a SCIM token<br/>
        /// Update the description of an existing SCIM token for the current organization.
        /// </summary>
        /// <param name="scimTokenId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ScimScimTokenResponse> UpdateAScimTokenAsync(
            string scimTokenId,

            global::LangSmith.ScimUpdateScimTokenPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a SCIM token<br/>
        /// Update the description of an existing SCIM token for the current organization.
        /// </summary>
        /// <param name="scimTokenId"></param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ScimScimTokenResponse> UpdateAScimTokenAsync(
            string scimTokenId,
            string? description = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}