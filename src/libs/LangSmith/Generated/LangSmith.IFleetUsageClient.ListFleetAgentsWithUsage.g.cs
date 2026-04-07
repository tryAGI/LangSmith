#nullable enable

namespace LangSmith
{
    public partial interface IFleetUsageClient
    {
        /// <summary>
        /// List fleet agents with usage<br/>
        /// Returns the top agents in the workspace with cost data for the given time window, sorted by total cost descending. Data is sourced entirely from ClickHouse run metadata.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FleetUsageAgentUsageResponse> ListFleetAgentsWithUsageAsync(
            string startTime,
            string endTime,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}