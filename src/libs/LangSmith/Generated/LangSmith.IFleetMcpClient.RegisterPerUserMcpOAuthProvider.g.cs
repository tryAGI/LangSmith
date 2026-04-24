#nullable enable

namespace LangSmith
{
    public partial interface IFleetMcpClient
    {
        /// <summary>
        /// Register per-user MCP OAuth provider<br/>
        /// Discovers and registers an OAuth provider for a user against an MCP server configured with per-user dynamic client mode. Idempotent when a mapping already exists.
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.LangchainComSmithFleetMcpServersRegisterOAuthProviderResponse> RegisterPerUserMcpOAuthProviderAsync(
            string mcpServerId,

            global::LangSmith.LangchainComSmithFleetMcpServersRegisterOAuthProviderPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register per-user MCP OAuth provider<br/>
        /// Discovers and registers an OAuth provider for a user against an MCP server configured with per-user dynamic client mode. Idempotent when a mapping already exists.
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="lsUserId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.LangchainComSmithFleetMcpServersRegisterOAuthProviderResponse> RegisterPerUserMcpOAuthProviderAsync(
            string mcpServerId,
            string? lsUserId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}