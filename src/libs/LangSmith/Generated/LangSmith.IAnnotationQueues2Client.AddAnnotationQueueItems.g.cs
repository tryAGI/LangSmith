#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueues2Client
    {
        /// <summary>
        /// Add annotation queue items<br/>
        /// Add RUN or THREAD items to a single annotation queue. RUN items require run_id unless they are created from a suggested example. THREAD items require thread_id and project_id.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="extendTraceRetention"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsResponse> AddAnnotationQueueItemsAsync(
            string queueId,

            global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsRequest request,
            bool? extendTraceRetention = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add annotation queue items<br/>
        /// Add RUN or THREAD items to a single annotation queue. RUN items require run_id unless they are created from a suggested example. THREAD items require thread_id and project_id.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="extendTraceRetention"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsResponse>> AddAnnotationQueueItemsAsResponseAsync(
            string queueId,

            global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsRequest request,
            bool? extendTraceRetention = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add annotation queue items<br/>
        /// Add RUN or THREAD items to a single annotation queue. RUN items require run_id unless they are created from a suggested example. THREAD items require thread_id and project_id.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="extendTraceRetention"></param>
        /// <param name="items"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsResponse> AddAnnotationQueueItemsAsync(
            string queueId,
            bool? extendTraceRetention = default,
            global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueItemInput>? items = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}