#nullable enable

namespace LangSmith
{
    public partial interface IGatewayPoliciesClient
    {
        /// <summary>
        /// List gateway policies<br/>
        /// Returns every gateway policy in the current organization.<br/>
        /// The response includes both admin-created policies and<br/>
        /// runtime-materialized children of `default_spend_cap`<br/>
        /// policies (children carry `parent_policy_id`).<br/>
        /// **Spend tracking:** each spend-cap policy carries<br/>
        /// `current_spend_usd` — the spend accumulated in the policy's<br/>
        /// active window.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>> ListGatewayPoliciesAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List gateway policies<br/>
        /// Returns every gateway policy in the current organization.<br/>
        /// The response includes both admin-created policies and<br/>
        /// runtime-materialized children of `default_spend_cap`<br/>
        /// policies (children carry `parent_policy_id`).<br/>
        /// **Spend tracking:** each spend-cap policy carries<br/>
        /// `current_spend_usd` — the spend accumulated in the policy's<br/>
        /// active window.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>>> ListGatewayPoliciesAsResponseAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}