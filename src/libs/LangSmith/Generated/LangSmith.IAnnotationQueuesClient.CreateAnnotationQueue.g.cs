#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Create Annotation Queue
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationQueueSchema> CreateAnnotationQueueAsync(
            global::LangSmith.AnnotationQueueCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Annotation Queue
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="defaultDataset"></param>
        /// <param name="numReviewersPerItem">
        /// Default Value: 1
        /// </param>
        /// <param name="enableReservations">
        /// Default Value: true
        /// </param>
        /// <param name="reservationMinutes">
        /// Default Value: 1
        /// </param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationQueueSchema> CreateAnnotationQueueAsync(
            string name,
            global::LangSmith.AnyOf<string, object>? description = default,
            global::System.DateTime createdAt = default,
            global::System.DateTime updatedAt = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? defaultDataset = default,
            global::LangSmith.AnyOf<int?, object>? numReviewersPerItem = default,
            global::LangSmith.AnyOf<bool?, object>? enableReservations = default,
            global::LangSmith.AnyOf<int?, object>? reservationMinutes = default,
            global::System.Guid id = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}