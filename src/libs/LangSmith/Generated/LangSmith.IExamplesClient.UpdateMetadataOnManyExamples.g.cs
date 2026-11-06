#nullable enable

namespace LangSmith
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Update metadata on many examples<br/>
        /// Applies the same metadata changes, in order, to every listed example in<br/>
        /// a dataset. Examples that are not in the dataset or were deleted are<br/>
        /// skipped; the rest are updated together, so if the update fails none of<br/>
        /// them change. Answers 207 with one status per submitted example ID:<br/>
        /// UPDATED, or NOT_FOUND for a skipped example. Metadata keys the<br/>
        /// operations do not name keep their values. To add examples to a split or<br/>
        /// remove them from one, use ARRAY_ADD or ARRAY_REMOVE on the dataset_split<br/>
        /// key. Requires permission to update datasets.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ExamplesBulkUpdateMetadataResponse> UpdateMetadataOnManyExamplesAsync(
            global::System.Guid datasetId,

            global::LangSmith.ExamplesBulkUpdateMetadataRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update metadata on many examples<br/>
        /// Applies the same metadata changes, in order, to every listed example in<br/>
        /// a dataset. Examples that are not in the dataset or were deleted are<br/>
        /// skipped; the rest are updated together, so if the update fails none of<br/>
        /// them change. Answers 207 with one status per submitted example ID:<br/>
        /// UPDATED, or NOT_FOUND for a skipped example. Metadata keys the<br/>
        /// operations do not name keep their values. To add examples to a split or<br/>
        /// remove them from one, use ARRAY_ADD or ARRAY_REMOVE on the dataset_split<br/>
        /// key. Requires permission to update datasets.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ExamplesBulkUpdateMetadataResponse>> UpdateMetadataOnManyExamplesAsResponseAsync(
            global::System.Guid datasetId,

            global::LangSmith.ExamplesBulkUpdateMetadataRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update metadata on many examples<br/>
        /// Applies the same metadata changes, in order, to every listed example in<br/>
        /// a dataset. Examples that are not in the dataset or were deleted are<br/>
        /// skipped; the rest are updated together, so if the update fails none of<br/>
        /// them change. Answers 207 with one status per submitted example ID:<br/>
        /// UPDATED, or NOT_FOUND for a skipped example. Metadata keys the<br/>
        /// operations do not name keep their values. To add examples to a split or<br/>
        /// remove them from one, use ARRAY_ADD or ARRAY_REMOVE on the dataset_split<br/>
        /// key. Requires permission to update datasets.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="exampleIds">
        /// The IDs of the examples to change; at most 10000. IDs of examples that are not in<br/>
        /// the dataset, or were deleted, are skipped and reported as NOT_FOUND.
        /// </param>
        /// <param name="operations">
        /// The metadata changes to apply, in order; at most 50, of which at most 10 are<br/>
        /// array operations.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ExamplesBulkUpdateMetadataResponse> UpdateMetadataOnManyExamplesAsync(
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<global::System.Guid> exampleIds,
            global::System.Collections.Generic.IList<global::LangSmith.ExamplesMetadataOperation> operations,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}