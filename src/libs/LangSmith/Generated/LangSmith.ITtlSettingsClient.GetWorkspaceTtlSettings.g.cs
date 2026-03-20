#nullable enable

namespace LangSmith
{
    public partial interface ITtlSettingsClient
    {

        /// <summary>
        /// Get workspace TTL settings<br/>
        /// Get the longlived trace TTL settings for a workspace
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TtlSettingsTTLSettingsResponse> GetWorkspaceTtlSettingsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}