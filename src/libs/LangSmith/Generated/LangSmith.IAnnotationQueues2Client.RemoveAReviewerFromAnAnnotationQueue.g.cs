#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueues2Client
    {
        /// <summary>
        /// Remove a reviewer from an annotation queue<br/>
        /// Unassigns an identity as a reviewer for the queue. Idempotent.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveAReviewerFromAnAnnotationQueueAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}