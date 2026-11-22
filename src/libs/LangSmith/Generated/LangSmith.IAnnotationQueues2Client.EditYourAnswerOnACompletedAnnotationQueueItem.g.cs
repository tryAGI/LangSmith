#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueues2Client
    {
        /// <summary>
        /// Edit your answer on a completed annotation queue item<br/>
        /// Replace your own answer on one rubric key and update the item's agreement. Only a reviewer who completed the item can edit their answer. Multi-select keys take a list of category labels in values; free-text keys take text in value. An empty body clears your answer.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="key"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesAnnotationQueueItemKeyReviews> EditYourAnswerOnACompletedAnnotationQueueItemAsync(
            string queueId,
            string itemId,
            string key,

            global::LangSmith.AnnotationqueuesSetItemReviewRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit your answer on a completed annotation queue item<br/>
        /// Replace your own answer on one rubric key and update the item's agreement. Only a reviewer who completed the item can edit their answer. Multi-select keys take a list of category labels in values; free-text keys take text in value. An empty body clears your answer.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="key"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AnnotationqueuesAnnotationQueueItemKeyReviews>> EditYourAnswerOnACompletedAnnotationQueueItemAsResponseAsync(
            string queueId,
            string itemId,
            string key,

            global::LangSmith.AnnotationqueuesSetItemReviewRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit your answer on a completed annotation queue item<br/>
        /// Replace your own answer on one rubric key and update the item's agreement. Only a reviewer who completed the item can edit their answer. Multi-select keys take a list of category labels in values; free-text keys take text in value. An empty body clears your answer.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="key"></param>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="values"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesAnnotationQueueItemKeyReviews> EditYourAnswerOnACompletedAnnotationQueueItemAsync(
            string queueId,
            string itemId,
            string key,
            double? score = default,
            string? value = default,
            global::System.Collections.Generic.IList<string>? values = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}