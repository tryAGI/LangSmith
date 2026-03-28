#nullable enable

namespace LangSmith
{
    public partial interface IMcpVendorsClient
    {
        /// <summary>
        /// Get vendor account<br/>
        /// Resolves OAuth token and returns the vendor's account info.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsArcadeAccountResponseList> GetVendorAccountAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}