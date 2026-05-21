#nullable enable

namespace LangSmith
{
    public partial interface IFleetAuthClient
    {
        /// <summary>
        /// Get an authorization session<br/>
        /// Returns the current status of an in-flight authorization session. The optional `wait_seconds` query param (1-25, default 1) keeps the request open up to that many seconds, returning early if the session completes. Poll until status is COMPLETED.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="waitSeconds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AuthGetSessionResponse> GetAnAuthorizationSessionAsync(
            string sessionId,
            int? waitSeconds = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an authorization session<br/>
        /// Returns the current status of an in-flight authorization session. The optional `wait_seconds` query param (1-25, default 1) keeps the request open up to that many seconds, returning early if the session completes. Poll until status is COMPLETED.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="waitSeconds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AuthGetSessionResponse>> GetAnAuthorizationSessionAsResponseAsync(
            string sessionId,
            int? waitSeconds = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}