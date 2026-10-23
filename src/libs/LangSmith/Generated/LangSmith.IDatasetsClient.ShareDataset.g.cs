#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Share Dataset<br/>
        /// Share a dataset publicly and return its share token.<br/>
        /// Anyone with the share token can view the dataset, its examples, and its<br/>
        /// experiments, including their runs and feedback, without signing in. When the<br/>
        /// dataset is already shared, returns its existing share token. Fails with 403<br/>
        /// when the organization disables public sharing.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="shareProjects">
        /// Deprecated and has no effect. A shared dataset always shows its experiments.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetShareSchema> ShareDatasetAsync(
            global::System.Guid datasetId,
            bool? shareProjects = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Share Dataset<br/>
        /// Share a dataset publicly and return its share token.<br/>
        /// Anyone with the share token can view the dataset, its examples, and its<br/>
        /// experiments, including their runs and feedback, without signing in. When the<br/>
        /// dataset is already shared, returns its existing share token. Fails with 403<br/>
        /// when the organization disables public sharing.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="shareProjects">
        /// Deprecated and has no effect. A shared dataset always shows its experiments.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.DatasetShareSchema>> ShareDatasetAsResponseAsync(
            global::System.Guid datasetId,
            bool? shareProjects = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}