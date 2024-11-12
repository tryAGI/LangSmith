#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get Current Sso Settings<br/>
        /// Get SSO provider settings for the current organization.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.SSOProvider>> GetCurrentSsoSettingsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}