#nullable enable

namespace LangSmith
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Create a user<br/>
        /// Stores a user of your application and its traits, such as `name` and `email`, for one tracing project. `user_id` is the ID your runs send in `metadata.user_id`: 1 to 512 characters. `traits` is an optional JSON object of at most 50 keys per request and 16384 bytes as stored, with no null values; `name` and `email` must be strings. Creating a user that already exists returns 409 and never changes the stored traits.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.EndusersUser> CreateAUserAsync(
            global::System.Guid sessionId,

            global::LangSmith.EndusersCreateRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a user<br/>
        /// Stores a user of your application and its traits, such as `name` and `email`, for one tracing project. `user_id` is the ID your runs send in `metadata.user_id`: 1 to 512 characters. `traits` is an optional JSON object of at most 50 keys per request and 16384 bytes as stored, with no null values; `name` and `email` must be strings. Creating a user that already exists returns 409 and never changes the stored traits.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.EndusersUser>> CreateAUserAsResponseAsync(
            global::System.Guid sessionId,

            global::LangSmith.EndusersCreateRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a user<br/>
        /// Stores a user of your application and its traits, such as `name` and `email`, for one tracing project. `user_id` is the ID your runs send in `metadata.user_id`: 1 to 512 characters. `traits` is an optional JSON object of at most 50 keys per request and 16384 bytes as stored, with no null values; `name` and `email` must be strings. Creating a user that already exists returns 409 and never changes the stored traits.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="traits">
        /// Traits to store, such as name and email. Defaults to an empty object.
        /// </param>
        /// <param name="userId">
        /// The user's ID, as sent in metadata.user_id on runs.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.EndusersUser> CreateAUserAsync(
            global::System.Guid sessionId,
            string userId,
            object? traits = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}