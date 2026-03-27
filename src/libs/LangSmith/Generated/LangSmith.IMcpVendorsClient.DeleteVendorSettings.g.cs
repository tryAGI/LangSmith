#nullable enable

namespace LangSmith
{
    public partial interface IMcpVendorsClient
    {
        /// <summary>
        /// Delete vendor settings<br/>
        /// Resets vendor settings to unconfigured state. Stub — returns empty config until persistence is implemented.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsVendorConfig> DeleteVendorSettingsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}