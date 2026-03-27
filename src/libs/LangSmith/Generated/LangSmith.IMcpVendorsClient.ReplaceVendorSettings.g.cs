#nullable enable

namespace LangSmith
{
    public partial interface IMcpVendorsClient
    {
        /// <summary>
        /// Replace vendor settings<br/>
        /// Replaces vendor settings with the provided org and project. Stub — returns the submitted values until persistence is implemented.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsVendorConfig> ReplaceVendorSettingsAsync(

            global::LangSmith.McpVendorsCreateVendorSettingsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace vendor settings<br/>
        /// Replaces vendor settings with the provided org and project. Stub — returns the submitted values until persistence is implemented.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsVendorConfig> ReplaceVendorSettingsAsync(
            string? orgId = default,
            string? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}