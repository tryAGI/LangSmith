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
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>> ReadExamplesWithRunsAsync(
            global::System.Guid datasetId,
            global::LangSmith.QueryExampleSchemaWithRuns request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Read Examples With Runs<br/>
        /// Fetch examples for a dataset, and fetch the runs for each example if they are associated with the given session_ids.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="sessionIds"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="filters"></param>
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
            global::LangSmith.AnyOf<global::System.Guid?, object>? comparativeExperimentId = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>, object>? filters = default,
            int? offset = 0,
            int? limit = 20,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}