#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Update Dataset Splits
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::System.Guid>> UpdateDatasetSplitsAsync(
            global::System.Guid datasetId,

            global::LangSmith.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Dataset Splits
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="splitName"></param>
        /// <param name="examples"></param>
        /// <param name="remove">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::System.Guid>> UpdateDatasetSplitsAsync(
            global::System.Guid datasetId,
            string splitName,
            global::System.Collections.Generic.IList<global::System.Guid> examples,
            bool? remove = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}