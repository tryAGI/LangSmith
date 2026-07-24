#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Fetch experiment runs for dataset examples<br/>
        /// Returns a paginated page of dataset examples with runs from the requested experiments.<br/>
        /// Response uses the canonical `{items, next_cursor}` envelope.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetsV2DatasetsExperimentRunsResponseBody> FetchExperimentRunsForDatasetExamplesAsync(
            string datasetId,

            global::LangSmith.DatasetsV2DatasetsExperimentRunsRequestBody request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fetch experiment runs for dataset examples<br/>
        /// Returns a paginated page of dataset examples with runs from the requested experiments.<br/>
        /// Response uses the canonical `{items, next_cursor}` envelope.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.DatasetsV2DatasetsExperimentRunsResponseBody>> FetchExperimentRunsForDatasetExamplesAsResponseAsync(
            string datasetId,

            global::LangSmith.DatasetsV2DatasetsExperimentRunsRequestBody request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fetch experiment runs for dataset examples<br/>
        /// Returns a paginated page of dataset examples with runs from the requested experiments.<br/>
        /// Response uses the canonical `{items, next_cursor}` envelope.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="comparativeExperimentId">
        /// `comparative_experiment_id` scopes pairwise-annotation feedback (optional).
        /// </param>
        /// <param name="cursor">
        /// `cursor` is the opaque string from a previous response's `next_cursor`. Absent for the first page.
        /// </param>
        /// <param name="exampleIds">
        /// `example_ids` optionally restricts the page to these dataset example UUIDs (max 1000).
        /// </param>
        /// <param name="experimentIds">
        /// `experiment_ids` lists the experiment (tracing session) UUIDs to query. Required, non-empty.
        /// </param>
        /// <param name="filters">
        /// `filters` maps a project (session) UUID string to a list of filter expressions (optional).
        /// </param>
        /// <param name="pageSize">
        /// `page_size` is the maximum number of examples to return. Defaults to 20, max 100.
        /// </param>
        /// <param name="selects">
        /// `selects` lists which run properties to include. Omitted =&gt; only `id`. Tokens mirror /v2/runs/query.
        /// </param>
        /// <param name="sort">
        /// `sort` controls feedback-score sorting (single project only).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetsV2DatasetsExperimentRunsResponseBody> FetchExperimentRunsForDatasetExamplesAsync(
            string datasetId,
            string? comparativeExperimentId = default,
            string? cursor = default,
            global::System.Collections.Generic.IList<string>? exampleIds = default,
            global::System.Collections.Generic.IList<string>? experimentIds = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? filters = default,
            int? pageSize = default,
            global::System.Collections.Generic.IList<global::LangSmith.QueryRunSelectField>? selects = default,
            global::LangSmith.DatasetsV2DatasetsExperimentRunsSort? sort = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}