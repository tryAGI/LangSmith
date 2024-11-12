#nullable enable

namespace LangSmith
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Get Settings<br/>
        /// Get settings.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AppHubCrudTenantsTenant> GetSettingsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}