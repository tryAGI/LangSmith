#nullable enable

namespace LangSmith
{
    public partial interface IAccessPoliciesClient
    {
        /// <summary>
        /// Detach access policies from a role<br/>
        /// Detaches one or more access policies from a specific role.
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="accessPolicyIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DetachAccessPoliciesFromARoleAsync(
            string roleId,
            global::System.Collections.Generic.IList<string> accessPolicyIds,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detach access policies from a role<br/>
        /// Detaches one or more access policies from a specific role.
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="accessPolicyIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> DetachAccessPoliciesFromARoleAsResponseAsync(
            string roleId,
            global::System.Collections.Generic.IList<string> accessPolicyIds,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}