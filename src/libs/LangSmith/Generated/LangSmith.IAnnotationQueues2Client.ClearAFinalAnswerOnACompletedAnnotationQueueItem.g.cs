#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueues2Client
    {
        /// <summary>
        /// Clear a final answer on a completed annotation queue item<br/>
        /// Remove the final for one rubric key. The key's answer goes back to the reviewers' majority, or null when they disagreed. Clearing a key that has no final succeeds.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task ClearAFinalAnswerOnACompletedAnnotationQueueItemAsync(
            string queueId,
            string itemId,
            string key,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clear a final answer on a completed annotation queue item<br/>
        /// Remove the final for one rubric key. The key's answer goes back to the reviewers' majority, or null when they disagreed. Clearing a key that has no final succeeds.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="itemId"></param>
        /// <param name="key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> ClearAFinalAnswerOnACompletedAnnotationQueueItemAsResponseAsync(
            string queueId,
            string itemId,
            string key,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}