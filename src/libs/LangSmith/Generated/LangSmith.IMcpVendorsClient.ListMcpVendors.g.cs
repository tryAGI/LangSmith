#nullable enable

namespace LangSmith
{
    public partial interface IMcpVendorsClient
    {
        /// <summary>
        /// List MCP vendors<br/>
        /// Returns the catalog of available MCP vendors for the workspace.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsListMcpVendorsResponse> ListMcpVendorsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}