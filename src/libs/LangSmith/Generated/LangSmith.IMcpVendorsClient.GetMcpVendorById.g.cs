#nullable enable

namespace LangSmith
{
    public partial interface IMcpVendorsClient
    {
        /// <summary>
        /// Get MCP vendor by ID<br/>
        /// Returns vendor metadata from the catalog, OAuth provider id for connect flows, and the user's connected accounts from host-backend.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsGetMcpVendorResponse> GetMcpVendorByIdAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}