#nullable enable

namespace LangSmith
{
    public partial interface IFleetMcpClient
    {
        /// <summary>
        /// List MCP servers<br/>
        /// Returns MCP servers visible to the caller after ABAC filtering. Service-key callers may pass X-Ls-User-Id to resolve per-user OAuth providers.
        /// </summary>
        /// <param name="xLsUserId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.LangchainComSmithFleetMcpServersMcpServer>> ListMcpServersAsync(
            string? xLsUserId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}