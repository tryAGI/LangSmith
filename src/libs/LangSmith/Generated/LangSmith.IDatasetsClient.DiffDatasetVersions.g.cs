#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Diff Dataset Versions<br/>
        /// Get diff between two dataset versions.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="fromVersion"></param>
        /// <param name="toVersion"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetDiffInfo> DiffDatasetVersionsAsync(
            global::System.Guid datasetId,
            global::LangSmith.AnyOf<global::System.DateTime?, string> fromVersion,
            global::LangSmith.AnyOf<global::System.DateTime?, string> toVersion,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}