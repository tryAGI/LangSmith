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
        /// The ls_user_id query parameter allows service-key callers (which don't carry<br/>
        /// ls_user_id in auth) to specify the user for per-user OAuth cache lookups.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="oauthProviderId"></param>
        /// <param name="lsUserId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetToolsAsync(
            string url,
            string? oauthProviderId = default,
            string? lsUserId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}