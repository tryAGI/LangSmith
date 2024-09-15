#nullable enable

namespace LangSmith
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Stats Shared Dataset Runs<br/>
        /// Get run stats in projects run over a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RunStats> StatsSharedDatasetRunsAsync(
            global::System.Guid shareToken,
            global::LangSmith.FilterQueryParamsForRunSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Stats Shared Dataset Runs<br/>
        /// Get run stats in projects run over a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="id"></param>
        /// <param name="trace"></param>
        /// <param name="parentRun"></param>
        /// <param name="runType"></param>
        /// <param name="session"></param>
        /// <param name="referenceExample"></param>
        /// <param name="executionOrder"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="query"></param>
        /// <param name="filter"></param>
        /// <param name="traceFilter"></param>
        /// <param name="treeFilter"></param>
        /// <param name="isRoot"></param>
        /// <param name="dataSourceType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RunStats> StatsSharedDatasetRunsAsync(
            global::System.Guid shareToken,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? trace = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? parentRun = default,
            global::LangSmith.AnyOf<global::LangSmith.RunTypeEnum?, object>? runType = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? referenceExample = default,
            global::LangSmith.AnyOf<int?, object>? executionOrder = default,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? startTime = default,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? endTime = default,
            global::LangSmith.AnyOf<bool?, object>? error = default,
            global::LangSmith.AnyOf<string, object>? query = default,
            global::LangSmith.AnyOf<string, object>? filter = default,
            global::LangSmith.AnyOf<string, object>? traceFilter = default,
            global::LangSmith.AnyOf<string, object>? treeFilter = default,
            global::LangSmith.AnyOf<bool?, object>? isRoot = default,
            global::LangSmith.AnyOf<global::LangSmith.RunsFilterDataSourceTypeEnum?, object>? dataSourceType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}