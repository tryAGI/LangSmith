#nullable enable

namespace LangSmith
{
    public partial interface IMcpVendorsClient
    {
        /// <summary>
        /// Replace vendor settings<br/>
        /// Replaces vendor settings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsArcadeSettingsResponse> ReplaceVendorSettingsAsync(

            global::LangSmith.McpVendorsArcadeSettingsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace vendor settings<br/>
        /// Replaces vendor settings.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsArcadeSettingsResponse> ReplaceVendorSettingsAsync(
            string? organizationId = default,
            string? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}