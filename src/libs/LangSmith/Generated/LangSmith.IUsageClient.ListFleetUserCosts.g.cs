#nullable enable

namespace LangSmith
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// List Fleet user costs<br/>
        /// Returns the same user cost report as the Fleet usage UI, grouped by recorded user email. Runs without a user email are omitted. Costs are estimates in USD from recorded traces, not invoice totals. Requires `fleet:read-admin-config`. Keep the time window and sorting unchanged across pages. Results are live: late traces or cost updates can move rows between pages; pagination does not provide a frozen snapshot.
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
        /// <param name="email"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UsageUserUsagePage> ListFleetUserCostsAsync(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.GetFleetUsageUsersSortBy? sortBy = default,
            global::LangSmith.GetFleetUsageUsersSortOrder? sortOrder = default,
            string? email = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Fleet user costs<br/>
        /// Returns the same user cost report as the Fleet usage UI, grouped by recorded user email. Runs without a user email are omitted. Costs are estimates in USD from recorded traces, not invoice totals. Requires `fleet:read-admin-config`. Keep the time window and sorting unchanged across pages. Results are live: late traces or cost updates can move rows between pages; pagination does not provide a frozen snapshot.
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
        /// <param name="email"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UsageUserUsagePage>> ListFleetUserCostsAsResponseAsync(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.GetFleetUsageUsersSortBy? sortBy = default,
            global::LangSmith.GetFleetUsageUsersSortOrder? sortOrder = default,
            string? email = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}