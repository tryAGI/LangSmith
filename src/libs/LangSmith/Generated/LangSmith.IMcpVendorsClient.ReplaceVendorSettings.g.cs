#nullable enable

namespace LangSmith
{
    public partial interface IMcpVendorsClient
    {
        /// <summary>
        /// Replace vendor settings<br/>
        /// Replaces vendor settings.
        /// </summary>
        /// <param name="vendorSlug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsArcadeSettingsResponse> ReplaceVendorSettingsAsync(
            string vendorSlug,

            global::LangSmith.McpVendorsArcadeSettingsRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace vendor settings<br/>
        /// Replaces vendor settings.
        /// </summary>
        /// <param name="vendorSlug"></param>
        /// <param name="organizationId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.McpVendorsArcadeSettingsResponse> ReplaceVendorSettingsAsync(
            string vendorSlug,
            string? organizationId = default,
            string? projectId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}