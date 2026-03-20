#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Read Grouped Experiments<br/>
        /// Stream grouped and aggregated experiments.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ReadGroupedExperimentsAsync(
            global::System.Guid datasetId,

            global::LangSmith.GroupedExperimentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Read Grouped Experiments<br/>
        /// Stream grouped and aggregated experiments.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="statsStartTime"></param>
        /// <param name="nameContains"></param>
        /// <param name="tagValueId"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="filter"></param>
        /// <param name="useApproxStats">
        /// Default Value: false
        /// </param>
        /// <param name="metadataKeys"></param>
        /// <param name="experimentLimit">
        /// Default Value: 1000
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ReadGroupedExperimentsAsync(
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<string> metadataKeys,
            global::System.DateTime? statsStartTime = default,
            string? nameContains = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            string? datasetVersion = default,
            string? filter = default,
            bool? useApproxStats = default,
            int? experimentLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}