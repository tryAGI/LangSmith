#nullable enable

namespace LangSmith
{
    public partial interface IMcpVendorsClient
    {
        /// <summary>
        /// Get vendor settings<br/>
        /// Returns the current vendor-specific settings.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsArcadeSettingsResponse> GetVendorSettingsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}