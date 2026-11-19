#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueues2Client
    {
        /// <summary>
        /// Set a final answer on a completed annotation queue item<br/>
        /// Set the answer downstream uses for one rubric key when the item's reviewers disagreed. A key that already has a final can be changed even after reviewers come to agree. Multi-select keys take a list of category labels in values. final_set_by is empty for API key callers.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="key"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesAnnotationQueueItemKeyAgreement> SetAFinalAnswerOnACompletedAnnotationQueueItemAsync(
            string queueId,
            string itemId,
            string key,

            global::LangSmith.AnnotationqueuesSetItemFinalRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a final answer on a completed annotation queue item<br/>
        /// Set the answer downstream uses for one rubric key when the item's reviewers disagreed. A key that already has a final can be changed even after reviewers come to agree. Multi-select keys take a list of category labels in values. final_set_by is empty for API key callers.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="key"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AnnotationqueuesAnnotationQueueItemKeyAgreement>> SetAFinalAnswerOnACompletedAnnotationQueueItemAsResponseAsync(
            string queueId,
            string itemId,
            string key,

            global::LangSmith.AnnotationqueuesSetItemFinalRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a final answer on a completed annotation queue item<br/>
        /// Set the answer downstream uses for one rubric key when the item's reviewers disagreed. A key that already has a final can be changed even after reviewers come to agree. Multi-select keys take a list of category labels in values. final_set_by is empty for API key callers.
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
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesAnnotationQueueItemKeyAgreement> SetAFinalAnswerOnACompletedAnnotationQueueItemAsync(
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