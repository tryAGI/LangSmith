#nullable enable

namespace LangSmith
{
    public partial interface IWorkspaceTtlSettingsClient
    {
        /// <summary>
        /// Update workspace TTL settings<br/>
        /// Update the longlived trace TTL for a workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TtlSettingsTTLSettingsResponse> UpdateWorkspaceTtlSettingsAsync(

            global::LangSmith.TtlSettingsUpdateTTLSettingsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update workspace TTL settings<br/>
        /// Update the longlived trace TTL for a workspace.
        /// </summary>
        /// <param name="longlivedTtlDays"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TtlSettingsTTLSettingsResponse> UpdateWorkspaceTtlSettingsAsync(
            int? longlivedTtlDays = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}