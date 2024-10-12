#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackConfigsClient
    {
        /// <summary>
        /// Create Feedback Config Endpoint
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackConfigSchema> CreateFeedbackConfigEndpointAsync(
            global::LangSmith.CreateFeedbackConfigSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Feedback Config Endpoint
        /// </summary>
        /// <param name="feedbackKey"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="isLowerScoreBetter">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackConfigSchema> CreateFeedbackConfigEndpointAsync(
            string feedbackKey,
            global::LangSmith.FeedbackConfig feedbackConfig,
            bool? isLowerScoreBetter = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}