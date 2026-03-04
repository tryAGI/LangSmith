#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get Granular Usage<br/>
        /// Get granular usage data with flexible grouping.<br/>
        /// workspace_ids filters results to the specified workspaces. Only workspaces<br/>
        /// the user has read access to will be included in the results.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="groupBy">
        /// Dimensions for grouping granular usage data.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GranularUsageResponse> GetGranularUsageAsync(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::System.Collections.Generic.IList<global::System.Guid> workspaceIds,
            global::LangSmith.GranularUsageGroupBy? groupBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}