#nullable enable

namespace LangSmith
{
    public partial interface IFleetAuthClient
    {
        /// <summary>
        /// Start an authorization session<br/>
        /// Initiates an OAuth flow for the caller. If the user is already authorized, returns a completed session that references an existing token. Otherwise, returns a pending session containing a verification URL the user must visit to complete authorization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AuthCreateSessionResponse> StartAnAuthorizationSessionAsync(

            global::LangSmith.AuthCreateSessionRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start an authorization session<br/>
        /// Initiates an OAuth flow for the caller. If the user is already authorized, returns a completed session that references an existing token. Otherwise, returns a pending session containing a verification URL the user must visit to complete authorization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AuthCreateSessionResponse>> StartAnAuthorizationSessionAsResponseAsync(

            global::LangSmith.AuthCreateSessionRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start an authorization session<br/>
        /// Initiates an OAuth flow for the caller. If the user is already authorized, returns a completed session that references an existing token. Otherwise, returns a pending session containing a verification URL the user must visit to complete authorization.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="isDefault"></param>
        /// <param name="providerId"></param>
        /// <param name="scopes"></param>
        /// <param name="strategy"></param>
        /// <param name="tokenId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AuthCreateSessionResponse> StartAnAuthorizationSessionAsync(
            string? agentId = default,
            bool? isDefault = default,
            string? providerId = default,
            global::System.Collections.Generic.IList<string>? scopes = default,
            global::LangSmith.AuthSessionStrategy? strategy = default,
            string? tokenId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}