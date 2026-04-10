#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackConfigsClient
    {
        /// <summary>
        /// Delete Feedback Config Endpoint<br/>
        /// Soft delete a feedback config by marking it as deleted.<br/>
        /// The config can be recreated later with the same key (simple reuse pattern).<br/>
        /// Existing feedback records with this key will remain unchanged.
        /// </summary>
        /// <param name="feedbackKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteFeedbackConfigEndpointAsync(
            string feedbackKey,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}