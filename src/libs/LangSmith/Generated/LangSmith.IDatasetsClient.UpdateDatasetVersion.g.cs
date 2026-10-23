#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Update Dataset Version<br/>
        /// Tag a dataset version.<br/>
        /// Points the tag at the version given by as_of, creating the tag or moving it<br/>
        /// if the dataset already has it. Other tags are unchanged. Requires permission<br/>
        /// to update datasets. Returns the version's time and all of its tags. Returns<br/>
        /// 400 if the tag is latest, and 404 if the dataset or the as_of tag does not<br/>
        /// exist.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetVersion> UpdateDatasetVersionAsync(
            global::System.Guid datasetId,

            global::LangSmith.PutDatasetVersionsSchema request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Dataset Version<br/>
        /// Tag a dataset version.<br/>
        /// Points the tag at the version given by as_of, creating the tag or moving it<br/>
        /// if the dataset already has it. Other tags are unchanged. Requires permission<br/>
        /// to update datasets. Returns the version's time and all of its tags. Returns<br/>
        /// 400 if the tag is latest, and 404 if the dataset or the as_of tag does not<br/>
        /// exist.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.DatasetVersion>> UpdateDatasetVersionAsResponseAsync(
            global::System.Guid datasetId,

            global::LangSmith.PutDatasetVersionsSchema request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Dataset Version<br/>
        /// Tag a dataset version.<br/>
        /// Points the tag at the version given by as_of, creating the tag or moving it<br/>
        /// if the dataset already has it. Other tags are unchanged. Requires permission<br/>
        /// to update datasets. Returns the version's time and all of its tags. Returns<br/>
        /// 400 if the tag is latest, and 404 if the dataset or the as_of tag does not<br/>
        /// exist.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="asOf">
        /// The version to tag: an ISO 8601 timestamp, or the name of an existing tag on this dataset (latest resolves to the most recent example change, and returns 404 for a dataset with no examples). A value that does not parse as a timestamp is treated as a tag name, and an unknown tag name returns 404. Timestamps are not checked against the dataset history: the tag covers every example change made on or before that time, so a future time keeps picking up new changes until it passes. Use the exact as_of of an existing version, since looking up a version by tag returns 404 when the tag's time does not match a version.
        /// </param>
        /// <param name="tag">
        /// The tag to set. If the dataset already has this tag, it is moved to the new version. The tag latest is reserved and returns 400.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetVersion> UpdateDatasetVersionAsync(
            global::System.Guid datasetId,
            global::LangSmith.AnyOf<global::System.DateTime?, string> asOf,
            string tag,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}