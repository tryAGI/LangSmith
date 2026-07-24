#nullable enable

namespace LangSmith
{
    public partial interface IGatewayPoliciesClient
    {
        /// <summary>
        /// Update a gateway policy<br/>
        /// Partially updates a gateway policy. Only fields present in<br/>
        /// the request body are applied; absent fields are left<br/>
        /// unchanged. `policy_type` is immutable — to change a<br/>
        /// policy's type, delete it and create a new one.<br/>
        /// **config** if supplied must match the policy's type:<br/>
        /// - spend-cap:  `{"window": ..., "limit_usd": ...}`<br/>
        /// - guard:      `{"version": 1, "detect": {...}, "timeout_seconds": &lt;number&gt;, "timeout_action": "allow"|"block"}`<br/>
        /// - rate-limit: `{"version": 1, "limits": [{"metric": "requests"|"tokens", "window": "minute"|"hour", "value": &lt;integer&gt;}]}`<br/>
        /// Mismatched shapes are rejected with 400.<br/>
        /// **default cascade:** editing a `default_spend_cap` or<br/>
        /// `default_rate_limit` updates the config/action/enabled/priority<br/>
        /// on every attached child policy so the template stays the source<br/>
        /// of truth across rollouts.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        /// <remarks>
        /// {<br/>
        ///   "config": {"window": "monthly", "limit_usd": 200},<br/>
        ///   "enabled": false<br/>
        /// }
        /// </remarks>
        global::System.Threading.Tasks.Task<global::LangSmith.GatewayPoliciesGatewayPolicyRecord> UpdateAGatewayPolicyAsync(
            global::System.Guid id,

            global::LangSmith.GatewayPoliciesUpdateGatewayPolicyRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a gateway policy<br/>
        /// Partially updates a gateway policy. Only fields present in<br/>
        /// the request body are applied; absent fields are left<br/>
        /// unchanged. `policy_type` is immutable — to change a<br/>
        /// policy's type, delete it and create a new one.<br/>
        /// **config** if supplied must match the policy's type:<br/>
        /// - spend-cap:  `{"window": ..., "limit_usd": ...}`<br/>
        /// - guard:      `{"version": 1, "detect": {...}, "timeout_seconds": &lt;number&gt;, "timeout_action": "allow"|"block"}`<br/>
        /// - rate-limit: `{"version": 1, "limits": [{"metric": "requests"|"tokens", "window": "minute"|"hour", "value": &lt;integer&gt;}]}`<br/>
        /// Mismatched shapes are rejected with 400.<br/>
        /// **default cascade:** editing a `default_spend_cap` or<br/>
        /// `default_rate_limit` updates the config/action/enabled/priority<br/>
        /// on every attached child policy so the template stays the source<br/>
        /// of truth across rollouts.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        /// <remarks>
        /// {<br/>
        ///   "config": {"window": "monthly", "limit_usd": 200},<br/>
        ///   "enabled": false<br/>
        /// }
        /// </remarks>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>> UpdateAGatewayPolicyAsResponseAsync(
            global::System.Guid id,

            global::LangSmith.GatewayPoliciesUpdateGatewayPolicyRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a gateway policy<br/>
        /// Partially updates a gateway policy. Only fields present in<br/>
        /// the request body are applied; absent fields are left<br/>
        /// unchanged. `policy_type` is immutable — to change a<br/>
        /// policy's type, delete it and create a new one.<br/>
        /// **config** if supplied must match the policy's type:<br/>
        /// - spend-cap:  `{"window": ..., "limit_usd": ...}`<br/>
        /// - guard:      `{"version": 1, "detect": {...}, "timeout_seconds": &lt;number&gt;, "timeout_action": "allow"|"block"}`<br/>
        /// - rate-limit: `{"version": 1, "limits": [{"metric": "requests"|"tokens", "window": "minute"|"hour", "value": &lt;integer&gt;}]}`<br/>
        /// Mismatched shapes are rejected with 400.<br/>
        /// **default cascade:** editing a `default_spend_cap` or<br/>
        /// `default_rate_limit` updates the config/action/enabled/priority<br/>
        /// on every attached child policy so the template stays the source<br/>
        /// of truth across rollouts.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="action">
        /// Example: block
        /// </param>
        /// <param name="config"></param>
        /// <param name="description">
        /// Example: Blocks overspend on the production org
        /// </param>
        /// <param name="enabled">
        /// Example: true
        /// </param>
        /// <param name="name">
        /// Example: monthly-cap
        /// </param>
        /// <param name="priority">
        /// Example: 0
        /// </param>
        /// <param name="subjectMatchers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GatewayPoliciesGatewayPolicyRecord> UpdateAGatewayPolicyAsync(
            global::System.Guid id,
            string? action = default,
            object? config = default,
            string? description = default,
            bool? enabled = default,
            string? name = default,
            int? priority = default,
            global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesSubjectMatcher>? subjectMatchers = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}