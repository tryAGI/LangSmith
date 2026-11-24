#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueues2Client
    {
        /// <summary>
        /// List an annotation queue's reviewers and their progress<br/>
        /// List a queue's reviewers with how many reviews each has waiting, how many they have completed, and when they last completed one. Includes everyone on the queue's roster and anyone else who has reviewed on the queue, such as people removed from the roster; is_on_roster tells them apart. name and email are left out when a reviewer cannot be looked up. Only single queues are supported, and the endpoint returns 501 unless multi-reviewer is on for the workspace.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationqueuesListReviewersResponse> ListAnAnnotationQueuesReviewersAndTheirProgressAsync(
            string queueId,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List an annotation queue's reviewers and their progress<br/>
        /// List a queue's reviewers with how many reviews each has waiting, how many they have completed, and when they last completed one. Includes everyone on the queue's roster and anyone else who has reviewed on the queue, such as people removed from the roster; is_on_roster tells them apart. name and email are left out when a reviewer cannot be looked up. Only single queues are supported, and the endpoint returns 501 unless multi-reviewer is on for the workspace.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AnnotationqueuesListReviewersResponse>> ListAnAnnotationQueuesReviewersAndTheirProgressAsResponseAsync(
            string queueId,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}