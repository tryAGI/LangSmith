#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Update Dataset Splits<br/>
        /// Add examples to a split, or remove them from it.<br/>
        /// Returns the IDs of the given examples found in the dataset. Each of them gets<br/>
        /// a new version, even when its splits do not change. An example's other splits<br/>
        /// are kept, and an example without a split counts as being in the base split.<br/>
        /// Removing an example's last split leaves it in no split.
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
        /// Update Dataset Splits<br/>
        /// Add examples to a split, or remove them from it.<br/>
        /// Returns the IDs of the given examples found in the dataset. Each of them gets<br/>
        /// a new version, even when its splits do not change. An example's other splits<br/>
        /// are kept, and an example without a split counts as being in the base split.<br/>
        /// Removing an example's last split leaves it in no split.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::System.Guid>>> UpdateDatasetSplitsAsResponseAsync(
            global::System.Guid datasetId,

            global::LangSmith.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Dataset Splits<br/>
        /// Add examples to a split, or remove them from it.<br/>
        /// Returns the IDs of the given examples found in the dataset. Each of them gets<br/>
        /// a new version, even when its splits do not change. An example's other splits<br/>
        /// are kept, and an example without a split counts as being in the base split.<br/>
        /// Removing an example's last split leaves it in no split.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="splitName">
        /// Split to add the examples to, or remove them from.
        /// </param>
        /// <param name="examples">
        /// IDs of the examples to change. IDs of examples in other datasets are ignored.
        /// </param>
        /// <param name="remove">
        /// Remove the examples from the split instead of adding them.<br/>
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