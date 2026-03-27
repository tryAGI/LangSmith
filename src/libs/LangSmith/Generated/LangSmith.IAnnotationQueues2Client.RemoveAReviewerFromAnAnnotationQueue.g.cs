#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueues2Client
    {
        /// <summary>
        /// Remove a reviewer from an annotation queue<br/>
        /// Unassigns an identity as a reviewer for the queue. Idempotent.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveAReviewerFromAnAnnotationQueueAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}