#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Stats Runs<br/>
        /// Get all runs by query in body payload.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnyOf<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>> StatsRunsAsync(
            global::LangSmith.RunStatsQueryParams request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Stats Runs<br/>
        /// Get all runs by query in body payload.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trace"></param>
        /// <param name="parentRun"></param>
        /// <param name="runType">
        /// Enum for run types.
        /// </param>
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
        /// <param name="dataSourceType">
        /// Enum for run data source types.
        /// </param>
        /// <param name="skipPagination"></param>
        /// <param name="searchFilter"></param>
        /// <param name="useExperimentalSearch">
        /// Default Value: false
        /// </param>
        /// <param name="groupBy">
        /// Group by param for run stats.
        /// </param>
        /// <param name="groups"></param>
        /// <param name="select"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnyOf<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>> StatsRunsAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::System.Guid? trace = default,
            global::System.Guid? parentRun = default,
            global::LangSmith.RunTypeEnum? runType = default,
            global::System.Collections.Generic.IList<global::System.Guid>? session = default,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceExample = default,
            int? executionOrder = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            bool? error = default,
            string? query = default,
            string? filter = default,
            string? traceFilter = default,
            string? treeFilter = default,
            bool? isRoot = default,
            global::LangSmith.RunsFilterDataSourceTypeEnum? dataSourceType = default,
            bool? skipPagination = default,
            string? searchFilter = default,
            bool? useExperimentalSearch = default,
            global::LangSmith.RunStatsGroupBy? groupBy = default,
            global::System.Collections.Generic.IList<string>? groups = default,
            global::System.Collections.Generic.IList<global::LangSmith.RunStatsSelect>? select = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}