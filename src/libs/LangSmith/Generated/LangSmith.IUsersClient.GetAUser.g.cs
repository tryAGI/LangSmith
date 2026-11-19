#nullable enable

namespace LangSmith
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get a user<br/>
        /// Returns one user of your application and its traits in a tracing project. URL-encode `user_id` in the path, so that a `/` in it is sent as `%2F`.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.EndusersUser> GetAUserAsync(
            global::System.Guid sessionId,
            string userId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a user<br/>
        /// Returns one user of your application and its traits in a tracing project. URL-encode `user_id` in the path, so that a `/` in it is sent as `%2F`.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.EndusersUser>> GetAUserAsResponseAsync(
            global::System.Guid sessionId,
            string userId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}