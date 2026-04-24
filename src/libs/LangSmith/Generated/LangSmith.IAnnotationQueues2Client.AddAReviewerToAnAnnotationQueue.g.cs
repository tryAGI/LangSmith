#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueues2Client
    {
        /// <summary>
        /// Add a reviewer to an annotation queue<br/>
        /// Assigns a single identity as a reviewer for the queue. Idempotent.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesAddReviewerResponse> AddAReviewerToAnAnnotationQueueAsync(
            string queueId,

            global::LangSmith.AnnotationqueuesAddReviewerRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a reviewer to an annotation queue<br/>
        /// Assigns a single identity as a reviewer for the queue. Idempotent.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="identityId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesAddReviewerResponse> AddAReviewerToAnAnnotationQueueAsync(
            string queueId,
            string identityId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}