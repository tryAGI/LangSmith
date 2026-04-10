#nullable enable

namespace LangSmith
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Generate Query For Shared Dataset Runs<br/>
        /// Get runs in projects run over a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ResponseBodyForRunsGenerateQuery> GenerateQueryForSharedDatasetRunsAsync(
            global::System.Guid shareToken,

            global::LangSmith.RequestBodyForRunsGenerateQuery request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Query For Shared Dataset Runs<br/>
        /// Get runs in projects run over a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="query"></param>
        /// <param name="feedbackKeys"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ResponseBodyForRunsGenerateQuery> GenerateQueryForSharedDatasetRunsAsync(
            global::System.Guid shareToken,
            string query,
            global::System.Collections.Generic.IList<global::LangSmith.RunsGenerateQueryFeedbackKeys>? feedbackKeys = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}