#nullable enable

namespace LangSmith
{
    public partial interface ITtlSettingsClient
    {
        /// <summary>
        /// Update workspace Ttl settings<br/>
        /// Update the longlived trace Ttl for a workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TtlSettingsTtlSettingsResponse> UpdateWorkspaceTtlSettingsAsync(
            global::LangSmith.TtlSettingsUpdateTtlSettingsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update workspace Ttl settings<br/>
        /// Update the longlived trace Ttl for a workspace.
        /// </summary>
        /// <param name="longlivedTtlDays"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TtlSettingsTtlSettingsResponse> UpdateWorkspaceTtlSettingsAsync(
            int? longlivedTtlDays = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}