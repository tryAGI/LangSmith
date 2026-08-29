#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueues2Client
    {
        /// <summary>
        /// Create annotation queue item status<br/>
        /// Log the caller's reviewer status for a RUN or THREAD annotation queue item. A null status re-shows the item for this reviewer.
        /// </summary>
        /// <param name="queueItemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusResponse> CreateAnnotationQueueItemStatusAsync(
            string queueItemId,

            global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create annotation queue item status<br/>
        /// Log the caller's reviewer status for a RUN or THREAD annotation queue item. A null status re-shows the item for this reviewer.
        /// </summary>
        /// <param name="queueItemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusResponse>> CreateAnnotationQueueItemStatusAsResponseAsync(
            string queueItemId,

            global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create annotation queue item status<br/>
        /// Log the caller's reviewer status for a RUN or THREAD annotation queue item. A null status re-shows the item for this reviewer.
        /// </summary>
        /// <param name="queueItemId"></param>
        /// <param name="overrideAddedAt"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusResponse> CreateAnnotationQueueItemStatusAsync(
            string queueItemId,
            string? overrideAddedAt = default,
            global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus? status = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}