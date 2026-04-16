#nullable enable

namespace LangSmith
{
    public partial interface IFleetMcpClient
    {
        /// <summary>
        /// List MCP tools<br/>
        /// Returns tools from a remote MCP server. Serves cached results when fresh, otherwise fetches from the remote server and caches the response.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="oauthProviderId"></param>
        /// <param name="forceRefresh"></param>
        /// <param name="lsUserId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McptoolsListToolsResponse> ListMcpToolsAsync(
            string url,
            string? oauthProviderId = default,
            bool? forceRefresh = default,
            string? lsUserId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}