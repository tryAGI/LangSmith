#nullable enable

namespace LangSmith
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List my agents<br/>
        /// Returns the agents owned by the authenticated user. System-<br/>
        /// created default agents are excluded.<br/>
        /// Cursor-based pagination — pass `cursor` from the previous<br/>
        /// response. `next_cursor` is `null` when there are no more pages.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="cursor"></param>
        /// <param name="name"></param>
        /// <param name="sortBy">
        /// Default Value: updated_at
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentsListAgentsResponse> ListMyAgentsAsync(
            int? pageSize = default,
            string? cursor = default,
            string? name = default,
            global::LangSmith.GetFleetAgentsSortBy? sortBy = default,
            global::LangSmith.GetFleetAgentsSortOrder? sortOrder = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List my agents<br/>
        /// Returns the agents owned by the authenticated user. System-<br/>
        /// created default agents are excluded.<br/>
        /// Cursor-based pagination — pass `cursor` from the previous<br/>
        /// response. `next_cursor` is `null` when there are no more pages.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="cursor"></param>
        /// <param name="name"></param>
        /// <param name="sortBy">
        /// Default Value: updated_at
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AgentsListAgentsResponse>> ListMyAgentsAsResponseAsync(
            int? pageSize = default,
            string? cursor = default,
            string? name = default,
            global::LangSmith.GetFleetAgentsSortBy? sortBy = default,
            global::LangSmith.GetFleetAgentsSortOrder? sortOrder = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}