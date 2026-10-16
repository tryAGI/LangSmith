#nullable enable

namespace LangSmith
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// List Fleet agent costs<br/>
        /// Returns the same agent cost report as the Fleet usage UI. Costs are derived from recorded traces, not invoice totals. Keep the time window and sorting unchanged across pages. Results are live: late traces or cost updates can move rows between pages; pagination does not provide a frozen snapshot.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
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
        global::System.Threading.Tasks.Task<global::LangSmith.UsageAgentUsagePage> ListFleetAgentCostsAsync(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.GetFleetUsageAgentsSortBy? sortBy = default,
            global::LangSmith.GetFleetUsageAgentsSortOrder? sortOrder = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Fleet agent costs<br/>
        /// Returns the same agent cost report as the Fleet usage UI. Costs are derived from recorded traces, not invoice totals. Keep the time window and sorting unchanged across pages. Results are live: late traces or cost updates can move rows between pages; pagination does not provide a frozen snapshot.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
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
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UsageAgentUsagePage>> ListFleetAgentCostsAsResponseAsync(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.GetFleetUsageAgentsSortBy? sortBy = default,
            global::LangSmith.GetFleetUsageAgentsSortOrder? sortOrder = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}