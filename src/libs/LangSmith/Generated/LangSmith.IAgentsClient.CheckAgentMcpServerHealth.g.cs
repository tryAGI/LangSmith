#nullable enable

namespace LangSmith
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Check agent MCP-server health<br/>
        /// Returns a per-MCP-server health summary for the agent. Each MCP<br/>
        /// server referenced by the agent (its tools.json plus every<br/>
        /// subagent's tools.json) is probed in parallel by issuing a single<br/>
        /// MCP initialize JSON-RPC call. Credentials are resolved per<br/>
        /// (tenant, server) using the configured authentication method.<br/>
        /// Per-server failures surface as<br/>
        /// `ok=false` with an `error_code` (auth_failed | unreachable |<br/>
        /// invalid_response) and a human-readable `error` string.<br/>
        /// `mcp_check.ok` is `true` only when every server returns a<br/>
        /// healthy response; an empty server list is treated as healthy.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentsHealthResponse> CheckAgentMcpServerHealthAsync(
            global::System.Guid agentId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check agent MCP-server health<br/>
        /// Returns a per-MCP-server health summary for the agent. Each MCP<br/>
        /// server referenced by the agent (its tools.json plus every<br/>
        /// subagent's tools.json) is probed in parallel by issuing a single<br/>
        /// MCP initialize JSON-RPC call. Credentials are resolved per<br/>
        /// (tenant, server) using the configured authentication method.<br/>
        /// Per-server failures surface as<br/>
        /// `ok=false` with an `error_code` (auth_failed | unreachable |<br/>
        /// invalid_response) and a human-readable `error` string.<br/>
        /// `mcp_check.ok` is `true` only when every server returns a<br/>
        /// healthy response; an empty server list is treated as healthy.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AgentsHealthResponse>> CheckAgentMcpServerHealthAsResponseAsync(
            global::System.Guid agentId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}