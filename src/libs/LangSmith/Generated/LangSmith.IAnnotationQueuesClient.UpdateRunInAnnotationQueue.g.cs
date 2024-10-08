#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Update Run In Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="queueRunId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UpdateRunInAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdPatchResponse> UpdateRunInAnnotationQueueAsync(
            global::System.Guid queueId,
            global::System.Guid queueRunId,
            global::LangSmith.AnnotationQueueRunUpdateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Run In Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="queueRunId"></param>
        /// <param name="lastReviewedTime"></param>
        /// <param name="addedAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UpdateRunInAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdPatchResponse> UpdateRunInAnnotationQueueAsync(
            global::System.Guid queueId,
            global::System.Guid queueRunId,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? lastReviewedTime = default,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? addedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}