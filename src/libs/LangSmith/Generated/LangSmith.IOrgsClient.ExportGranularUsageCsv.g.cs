#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Export Granular Usage Csv<br/>
        /// Export granular usage data as CSV.<br/>
        /// Returns the same data as the granular-usage endpoint but formatted as a<br/>
        /// downloadable CSV file. Only workspaces the user has read access to will<br/>
        /// be included in the results.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="groupBy">
        /// Dimensions for grouping granular usage data.<br/>
        /// Default Value: workspace
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExportGranularUsageCsvAsync(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::System.Collections.Generic.IList<global::System.Guid> workspaceIds,
            global::LangSmith.GranularUsageGroupBy? groupBy = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}