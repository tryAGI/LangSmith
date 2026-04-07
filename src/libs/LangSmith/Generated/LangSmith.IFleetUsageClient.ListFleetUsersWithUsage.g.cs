#nullable enable

namespace LangSmith
{
    public partial interface IFleetUsageClient
    {
        /// <summary>
        /// List fleet users with usage<br/>
        /// Returns the top users with aggregated cost data for the given time window, sorted by total cost descending.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FleetUsageUserUsageResponse> ListFleetUsersWithUsageAsync(
            string startTime,
            string endTime,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}