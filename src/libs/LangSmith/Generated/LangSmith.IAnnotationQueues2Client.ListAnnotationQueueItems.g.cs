#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueues2Client
    {
        /// <summary>
        /// List annotation queue items<br/>
        /// List RUN and THREAD items in a single annotation queue for one review status section, with opaque cursor pagination. Optional item_type=RUN|THREAD filters the page. direction=backward returns items before the supplied cursor. The response contains item metadata only, not expanded run or thread payloads. status=archived returns items whose queue review requirements have been satisfied, not merely items the caller personally marked completed.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="status"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="itemType"></param>
        /// <param name="direction">
        /// Default Value: forward
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesListAnnotationQueueItemsResponse> ListAnnotationQueueItemsAsync(
            string queueId,
            global::LangSmith.GetPlatformAnnotationQueuesItemsStatus status,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.GetPlatformAnnotationQueuesItemsItemType? itemType = default,
            global::LangSmith.GetPlatformAnnotationQueuesItemsDirection? direction = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List annotation queue items<br/>
        /// List RUN and THREAD items in a single annotation queue for one review status section, with opaque cursor pagination. Optional item_type=RUN|THREAD filters the page. direction=backward returns items before the supplied cursor. The response contains item metadata only, not expanded run or thread payloads. status=archived returns items whose queue review requirements have been satisfied, not merely items the caller personally marked completed.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="status"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="itemType"></param>
        /// <param name="direction">
        /// Default Value: forward
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AnnotationqueuesListAnnotationQueueItemsResponse>> ListAnnotationQueueItemsAsResponseAsync(
            string queueId,
            global::LangSmith.GetPlatformAnnotationQueuesItemsStatus status,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.GetPlatformAnnotationQueuesItemsItemType? itemType = default,
            global::LangSmith.GetPlatformAnnotationQueuesItemsDirection? direction = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}