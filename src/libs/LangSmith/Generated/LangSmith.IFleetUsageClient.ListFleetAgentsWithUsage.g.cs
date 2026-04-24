#nullable enable

namespace LangSmith
{
    public partial interface IFleetUsageClient
    {
        /// <summary>
        /// List fleet agents with usage<br/>
        /// Returns the top agents in the workspace with cost data for the given time window. Defaults to sorting by cost descending; pass sort_by and sort_order to change. Data is sourced entirely from ClickHouse run metadata.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="sortBy">
        /// Default Value: cost
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UsageAgentUsageResponse> ListFleetAgentsWithUsageAsync(
            string startTime,
            string endTime,
            int? limit = default,
            string? sortBy = default,
            string? sortOrder = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}