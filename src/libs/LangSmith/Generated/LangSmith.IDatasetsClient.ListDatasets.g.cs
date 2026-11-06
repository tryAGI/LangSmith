#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List datasets<br/>
        /// Returns one page of the datasets in the workspace, filtered and sorted by the query parameters.<br/>
        /// Pass the next_cursor of a response as cursor, with the same filters and sort, to get the next page. next_cursor is null on the last page.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataType"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="metadata"></param>
        /// <param name="tagValueId"></param>
        /// <param name="excludeCorrectionsDatasets">
        /// Default Value: false
        /// </param>
        /// <param name="exclude"></param>
        /// <param name="sortBy">
        /// Enum for available dataset columns to sort by.<br/>
        /// Default Value: last_session_start_time
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetsListDatasetsV2Response> ListDatasetsAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::System.Collections.Generic.IList<global::LangSmith.DataType>? dataType = default,
            string? name = default,
            string? nameContains = default,
            string? metadata = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            bool? excludeCorrectionsDatasets = default,
            global::System.Collections.Generic.IList<global::LangSmith.GetDatasetsSelect>? exclude = default,
            global::LangSmith.SortByDatasetColumn? sortBy = default,
            global::LangSmith.GetDatasetsSortOrder? sortOrder = default,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List datasets<br/>
        /// Returns one page of the datasets in the workspace, filtered and sorted by the query parameters.<br/>
        /// Pass the next_cursor of a response as cursor, with the same filters and sort, to get the next page. next_cursor is null on the last page.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataType"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="metadata"></param>
        /// <param name="tagValueId"></param>
        /// <param name="excludeCorrectionsDatasets">
        /// Default Value: false
        /// </param>
        /// <param name="exclude"></param>
        /// <param name="sortBy">
        /// Enum for available dataset columns to sort by.<br/>
        /// Default Value: last_session_start_time
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.DatasetsListDatasetsV2Response>> ListDatasetsAsResponseAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::System.Collections.Generic.IList<global::LangSmith.DataType>? dataType = default,
            string? name = default,
            string? nameContains = default,
            string? metadata = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            bool? excludeCorrectionsDatasets = default,
            global::System.Collections.Generic.IList<global::LangSmith.GetDatasetsSelect>? exclude = default,
            global::LangSmith.SortByDatasetColumn? sortBy = default,
            global::LangSmith.GetDatasetsSortOrder? sortOrder = default,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}