#nullable enable

namespace LangSmith
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Lookup Sso By Email<br/>
        /// Look up SSO providers available for a SCIM-provisioned email address.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.SSOProviderSlim>> LookupSsoByEmailAsync(

            global::LangSmith.SSOEmailLookupRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lookup Sso By Email<br/>
        /// Look up SSO providers available for a SCIM-provisioned email address.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.SSOProviderSlim>> LookupSsoByEmailAsync(
            string email,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}