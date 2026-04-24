#nullable enable

namespace LangSmith
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// List evaluators<br/>
        /// List evaluators for the current workspace, with optional filtering by type, name, tag, feedback key, or resource ID.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="nameContains"></param>
        /// <param name="tagValueId"></param>
        /// <param name="feedbackKey"></param>
        /// <param name="resourceId"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortByDesc"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.EvaluatorsListEvaluatorsResponse> ListEvaluatorsAsync(
            string? type = default,
            string? nameContains = default,
            global::System.Collections.Generic.IList<string>? tagValueId = default,
            string? feedbackKey = default,
            global::System.Collections.Generic.IList<string>? resourceId = default,
            string? sortBy = default,
            bool? sortByDesc = default,
            int? limit = default,
            int? offset = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}