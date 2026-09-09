#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Revoke Org Personal Access Token<br/>
        /// Revoke a personal access token, so it stops working but its record remains.<br/>
        /// The token is marked revoked rather than deleted, and its expiry is moved to the<br/>
        /// revocation time so it stops authenticating. Callers may always revoke their own<br/>
        /// tokens; organization admins may revoke any member's.
        /// </summary>
        /// <param name="patId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.APIKeyGetResponse> RevokeOrgPersonalAccessTokenAsync(
            global::System.Guid patId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke Org Personal Access Token<br/>
        /// Revoke a personal access token, so it stops working but its record remains.<br/>
        /// The token is marked revoked rather than deleted, and its expiry is moved to the<br/>
        /// revocation time so it stops authenticating. Callers may always revoke their own<br/>
        /// tokens; organization admins may revoke any member's.
        /// </summary>
        /// <param name="patId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.APIKeyGetResponse>> RevokeOrgPersonalAccessTokenAsResponseAsync(
            global::System.Guid patId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}