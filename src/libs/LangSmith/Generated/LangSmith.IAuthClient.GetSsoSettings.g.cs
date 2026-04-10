#nullable enable

namespace LangSmith
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Get Sso Settings<br/>
        /// Get SSO provider settings from login slug.
        /// </summary>
        /// <param name="ssoLoginSlug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.SSOProviderSlim>> GetSsoSettingsAsync(
            string ssoLoginSlug,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}