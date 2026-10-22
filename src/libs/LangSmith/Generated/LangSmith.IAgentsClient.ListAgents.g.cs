#nullable enable

namespace LangSmith
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Agents<br/>
        /// Returns Agents visible to the caller. Each item is the same Agent shape as GET /api/v1/agents/{agent_id}, including the environments the caller may read. The list never embeds runtime bindings. An unknown query parameter, including limit, returns 400; use page_size to set the page size.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="sortBy">
        /// Default Value: last_run_start_time
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="sourceType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentplatformAgentListResponse> ListAgentsAsync(
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.GetAgentsSortBy? sortBy = default,
            global::LangSmith.GetAgentsSortOrder? sortOrder = default,
            global::System.Collections.Generic.IList<string>? id = default,
            string? name = default,
            global::LangSmith.GetAgentsSourceType? sourceType = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agents<br/>
        /// Returns Agents visible to the caller. Each item is the same Agent shape as GET /api/v1/agents/{agent_id}, including the environments the caller may read. The list never embeds runtime bindings. An unknown query parameter, including limit, returns 400; use page_size to set the page size.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="sortBy">
        /// Default Value: last_run_start_time
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="sourceType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AgentplatformAgentListResponse>> ListAgentsAsResponseAsync(
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.GetAgentsSortBy? sortBy = default,
            global::LangSmith.GetAgentsSortOrder? sortOrder = default,
            global::System.Collections.Generic.IList<string>? id = default,
            string? name = default,
            global::LangSmith.GetAgentsSourceType? sourceType = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}