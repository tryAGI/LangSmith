#nullable enable

namespace LangSmith
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Update a project<br/>
        /// Updates supplied fields and returns the refreshed resource without optional run statistics. Omitted fields remain unchanged. Null clears description, default_dataset_id, end_time, or extra. Extra merges top-level keys; null values remove keys.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Session> UpdateAProjectAsync(
            global::System.Guid sessionId,

            global::LangSmith.TracerSessionsUpdateSessionRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a project<br/>
        /// Updates supplied fields and returns the refreshed resource without optional run statistics. Omitted fields remain unchanged. Null clears description, default_dataset_id, end_time, or extra. Extra merges top-level keys; null values remove keys.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.Session>> UpdateAProjectAsResponseAsync(
            global::System.Guid sessionId,

            global::LangSmith.TracerSessionsUpdateSessionRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a project<br/>
        /// Updates supplied fields and returns the refreshed resource without optional run statistics. Omitted fields remain unchanged. Null clears description, default_dataset_id, end_time, or extra. Extra merges top-level keys; null values remove keys.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="description"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="longlivedTtlDays"></param>
        /// <param name="name"></param>
        /// <param name="traceTier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Session> UpdateAProjectAsync(
            global::System.Guid sessionId,
            global::System.Guid? defaultDatasetId = default,
            string? description = default,
            global::System.DateTime? endTime = default,
            object? extra = default,
            int? longlivedTtlDays = default,
            string? name = default,
            global::LangSmith.TracerSessionsUpdateSessionRequestTraceTier? traceTier = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}