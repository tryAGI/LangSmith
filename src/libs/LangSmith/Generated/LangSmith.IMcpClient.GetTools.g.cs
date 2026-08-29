#nullable enable

namespace LangSmith
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Get Tools<br/>
        /// Return MCP tools — from cache if fresh, otherwise by fetching from remote.<br/>
        /// On cache miss, tries manifest fetch first (fast), then falls back to full<br/>
        /// MCP handshake. Caches the result before returning.<br/>
        /// Pass force_refresh=true to bypass the cache and always fetch from the<br/>
        /// remote server (the result is still cached via upsert for future requests).<br/>
        /// ``agent_id`` lets deployment/service-key callers name an agent OAuth<br/>
        /// subject. ``ls_user_id`` overrides are limited to service identities.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="oauthProviderId"></param>
        /// <param name="lsUserId"></param>
        /// <param name="agentId"></param>
        /// <param name="forceRefresh">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetToolsAsync(
            string url,
            string? oauthProviderId = default,
            string? lsUserId = default,
            string? agentId = default,
            bool? forceRefresh = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Tools<br/>
        /// Return MCP tools — from cache if fresh, otherwise by fetching from remote.<br/>
        /// On cache miss, tries manifest fetch first (fast), then falls back to full<br/>
        /// MCP handshake. Caches the result before returning.<br/>
        /// Pass force_refresh=true to bypass the cache and always fetch from the<br/>
        /// remote server (the result is still cached via upsert for future requests).<br/>
        /// ``agent_id`` lets deployment/service-key callers name an agent OAuth<br/>
        /// subject. ``ls_user_id`` overrides are limited to service identities.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="oauthProviderId"></param>
        /// <param name="lsUserId"></param>
        /// <param name="agentId"></param>
        /// <param name="forceRefresh">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<string>> GetToolsAsResponseAsync(
            string url,
            string? oauthProviderId = default,
            string? lsUserId = default,
            string? agentId = default,
            bool? forceRefresh = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}