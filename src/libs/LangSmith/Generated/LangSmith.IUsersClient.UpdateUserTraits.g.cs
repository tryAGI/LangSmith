#nullable enable

namespace LangSmith
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Update user traits<br/>
        /// Merges `traits` into the stored traits of an existing user of your application in a tracing project: keys you send overwrite stored values, keys you do not send are kept, and a key sent as `null` is removed. `traits` is a JSON object of at most 50 keys per request; `name` and `email` must be strings or null. The merged traits may be at most 16384 bytes as stored. Every successful update sets `updated_at`. Updating a user that does not exist returns 404 and never creates it. Because the response includes the stored traits, the caller needs permission to read runs as well as create them. URL-encode `user_id` in the path, but send a `/` in it as is, not as `%2F`. A user ID with a `.` or `..` part, `//`, or a leading `/` cannot be used in the path: proxies rewrite it to a different path.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.EndusersUser> UpdateUserTraitsAsync(
            global::System.Guid sessionId,
            string userId,

            global::LangSmith.EndusersUpdateRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user traits<br/>
        /// Merges `traits` into the stored traits of an existing user of your application in a tracing project: keys you send overwrite stored values, keys you do not send are kept, and a key sent as `null` is removed. `traits` is a JSON object of at most 50 keys per request; `name` and `email` must be strings or null. The merged traits may be at most 16384 bytes as stored. Every successful update sets `updated_at`. Updating a user that does not exist returns 404 and never creates it. Because the response includes the stored traits, the caller needs permission to read runs as well as create them. URL-encode `user_id` in the path, but send a `/` in it as is, not as `%2F`. A user ID with a `.` or `..` part, `//`, or a leading `/` cannot be used in the path: proxies rewrite it to a different path.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.EndusersUser>> UpdateUserTraitsAsResponseAsync(
            global::System.Guid sessionId,
            string userId,

            global::LangSmith.EndusersUpdateRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user traits<br/>
        /// Merges `traits` into the stored traits of an existing user of your application in a tracing project: keys you send overwrite stored values, keys you do not send are kept, and a key sent as `null` is removed. `traits` is a JSON object of at most 50 keys per request; `name` and `email` must be strings or null. The merged traits may be at most 16384 bytes as stored. Every successful update sets `updated_at`. Updating a user that does not exist returns 404 and never creates it. Because the response includes the stored traits, the caller needs permission to read runs as well as create them. URL-encode `user_id` in the path, but send a `/` in it as is, not as `%2F`. A user ID with a `.` or `..` part, `//`, or a leading `/` cannot be used in the path: proxies rewrite it to a different path.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="userId"></param>
        /// <param name="traits">
        /// Traits to merge into the stored traits. A key with a null value is removed.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.EndusersUser> UpdateUserTraitsAsync(
            global::System.Guid sessionId,
            string userId,
            object traits,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}