#nullable enable

namespace LangSmith
{
    public partial interface IGatewayPoliciesClient
    {
        /// <summary>
        /// Create a gateway policy<br/>
        /// Creates a gateway policy for the calling organization.<br/>
        /// **policy_type** is one of `spend_cap`, `default_spend_cap`, or<br/>
        /// `guard`. The shape of `config` depends on policy_type:<br/>
        /// - `spend_cap` / `default_spend_cap`:<br/>
        /// `{"window": "hourly"|"daily"|"weekly"|"monthly", "limit_usd": &lt;number&gt;}`<br/>
        /// - `guard`:<br/>
        /// `{"version": 1, "detect": {"pii": &lt;bool&gt;, "secrets": &lt;bool&gt;}}`<br/>
        /// **subject_matchers** is a list of `{key, value}` pairs.<br/>
        /// `key` is one of `organization_id`, `workspace_id`, `user_id`,<br/>
        /// `api_key_id`. Multiple matchers AND together. A<br/>
        /// `default_spend_cap` uses `{key, value: ""}` so the runtime<br/>
        /// materializes a per-subject child for every distinct subject<br/>
        /// of that kind it sees in request metadata.<br/>
        /// **action** is currently always `block`. Spend caps reject the<br/>
        /// request with 402 when the limit is hit; guard policies redact<br/>
        /// matched content in-place before forwarding upstream.<br/>
        /// **Upsert by matchers:** if a policy with the same<br/>
        /// `subject_matchers` already exists in this organization, the<br/>
        /// existing policy is updated in place instead of a duplicate<br/>
        /// being created. `id` is preserved. Returns 201 either way.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        /// <remarks>
        /// {<br/>
        ///   "name": "monthly-cap",<br/>
        ///   "policy_type": "spend_cap",<br/>
        ///   "action": "block",<br/>
        ///   "subject_matchers": [{"key":"organization_id","value":"&lt;org-uuid&gt;"}],<br/>
        ///   "config": {"window": "monthly", "limit_usd": 100}<br/>
        /// }
        /// </remarks>
        global::System.Threading.Tasks.Task<global::LangSmith.GatewayPoliciesGatewayPolicyRecord> CreateAGatewayPolicyAsync(

            global::LangSmith.GatewayPoliciesCreateGatewayPolicyRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a gateway policy<br/>
        /// Creates a gateway policy for the calling organization.<br/>
        /// **policy_type** is one of `spend_cap`, `default_spend_cap`, or<br/>
        /// `guard`. The shape of `config` depends on policy_type:<br/>
        /// - `spend_cap` / `default_spend_cap`:<br/>
        /// `{"window": "hourly"|"daily"|"weekly"|"monthly", "limit_usd": &lt;number&gt;}`<br/>
        /// - `guard`:<br/>
        /// `{"version": 1, "detect": {"pii": &lt;bool&gt;, "secrets": &lt;bool&gt;}}`<br/>
        /// **subject_matchers** is a list of `{key, value}` pairs.<br/>
        /// `key` is one of `organization_id`, `workspace_id`, `user_id`,<br/>
        /// `api_key_id`. Multiple matchers AND together. A<br/>
        /// `default_spend_cap` uses `{key, value: ""}` so the runtime<br/>
        /// materializes a per-subject child for every distinct subject<br/>
        /// of that kind it sees in request metadata.<br/>
        /// **action** is currently always `block`. Spend caps reject the<br/>
        /// request with 402 when the limit is hit; guard policies redact<br/>
        /// matched content in-place before forwarding upstream.<br/>
        /// **Upsert by matchers:** if a policy with the same<br/>
        /// `subject_matchers` already exists in this organization, the<br/>
        /// existing policy is updated in place instead of a duplicate<br/>
        /// being created. `id` is preserved. Returns 201 either way.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        /// <remarks>
        /// {<br/>
        ///   "name": "monthly-cap",<br/>
        ///   "policy_type": "spend_cap",<br/>
        ///   "action": "block",<br/>
        ///   "subject_matchers": [{"key":"organization_id","value":"&lt;org-uuid&gt;"}],<br/>
        ///   "config": {"window": "monthly", "limit_usd": 100}<br/>
        /// }
        /// </remarks>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>> CreateAGatewayPolicyAsResponseAsync(

            global::LangSmith.GatewayPoliciesCreateGatewayPolicyRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a gateway policy<br/>
        /// Creates a gateway policy for the calling organization.<br/>
        /// **policy_type** is one of `spend_cap`, `default_spend_cap`, or<br/>
        /// `guard`. The shape of `config` depends on policy_type:<br/>
        /// - `spend_cap` / `default_spend_cap`:<br/>
        /// `{"window": "hourly"|"daily"|"weekly"|"monthly", "limit_usd": &lt;number&gt;}`<br/>
        /// - `guard`:<br/>
        /// `{"version": 1, "detect": {"pii": &lt;bool&gt;, "secrets": &lt;bool&gt;}}`<br/>
        /// **subject_matchers** is a list of `{key, value}` pairs.<br/>
        /// `key` is one of `organization_id`, `workspace_id`, `user_id`,<br/>
        /// `api_key_id`. Multiple matchers AND together. A<br/>
        /// `default_spend_cap` uses `{key, value: ""}` so the runtime<br/>
        /// materializes a per-subject child for every distinct subject<br/>
        /// of that kind it sees in request metadata.<br/>
        /// **action** is currently always `block`. Spend caps reject the<br/>
        /// request with 402 when the limit is hit; guard policies redact<br/>
        /// matched content in-place before forwarding upstream.<br/>
        /// **Upsert by matchers:** if a policy with the same<br/>
        /// `subject_matchers` already exists in this organization, the<br/>
        /// existing policy is updated in place instead of a duplicate<br/>
        /// being created. `id` is preserved. Returns 201 either way.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="config"></param>
        /// <param name="description"></param>
        /// <param name="enabled"></param>
        /// <param name="name"></param>
        /// <param name="policyType"></param>
        /// <param name="priority"></param>
        /// <param name="subjectMatchers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GatewayPoliciesGatewayPolicyRecord> CreateAGatewayPolicyAsync(
            string? action = default,
            object? config = default,
            string? description = default,
            bool? enabled = default,
            string? name = default,
            string? policyType = default,
            int? priority = default,
            global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesSubjectMatcher>? subjectMatchers = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}