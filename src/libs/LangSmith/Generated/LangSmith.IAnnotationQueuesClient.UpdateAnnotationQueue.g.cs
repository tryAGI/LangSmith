#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Update Annotation Queue
        /// </summary>
        /// <param name="queueId">
        /// ID of the annotation queue.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAnnotationQueueAsync(
            global::System.Guid queueId,

            global::LangSmith.AnnotationQueueUpdateSchema request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Annotation Queue
        /// </summary>
        /// <param name="queueId">
        /// ID of the annotation queue.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<string>> UpdateAnnotationQueueAsResponseAsync(
            global::System.Guid queueId,

            global::LangSmith.AnnotationQueueUpdateSchema request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Annotation Queue
        /// </summary>
        /// <param name="queueId">
        /// ID of the annotation queue.
        /// </param>
        /// <param name="name">
        /// New name for the queue.
        /// </param>
        /// <param name="description">
        /// New description.
        /// </param>
        /// <param name="defaultDataset">
        /// Dataset that reviewed runs are added to by default.
        /// </param>
        /// <param name="numReviewersPerItem">
        /// How many reviewers must review each run.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="enableReservations">
        /// Whether a reviewer reserves a run while reviewing it, so others skip it.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="reservationMinutes">
        /// How long a reservation lasts, in minutes.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="rubricItems">
        /// Feedback keys reviewers fill in for each run.
        /// </param>
        /// <param name="rubricInstructions">
        /// Instructions shown to reviewers.
        /// </param>
        /// <param name="metadata">
        /// Metadata to store on the queue. Replaces the existing metadata.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="reviewerAccessMode">
        /// Who completes a run: any (one reviewer is enough) or assigned (every assigned reviewer must submit).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAnnotationQueueAsync(
            global::System.Guid queueId,
            string? name = default,
            string? description = default,
            global::System.Guid? defaultDataset = default,
            global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? numReviewersPerItem = default,
            global::LangSmith.AnyOf<bool?, global::LangSmith.Missing>? enableReservations = default,
            global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? reservationMinutes = default,
            global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRubricItemSchema>? rubricItems = default,
            string? rubricInstructions = default,
            global::LangSmith.AnyOf<object, global::LangSmith.Missing>? metadata = default,
            global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode? reviewerAccessMode = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}