#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackConfigsClient
    {
        /// <summary>
        /// Update Feedback Config Endpoint
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackConfigSchema> UpdateFeedbackConfigEndpointAsync(

            global::LangSmith.UpdateFeedbackConfigSchema request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Feedback Config Endpoint
        /// </summary>
        /// <param name="feedbackKey"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="isLowerScoreBetter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackConfigSchema> UpdateFeedbackConfigEndpointAsync(
            string feedbackKey,
            global::LangSmith.FeedbackConfig? feedbackConfig = default,
            bool? isLowerScoreBetter = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}