#nullable enable

namespace LangSmith
{
    public partial interface IMcpVendorsClient
    {
        /// <summary>
        /// Get MCP vendor<br/>
        /// Returns vendor metadata and current settings.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsGetMcpVendorResponse> GetMcpVendorAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}