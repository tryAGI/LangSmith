#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Index<br/>
        /// Index a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.IndexApiV1DatasetsDatasetIdIndexPostResponse> IndexAsync(
            global::System.Guid datasetId,
            global::LangSmith.DatasetIndexRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Index<br/>
        /// Index a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="tag">
        /// Default Value: latest
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.IndexApiV1DatasetsDatasetIdIndexPostResponse> IndexAsync(
            global::System.Guid datasetId,
            global::LangSmith.AnyOf<string, object>? tag = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}