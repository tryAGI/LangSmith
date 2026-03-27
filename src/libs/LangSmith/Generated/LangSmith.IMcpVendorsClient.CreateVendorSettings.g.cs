#nullable enable

namespace LangSmith
{
    public partial interface IMcpVendorsClient
    {
        /// <summary>
        /// Create vendor settings<br/>
        /// Initializes vendor settings with the provided org and project. Stub — accepts the request and returns mock data until persistence is implemented.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsVendorConfig> CreateVendorSettingsAsync(

            global::LangSmith.McpVendorsCreateVendorSettingsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create vendor settings<br/>
        /// Initializes vendor settings with the provided org and project. Stub — accepts the request and returns mock data until persistence is implemented.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsVendorConfig> CreateVendorSettingsAsync(
            string? orgId = default,
            string? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}