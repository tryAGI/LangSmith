#nullable enable

namespace LangSmith
{
    public partial interface IMcpVendorsClient
    {
        /// <summary>
        /// List MCP servers for a vendor<br/>
        /// Returns the MCP gateways from the vendor for the workspace's configured org/project.
        /// </summary>
        /// <param name="vendorSlug"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsListMcpGatewaysResponse> ListMcpServersForAVendorAsync(
            string vendorSlug,
            int? limit = default,
            int? offset = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}