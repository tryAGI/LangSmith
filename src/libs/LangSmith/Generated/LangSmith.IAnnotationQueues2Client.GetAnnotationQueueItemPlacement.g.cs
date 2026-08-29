#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueues2Client
    {
        /// <summary>
        /// Get annotation queue item placement<br/>
        /// Resolve a RUN or THREAD item to its current review section and zero-based position for deep linking.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesAnnotationQueueItemPlacementResponse> GetAnnotationQueueItemPlacementAsync(
            string queueId,
            string itemId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get annotation queue item placement<br/>
        /// Resolve a RUN or THREAD item to its current review section and zero-based position for deep linking.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AnnotationqueuesAnnotationQueueItemPlacementResponse>> GetAnnotationQueueItemPlacementAsResponseAsync(
            string queueId,
            string itemId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}