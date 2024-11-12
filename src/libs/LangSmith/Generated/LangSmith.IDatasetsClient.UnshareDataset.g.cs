#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Unshare Dataset<br/>
        /// Unshare a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UnshareDatasetAsync(
            global::System.Guid datasetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}