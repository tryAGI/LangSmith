#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Read Tracer Sessions<br/>
        /// List all projects.
        /// </summary>
        /// <param name="referenceFree"></param>
        /// <param name="referenceDataset"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="sortBy">
        /// Default Value: start_time
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="sortByFeedbackKey"></param>
        /// <param name="sortByFeedbackSource"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="facets">
        /// Default Value: false
        /// </param>
        /// <param name="filter"></param>
        /// <param name="includeStats">
        /// Default Value: false
        /// </param>
        /// <param name="useApproxStats">
        /// Default Value: false
        /// </param>
        /// <param name="statsStartTime"></param>
        /// <param name="statsSelect"></param>
        /// <param name="statsFilter"></param>
        /// <param name="accept"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.TracerSession>> ReadTracerSessionsAsync(
            bool? referenceFree = default,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceDataset = default,
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            string? name = default,
            string? nameContains = default,
            string? datasetVersion = default,
            global::LangSmith.SessionSortableColumns? sortBy = default,
            bool? sortByDesc = default,
            string? metadata = default,
            string? sortByFeedbackKey = default,
            global::LangSmith.FeedbackSourceParam? sortByFeedbackSource = default,
            int? offset = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            bool? facets = default,
            string? filter = default,
            bool? includeStats = default,
            bool? useApproxStats = default,
            global::System.DateTime? statsStartTime = default,
            global::System.Collections.Generic.IList<string>? statsSelect = default,
            string? statsFilter = default,
            string? accept = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Read Tracer Sessions<br/>
        /// List all projects.
        /// </summary>
        /// <param name="referenceFree"></param>
        /// <param name="referenceDataset"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="sortBy">
        /// Default Value: start_time
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="sortByFeedbackKey"></param>
        /// <param name="sortByFeedbackSource"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="facets">
        /// Default Value: false
        /// </param>
        /// <param name="filter"></param>
        /// <param name="includeStats">
        /// Default Value: false
        /// </param>
        /// <param name="useApproxStats">
        /// Default Value: false
        /// </param>
        /// <param name="statsStartTime"></param>
        /// <param name="statsSelect"></param>
        /// <param name="statsFilter"></param>
        /// <param name="accept"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.TracerSession>>> ReadTracerSessionsAsResponseAsync(
            bool? referenceFree = default,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceDataset = default,
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            string? name = default,
            string? nameContains = default,
            string? datasetVersion = default,
            global::LangSmith.SessionSortableColumns? sortBy = default,
            bool? sortByDesc = default,
            string? metadata = default,
            string? sortByFeedbackKey = default,
            global::LangSmith.FeedbackSourceParam? sortByFeedbackSource = default,
            int? offset = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            bool? facets = default,
            string? filter = default,
            bool? includeStats = default,
            bool? useApproxStats = default,
            global::System.DateTime? statsStartTime = default,
            global::System.Collections.Generic.IList<string>? statsSelect = default,
            string? statsFilter = default,
            string? accept = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}