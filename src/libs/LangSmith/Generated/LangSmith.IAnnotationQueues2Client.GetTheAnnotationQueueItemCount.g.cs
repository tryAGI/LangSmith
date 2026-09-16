#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueues2Client
    {
        /// <summary>
        /// Get the annotation queue item count<br/>
        /// Returns the number of annotation queue items in one status bucket. The two time windows are independent: start_time/end_time bound when an item was archived, min_start_time/max_start_time bound when its trace ran. Items with no trace start time are excluded when either of the latter is set.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="status"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="minStartTime"></param>
        /// <param name="maxStartTime"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesAnnotationQueueItemCountResponse> GetTheAnnotationQueueItemCountAsync(
            string queueId,
            string status,
            string? startTime = default,
            string? endTime = default,
            global::System.DateTime? minStartTime = default,
            global::System.DateTime? maxStartTime = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the annotation queue item count<br/>
        /// Returns the number of annotation queue items in one status bucket. The two time windows are independent: start_time/end_time bound when an item was archived, min_start_time/max_start_time bound when its trace ran. Items with no trace start time are excluded when either of the latter is set.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="status"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="minStartTime"></param>
        /// <param name="maxStartTime"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AnnotationqueuesAnnotationQueueItemCountResponse>> GetTheAnnotationQueueItemCountAsResponseAsync(
            string queueId,
            string status,
            string? startTime = default,
            string? endTime = default,
            global::System.DateTime? minStartTime = default,
            global::System.DateTime? maxStartTime = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}