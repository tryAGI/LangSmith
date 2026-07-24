#nullable enable

namespace LangSmith
{
    public partial interface IGatewayPoliciesClient
    {
        /// <summary>
        /// List gateway policies<br/>
        /// Returns every gateway policy in the current organization.<br/>
        /// The response includes both admin-created policies and<br/>
        /// runtime-materialized children of `default_spend_cap` and<br/>
        /// `default_rate_limit` policies (children carry `parent_policy_id`).<br/>
        /// **Spend tracking:** each spend-cap policy carries<br/>
        /// `current_spend_usd` — the spend accumulated in the policy's<br/>
        /// active window.<br/>
        /// **Filters** (all optional):<br/>
        /// - `policy_type` — `spend_cap`, `default_spend_cap`, `guard`, `route_config`, `rate_limit`, or `default_rate_limit`<br/>
        /// - `subject_matcher_key` + `subject_matcher_value` — narrow to<br/>
        /// policies whose subject_matchers contain `{key, value}`<br/>
        /// For batch lookups by a set of subject values (e.g. many<br/>
        /// run_rule_ids at once), use POST<br/>
        /// `/v1/platform/gateway-policies/search`; it accepts the<br/>
        /// values in a JSON body and avoids the URL-length ceiling<br/>
        /// that a repeated query param would hit at scale.
        /// </summary>
        /// <param name="policyType"></param>
        /// <param name="subjectMatcherKey"></param>
        /// <param name="subjectMatcherValue"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>> ListGatewayPoliciesAsync(
            string? policyType = default,
            string? subjectMatcherKey = default,
            string? subjectMatcherValue = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List gateway policies<br/>
        /// Returns every gateway policy in the current organization.<br/>
        /// The response includes both admin-created policies and<br/>
        /// runtime-materialized children of `default_spend_cap` and<br/>
        /// `default_rate_limit` policies (children carry `parent_policy_id`).<br/>
        /// **Spend tracking:** each spend-cap policy carries<br/>
        /// `current_spend_usd` — the spend accumulated in the policy's<br/>
        /// active window.<br/>
        /// **Filters** (all optional):<br/>
        /// - `policy_type` — `spend_cap`, `default_spend_cap`, `guard`, `route_config`, `rate_limit`, or `default_rate_limit`<br/>
        /// - `subject_matcher_key` + `subject_matcher_value` — narrow to<br/>
        /// policies whose subject_matchers contain `{key, value}`<br/>
        /// For batch lookups by a set of subject values (e.g. many<br/>
        /// run_rule_ids at once), use POST<br/>
        /// `/v1/platform/gateway-policies/search`; it accepts the<br/>
        /// values in a JSON body and avoids the URL-length ceiling<br/>
        /// that a repeated query param would hit at scale.
        /// </summary>
        /// <param name="policyType"></param>
        /// <param name="subjectMatcherKey"></param>
        /// <param name="subjectMatcherValue"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>>> ListGatewayPoliciesAsResponseAsync(
            string? policyType = default,
            string? subjectMatcherKey = default,
            string? subjectMatcherValue = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}