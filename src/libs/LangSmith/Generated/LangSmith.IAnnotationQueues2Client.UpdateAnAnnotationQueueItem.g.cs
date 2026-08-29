#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueues2Client
    {
        /// <summary>
        /// Update an annotation queue item<br/>
        /// Partially update mutable timestamps (added_at, last_reviewed_time) for a RUN or THREAD annotation queue item. Omit a field, or pass JSON null, to leave it unchanged.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesAnnotationQueueItem> UpdateAnAnnotationQueueItemAsync(
            string queueId,
            string itemId,

            global::LangSmith.AnnotationqueuesPatchAnnotationQueueItemRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an annotation queue item<br/>
        /// Partially update mutable timestamps (added_at, last_reviewed_time) for a RUN or THREAD annotation queue item. Omit a field, or pass JSON null, to leave it unchanged.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AnnotationqueuesAnnotationQueueItem>> UpdateAnAnnotationQueueItemAsResponseAsync(
            string queueId,
            string itemId,

            global::LangSmith.AnnotationqueuesPatchAnnotationQueueItemRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an annotation queue item<br/>
        /// Partially update mutable timestamps (added_at, last_reviewed_time) for a RUN or THREAD annotation queue item. Omit a field, or pass JSON null, to leave it unchanged.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="addedAt"></param>
        /// <param name="lastReviewedTime"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesAnnotationQueueItem> UpdateAnAnnotationQueueItemAsync(
            string queueId,
            string itemId,
            global::System.DateTime? addedAt = default,
            global::System.DateTime? lastReviewedTime = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}