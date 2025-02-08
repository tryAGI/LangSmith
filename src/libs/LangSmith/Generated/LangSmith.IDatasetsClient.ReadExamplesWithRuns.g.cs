#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Read Examples With Runs<br/>
        /// Fetch examples for a dataset, and fetch the runs for each example if they are associated with the given session_ids.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="format">
        /// Response format, e.g., 'csv'
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>> ReadExamplesWithRunsAsync(
            global::System.Guid datasetId,
            global::LangSmith.QueryExampleSchemaWithRuns request,
            string? format = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Read Examples With Runs<br/>
        /// Fetch examples for a dataset, and fetch the runs for each example if they are associated with the given session_ids.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="format">
        /// Response format, e.g., 'csv'
        /// </param>
        /// <param name="sessionIds"></param>
        /// <param name="requestFormat"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="filters"></param>
        /// <param name="sortParams"></param>
        /// <param name="preview">
        /// Default Value: false
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>> ReadExamplesWithRunsAsync(
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<global::System.Guid> sessionIds,
            string? format = default,
            global::LangSmith.QueryExampleSchemaWithRunsFormat? requestFormat = default,
            global::System.Guid? comparativeExperimentId = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? filters = default,
            global::LangSmith.SortParamsForRunsComparisonView? sortParams = default,
            bool? preview = default,
            int? offset = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}