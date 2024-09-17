#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Update Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UpdateAnnotationQueueApiV1AnnotationQueuesQueueIdPatchResponse> UpdateAnnotationQueueAsync(
            global::System.Guid queueId,
            global::LangSmith.AnnotationQueueUpdateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDataset"></param>
        /// <param name="numReviewersPerItem">
        /// Default Value: 1
        /// </param>
        /// <param name="enableReservations">
        /// Default Value: true
        /// </param>
        /// <param name="reservationMinutes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UpdateAnnotationQueueApiV1AnnotationQueuesQueueIdPatchResponse> UpdateAnnotationQueueAsync(
            global::System.Guid queueId,
            global::LangSmith.AnyOf<string, object>? name = default,
            global::LangSmith.AnyOf<string, object>? description = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? defaultDataset = default,
            global::LangSmith.AnyOf<int?, object>? numReviewersPerItem = default,
            bool? enableReservations = true,
            global::LangSmith.AnyOf<int?, object>? reservationMinutes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}