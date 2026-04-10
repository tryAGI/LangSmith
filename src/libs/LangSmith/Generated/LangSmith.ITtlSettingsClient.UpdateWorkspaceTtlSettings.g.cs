#nullable enable

namespace LangSmith
{
    public partial interface ITtlSettingsClient
    {
        /// <summary>
        /// Update workspace TTL settings<br/>
        /// Update the longlived trace TTL for a workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TtlSettingsTTLSettingsResponse> UpdateWorkspaceTtlSettingsAsync(

            global::LangSmith.TtlSettingsUpdateTTLSettingsRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update workspace TTL settings<br/>
        /// Update the longlived trace TTL for a workspace.
        /// </summary>
        /// <param name="longlivedTtlDays"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TtlSettingsTTLSettingsResponse> UpdateWorkspaceTtlSettingsAsync(
            int? longlivedTtlDays = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}