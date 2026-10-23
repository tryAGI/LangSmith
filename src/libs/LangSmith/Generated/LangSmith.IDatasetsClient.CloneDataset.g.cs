#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Clone Dataset<br/>
        /// Copy examples from a source dataset into an existing target dataset.<br/>
        /// Each copied example gets a new ID and keeps the inputs, outputs, metadata,<br/>
        /// and source run ID of its source example. Attachments are copied when blob<br/>
        /// storage is enabled. Copying the same examples twice adds them twice.<br/>
        /// Requires the datasets:clone permission on both datasets. Returns the ID,<br/>
        /// dataset ID, creation and modification times, and source run ID of each new<br/>
        /// example. Without example IDs, a source or target that is not found can<br/>
        /// return an empty list instead of an error.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> CloneDatasetAsync(

            global::LangSmith.BodyCloneDatasetApiV1DatasetsClonePost request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone Dataset<br/>
        /// Copy examples from a source dataset into an existing target dataset.<br/>
        /// Each copied example gets a new ID and keeps the inputs, outputs, metadata,<br/>
        /// and source run ID of its source example. Attachments are copied when blob<br/>
        /// storage is enabled. Copying the same examples twice adds them twice.<br/>
        /// Requires the datasets:clone permission on both datasets. Returns the ID,<br/>
        /// dataset ID, creation and modification times, and source run ID of each new<br/>
        /// example. Without example IDs, a source or target that is not found can<br/>
        /// return an empty list instead of an error.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<object>>> CloneDatasetAsResponseAsync(

            global::LangSmith.BodyCloneDatasetApiV1DatasetsClonePost request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone Dataset<br/>
        /// Copy examples from a source dataset into an existing target dataset.<br/>
        /// Each copied example gets a new ID and keeps the inputs, outputs, metadata,<br/>
        /// and source run ID of its source example. Attachments are copied when blob<br/>
        /// storage is enabled. Copying the same examples twice adds them twice.<br/>
        /// Requires the datasets:clone permission on both datasets. Returns the ID,<br/>
        /// dataset ID, creation and modification times, and source run ID of each new<br/>
        /// example. Without example IDs, a source or target that is not found can<br/>
        /// return an empty list instead of an error.
        /// </summary>
        /// <param name="targetDatasetId">
        /// ID of the dataset in this workspace that receives the copied examples. Its current examples are kept.
        /// </param>
        /// <param name="sourceDatasetId">
        /// ID of the dataset in this workspace to copy examples from. It is not modified.
        /// </param>
        /// <param name="asOf">
        /// Version of the source dataset to copy. A value that parses as an ISO 8601 date or timestamp copies the examples as they were at that time; latest copies the current examples; any other value is a version tag. Defaults to latest.
        /// </param>
        /// <param name="examples">
        /// IDs of source examples to copy. Defaults to every example in the source version. When IDs are given and nothing is copied, because none match or either dataset is not found, the request fails with 404.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="split">
        /// Split name, or list of split names, assigned to every copied example in place of its source splits. Defaults to keeping the source splits.
        /// </param>
        /// <param name="tagValueIds">
        /// List of resource tag value IDs to attach to the target dataset, up to 100. Requires the datasets:tag_on_create permission.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> CloneDatasetAsync(
            global::System.Guid targetDatasetId,
            global::System.Guid sourceDatasetId,
            global::LangSmith.AnyOf<global::System.DateTime?, string>? asOf = default,
            global::System.Collections.Generic.IList<global::System.Guid>? examples = default,
            global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<string>>? split = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueIds = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}