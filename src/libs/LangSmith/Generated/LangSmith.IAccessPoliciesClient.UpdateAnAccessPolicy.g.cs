#nullable enable

namespace LangSmith
{
    public partial interface IAccessPoliciesClient
    {
        /// <summary>
        /// Update an access policy<br/>
        /// Updates one or more fields on an access policy.
        /// </summary>
        /// <param name="accessPolicyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AuthzInternalAccessPolicy> UpdateAnAccessPolicyAsync(
            string accessPolicyId,

            global::LangSmith.AuthzInternalUpdateAccessPolicyPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an access policy<br/>
        /// Updates one or more fields on an access policy.
        /// </summary>
        /// <param name="accessPolicyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AuthzInternalAccessPolicy>> UpdateAnAccessPolicyAsResponseAsync(
            string accessPolicyId,

            global::LangSmith.AuthzInternalUpdateAccessPolicyPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an access policy<br/>
        /// Updates one or more fields on an access policy.
        /// </summary>
        /// <param name="accessPolicyId"></param>
        /// <param name="conditionGroups"></param>
        /// <param name="description"></param>
        /// <param name="effect"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AuthzInternalAccessPolicy> UpdateAnAccessPolicyAsync(
            string accessPolicyId,
            global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalConditionGroup>? conditionGroups = default,
            string? description = default,
            string? effect = default,
            string? name = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}