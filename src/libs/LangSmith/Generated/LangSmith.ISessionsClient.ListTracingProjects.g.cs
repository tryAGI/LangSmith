#nullable enable

namespace LangSmith
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// List tracing projects<br/>
        /// Returns a page of the workspace's tracing projects and experiments. Pass the response's next_cursor as cursor to fetch the next page; next_cursor is null on the last page. A cursor is valid only with the same query parameters as the request that returned it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="type"></param>
        /// <param name="tagValueId"></param>
        /// <param name="metadata"></param>
        /// <param name="filter"></param>
        /// <param name="sortBy">
        /// Default Value: START_TIME
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="sortByFeedbackKey"></param>
        /// <param name="sortByFeedbackSource"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="includeStats">
        /// Default Value: false
        /// </param>
        /// <param name="includeFacets">
        /// Default Value: false
        /// </param>
        /// <param name="useApproxStats">
        /// Default Value: false
        /// </param>
        /// <param name="statsStartTime"></param>
        /// <param name="statsSelect"></param>
        /// <param name="statsFilter"></param>
        /// <param name="cursor"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionsListSessionsV2Response> ListTracingProjectsAsync(
            global::System.Collections.Generic.IList<string>? id = default,
            string? name = default,
            string? nameContains = default,
            global::System.Collections.Generic.IList<string>? referenceDatasetId = default,
            global::System.Collections.Generic.IList<global::LangSmith.ListSessionsV2TypeItem>? type = default,
            global::System.Collections.Generic.IList<string>? tagValueId = default,
            string? metadata = default,
            string? filter = default,
            global::LangSmith.ListSessionsV2SortBy? sortBy = default,
            global::LangSmith.ListSessionsV2SortOrder? sortOrder = default,
            string? sortByFeedbackKey = default,
            global::LangSmith.ListSessionsV2SortByFeedbackSource? sortByFeedbackSource = default,
            global::System.DateTime? datasetVersion = default,
            bool? includeStats = default,
            bool? includeFacets = default,
            bool? useApproxStats = default,
            global::System.DateTime? statsStartTime = default,
            global::System.Collections.Generic.IList<string>? statsSelect = default,
            string? statsFilter = default,
            string? cursor = default,
            int? pageSize = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List tracing projects<br/>
        /// Returns a page of the workspace's tracing projects and experiments. Pass the response's next_cursor as cursor to fetch the next page; next_cursor is null on the last page. A cursor is valid only with the same query parameters as the request that returned it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="type"></param>
        /// <param name="tagValueId"></param>
        /// <param name="metadata"></param>
        /// <param name="filter"></param>
        /// <param name="sortBy">
        /// Default Value: START_TIME
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="sortByFeedbackKey"></param>
        /// <param name="sortByFeedbackSource"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="includeStats">
        /// Default Value: false
        /// </param>
        /// <param name="includeFacets">
        /// Default Value: false
        /// </param>
        /// <param name="useApproxStats">
        /// Default Value: false
        /// </param>
        /// <param name="statsStartTime"></param>
        /// <param name="statsSelect"></param>
        /// <param name="statsFilter"></param>
        /// <param name="cursor"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TracerSessionsListSessionsV2Response>> ListTracingProjectsAsResponseAsync(
            global::System.Collections.Generic.IList<string>? id = default,
            string? name = default,
            string? nameContains = default,
            global::System.Collections.Generic.IList<string>? referenceDatasetId = default,
            global::System.Collections.Generic.IList<global::LangSmith.ListSessionsV2TypeItem>? type = default,
            global::System.Collections.Generic.IList<string>? tagValueId = default,
            string? metadata = default,
            string? filter = default,
            global::LangSmith.ListSessionsV2SortBy? sortBy = default,
            global::LangSmith.ListSessionsV2SortOrder? sortOrder = default,
            string? sortByFeedbackKey = default,
            global::LangSmith.ListSessionsV2SortByFeedbackSource? sortByFeedbackSource = default,
            global::System.DateTime? datasetVersion = default,
            bool? includeStats = default,
            bool? includeFacets = default,
            bool? useApproxStats = default,
            global::System.DateTime? statsStartTime = default,
            global::System.Collections.Generic.IList<string>? statsSelect = default,
            string? statsFilter = default,
            string? cursor = default,
            int? pageSize = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}