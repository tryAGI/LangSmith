#nullable enable

namespace LangSmith
{
    public partial interface IMcpVendorsClient
    {
        /// <summary>
        /// Get vendor account for an MCP vendor<br/>
        /// Resolves the user's OAuth access token via host-backend, then calls the vendor's account endpoint to return available orgs and projects. The user must have completed the OAuth flow for this vendor. Currently only Arcade is supported.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsArcadeAccountResponseList> GetVendorAccountForAnMcpVendorAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}