#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Update Dataset Version<br/>
        /// Set a tag on a dataset version.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetVersion> UpdateDatasetVersionAsync(
            global::System.Guid datasetId,
            global::LangSmith.PutDatasetVersionsSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Dataset Version<br/>
        /// Set a tag on a dataset version.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="asOf"></param>
        /// <param name="tag"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetVersion> UpdateDatasetVersionAsync(
            global::System.Guid datasetId,
            global::System.DateTime asOf,
            string tag,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}