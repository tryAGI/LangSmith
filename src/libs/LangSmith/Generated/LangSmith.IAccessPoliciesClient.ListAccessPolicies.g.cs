#nullable enable

namespace LangSmith
{
    public partial interface IAccessPoliciesClient
    {
        /// <summary>
        /// List access policies<br/>
        /// Lists all access policies for the organization.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AuthzInternalListAccessPoliciesResponse> ListAccessPoliciesAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}