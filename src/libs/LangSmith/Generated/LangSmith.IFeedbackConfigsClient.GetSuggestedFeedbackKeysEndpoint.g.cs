#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackConfigsClient
    {
        /// <summary>
        /// Get Suggested Feedback Keys Endpoint
        /// </summary>
        /// <param name="limit">
        /// Default Value: 5
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> GetSuggestedFeedbackKeysEndpointAsync(
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}