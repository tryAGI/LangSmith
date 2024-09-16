#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Download Dataset Csv<br/>
        /// Download a dataset as CSV format.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DownloadDatasetCsvApiV1DatasetsDatasetIdCsvGetResponse> DownloadDatasetCsvAsync(
            global::System.Guid datasetId,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? asOf = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}