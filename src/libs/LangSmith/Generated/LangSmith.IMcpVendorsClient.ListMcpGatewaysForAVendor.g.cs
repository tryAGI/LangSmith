#nullable enable

namespace LangSmith
{
    public partial interface IMcpVendorsClient
    {
        /// <summary>
        /// List MCP gateways for a vendor<br/>
        /// Returns the MCP gateways configured in the vendor's org/project. Stub — returns mock data until the Arcade API integration is complete.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsListMcpGatewaysResponse> ListMcpGatewaysForAVendorAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}