#nullable enable

namespace LangSmith
{
    public partial interface IRulesClient
    {
        /// <summary>
        /// List run rules<br/>
        /// List workspace rules in descending updated_at and id order. Filters combine with AND. Pass next_cursor unchanged with the same filters to continue; concurrent changes can affect later pages.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="projectId"></param>
        /// <param name="datasetId"></param>
        /// <param name="type"></param>
        /// <param name="nameContains"></param>
        /// <param name="id"></param>
        /// <param name="evaluatorId"></param>
        /// <param name="tagValueId"></param>
        /// <param name="includeBackfillProgress">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RulesListResponse> ListRunRulesAsync(
            int? pageSize = default,
            string? cursor = default,
            global::System.Guid? projectId = default,
            global::System.Guid? datasetId = default,
            global::LangSmith.ListRunRulesType? type = default,
            string? nameContains = default,
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::System.Guid? evaluatorId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            bool? includeBackfillProgress = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List run rules<br/>
        /// List workspace rules in descending updated_at and id order. Filters combine with AND. Pass next_cursor unchanged with the same filters to continue; concurrent changes can affect later pages.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="projectId"></param>
        /// <param name="datasetId"></param>
        /// <param name="type"></param>
        /// <param name="nameContains"></param>
        /// <param name="id"></param>
        /// <param name="evaluatorId"></param>
        /// <param name="tagValueId"></param>
        /// <param name="includeBackfillProgress">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.RulesListResponse>> ListRunRulesAsResponseAsync(
            int? pageSize = default,
            string? cursor = default,
            global::System.Guid? projectId = default,
            global::System.Guid? datasetId = default,
            global::LangSmith.ListRunRulesType? type = default,
            string? nameContains = default,
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::System.Guid? evaluatorId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            bool? includeBackfillProgress = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}