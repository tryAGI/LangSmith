#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueues2Client
    {
        /// <summary>
        /// Get reviewers' answers on a completed annotation queue item<br/>
        /// For each rubric key: whether the reviewers agreed, the final if one is set, and each reviewer's answer. Reviewers are listed in the order they completed the item. Their name and email are empty when the caller cannot see other workspace members. Returns 404 unless the item is completed.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesAnnotationQueueItemReviews> GetReviewersAnswersOnACompletedAnnotationQueueItemAsync(
            string queueId,
            string itemId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get reviewers' answers on a completed annotation queue item<br/>
        /// For each rubric key: whether the reviewers agreed, the final if one is set, and each reviewer's answer. Reviewers are listed in the order they completed the item. Their name and email are empty when the caller cannot see other workspace members. Returns 404 unless the item is completed.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AnnotationqueuesAnnotationQueueItemReviews>> GetReviewersAnswersOnACompletedAnnotationQueueItemAsResponseAsync(
            string queueId,
            string itemId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}