#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Read Examples With Runs Grouped<br/>
        /// Fetch examples for a dataset, and fetch the runs for each example if they are associated with the given session_ids.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GroupedExamplesWithRunsResponse> ReadExamplesWithRunsGroupedAsync(
            global::System.Guid datasetId,
            global::LangSmith.QueryGroupedExamplesWithRuns request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Read Examples With Runs Grouped<br/>
        /// Fetch examples for a dataset, and fetch the runs for each example if they are associated with the given session_ids.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="sessionIds"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="preview">
        /// Default Value: false
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="metadataKey"></param>
        /// <param name="perGroupLimit">
        /// Default Value: 5
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GroupedExamplesWithRunsResponse> ReadExamplesWithRunsGroupedAsync(
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<global::System.Guid> sessionIds,
            global::LangSmith.GroupExampleRunsByField groupBy,
            string metadataKey,
            int? offset = default,
            int? limit = default,
            bool? preview = default,
            int? perGroupLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}