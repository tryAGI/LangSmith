#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackConfigsClient
    {
        /// <summary>
        /// Delete Feedback Config Endpoint<br/>
        /// Soft delete one feedback config by id, or every config of a feedback key.<br/>
        /// The config can be recreated later with the same key (simple reuse pattern).<br/>
        /// Existing feedback records with this key will remain unchanged. Deleting an<br/>
        /// enforced config turns off its enforcement instead of removing it, and needs<br/>
        /// the feedback-configs:manage-enforced permission.<br/>
        /// Deleting an unenforced config that an annotation queue uses is refused.
        /// </summary>
        /// <param name="feedbackKey"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteFeedbackConfigEndpointAsync(
            string? feedbackKey = default,
            global::System.Guid? id = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Feedback Config Endpoint<br/>
        /// Soft delete one feedback config by id, or every config of a feedback key.<br/>
        /// The config can be recreated later with the same key (simple reuse pattern).<br/>
        /// Existing feedback records with this key will remain unchanged. Deleting an<br/>
        /// enforced config turns off its enforcement instead of removing it, and needs<br/>
        /// the feedback-configs:manage-enforced permission.<br/>
        /// Deleting an unenforced config that an annotation queue uses is refused.
        /// </summary>
        /// <param name="feedbackKey"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> DeleteFeedbackConfigEndpointAsResponseAsync(
            string? feedbackKey = default,
            global::System.Guid? id = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}