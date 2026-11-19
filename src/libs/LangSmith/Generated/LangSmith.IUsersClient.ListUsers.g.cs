#nullable enable

namespace LangSmith
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List users<br/>
        /// Returns one page of the users of your application in a tracing project, most recently updated first. `page_size` sets the number of users per page. To get the next page, pass the response's `next_cursor` as `cursor` with the same other parameters; `next_cursor` is null on the last page. `user_id_prefix` returns only users whose `user_id` starts with it, matched literally and case-sensitively.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="userIdPrefix"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.EndusersListResponse> ListUsersAsync(
            global::System.Guid sessionId,
            int? pageSize = default,
            string? cursor = default,
            string? userIdPrefix = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List users<br/>
        /// Returns one page of the users of your application in a tracing project, most recently updated first. `page_size` sets the number of users per page. To get the next page, pass the response's `next_cursor` as `cursor` with the same other parameters; `next_cursor` is null on the last page. `user_id_prefix` returns only users whose `user_id` starts with it, matched literally and case-sensitively.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="userIdPrefix"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.EndusersListResponse>> ListUsersAsResponseAsync(
            global::System.Guid sessionId,
            int? pageSize = default,
            string? cursor = default,
            string? userIdPrefix = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}