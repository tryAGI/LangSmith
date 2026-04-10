#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Generate Query For Runs<br/>
        /// Get runs filter expression query for a given natural language query.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ResponseBodyForRunsGenerateQuery> GenerateQueryForRunsAsync(

            global::LangSmith.RequestBodyForRunsGenerateQuery request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Query For Runs<br/>
        /// Get runs filter expression query for a given natural language query.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="feedbackKeys"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ResponseBodyForRunsGenerateQuery> GenerateQueryForRunsAsync(
            string query,
            global::System.Collections.Generic.IList<global::LangSmith.RunsGenerateQueryFeedbackKeys>? feedbackKeys = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}