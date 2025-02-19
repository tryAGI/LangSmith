#nullable enable

namespace LangSmith
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Read Shared Dataset Examples With Runs<br/>
        /// Get examples with associated runs from sessions in a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>> ReadSharedDatasetExamplesWithRunsAsync(
            global::System.Guid shareToken,
            global::LangSmith.QueryExampleSchemaWithRuns request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Read Shared Dataset Examples With Runs<br/>
        /// Get examples with associated runs from sessions in a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="sessionIds"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="preview">
        /// Default Value: false
        /// </param>
        /// <param name="format"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="sortParams"></param>
        /// <param name="filters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>> ReadSharedDatasetExamplesWithRunsAsync(
            global::System.Guid shareToken,
            global::System.Collections.Generic.IList<global::System.Guid> sessionIds,
            int? offset = default,
            int? limit = default,
            bool? preview = default,
            global::LangSmith.QueryExampleSchemaWithRunsFormat? format = default,
            global::System.Guid? comparativeExperimentId = default,
            global::LangSmith.SortParamsForRunsComparisonView? sortParams = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? filters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}