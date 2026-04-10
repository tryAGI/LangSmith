#nullable enable

namespace LangSmith
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Invalidate Tools Cache<br/>
        /// Invalidate cached MCP tools for a given server URL.<br/>
        /// Called when a tool call fails with a stale-tools error, so subsequent<br/>
        /// requests to GET /mcp/tools will re-fetch from the remote server.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="oauthProviderId"></param>
        /// <param name="lsUserId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> InvalidateToolsCacheAsync(
            string url,
            string? oauthProviderId = default,
            string? lsUserId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}