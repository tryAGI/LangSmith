#nullable enable

namespace LangSmith
{
    public partial interface IGatewayPoliciesClient
    {
        /// <summary>
        /// Create a gateway policy<br/>
        /// Creates a gateway policy for the calling organization.<br/>
        /// **policy_type** is one of `spend_cap`, `default_spend_cap`,<br/>
        /// `guard`, `route_config`, `model_fallback`, `rate_limit`, or `default_rate_limit`.<br/>
        /// The shape of `config` depends on policy_type:<br/>
        /// - `spend_cap` / `default_spend_cap`:<br/>
        /// `{"window": "hourly"|"daily"|"weekly"|"monthly", "limit_usd": &lt;number&gt;}`<br/>
        /// - `guard`:<br/>
        /// `{"version": 1, "detect": {"pii": &lt;bool&gt;, "secrets": &lt;bool&gt;}, "timeout_seconds": &lt;number&gt;, "timeout_action": "allow"|"block"}`<br/>
        /// `timeout_seconds` (optional, 0.1–30) caps guard pipeline execution time; defaults to 2s. `timeout_action` defaults to `allow`.<br/>
        /// - `route_config`:<br/>
        /// `{"strategy": "priority_fallback", "triggers": {"status_codes": [&lt;int&gt;]}, "fallbacks": [{"model_configs": [{"model_config_id": "&lt;playground-settings-uuid&gt;"}]}]}`<br/>
        /// `triggers` is required, with no default: `status_codes` must be a non-empty list (include 502 and 504 for upstream transport failures). `fallbacks` contains an entry whose `model_configs` are tried in priority order (1–5). `subject_matchers` must be a single `workspace_id` entry.<br/>
        /// - `model_fallback`:<br/>
        /// `{"strategy": "priority_fallback", "triggers": {"status_codes": [429, 502, 503, 504]}, "chain": {"selector": {"type": "provider_model", "provider": "openai", "model": "gpt-4o"}, "candidates": [{"type": "provider_model", "provider": "openai", "model": "gpt-4o-mini"}, {"type": "model_config", "model_config_id": "&lt;playground-settings-uuid&gt;"}]}}`<br/>
        /// `chain.candidates` is an ordered list of 1–5 direct provider models or saved workspace model configurations. A non-empty `workspace_id` matcher is required. `provider_model` selectors are workspace-only; `alias` selectors may be narrowed by `user_id` or `api_key_id`. Provider/model selectors are unique within a workspace, while alias names are reserved across the organization and may intentionally shadow a model name.<br/>
        /// - `rate_limit` / `default_rate_limit`:<br/>
        /// `{"version": 1, "limits": [{"metric": "requests"|"tokens", "window": "minute"|"hour", "value": &lt;integer&gt;}]}`<br/>
        /// `limits` must be non-empty; each `metric`/`window` pair may appear at most once. `value` is 1..1000000000000000.<br/>
        /// **subject_matchers** is a list of `{key, value}` pairs. Built-in<br/>
        /// keys are `organization_id`, `workspace_id`, `user_id`, `api_key_id`,<br/>
        /// and `run_rule_id`. Values under the same key are ORed; distinct keys<br/>
        /// are ANDed. A default policy uses an empty built-in matcher value so<br/>
        /// the runtime materializes a child for each subject it sees. A<br/>
        /// `default_spend_cap` and `default_rate_limit` may add one empty custom<br/>
        /// metadata key to bucket each subject by the corresponding<br/>
        /// `X-Gateway-*` request header; the materialized child stores both values.<br/>
        /// **action** is currently always `block`. Spend caps reject the<br/>
        /// request with 402 when the limit is hit; rate limits reject with<br/>
        /// 429 (with a `Retry-After` hint) when a limit is exceeded; guard<br/>
        /// policies redact matched content in-place before forwarding upstream.<br/>
        /// **Upsert by matchers:** for `spend_cap`, `default_spend_cap`,<br/>
        /// `rate_limit`, `default_rate_limit`, and `guard`, if a policy with<br/>
        /// the same `subject_matchers` already exists in this organization,<br/>
        /// the existing policy is updated in place instead of a duplicate<br/>
        /// being created. `id` is preserved. `route_config` and `model_fallback` do not upsert<br/>
        /// by matchers — name must be unique per organization (409 on<br/>
        /// conflict). Returns 201 either way.
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
        /// **policy_type** is one of `spend_cap`, `default_spend_cap`,<br/>
        /// `guard`, `route_config`, `model_fallback`, `rate_limit`, or `default_rate_limit`.<br/>
        /// The shape of `config` depends on policy_type:<br/>
        /// - `spend_cap` / `default_spend_cap`:<br/>
        /// `{"window": "hourly"|"daily"|"weekly"|"monthly", "limit_usd": &lt;number&gt;}`<br/>
        /// - `guard`:<br/>
        /// `{"version": 1, "detect": {"pii": &lt;bool&gt;, "secrets": &lt;bool&gt;}, "timeout_seconds": &lt;number&gt;, "timeout_action": "allow"|"block"}`<br/>
        /// `timeout_seconds` (optional, 0.1–30) caps guard pipeline execution time; defaults to 2s. `timeout_action` defaults to `allow`.<br/>
        /// - `route_config`:<br/>
        /// `{"strategy": "priority_fallback", "triggers": {"status_codes": [&lt;int&gt;]}, "fallbacks": [{"model_configs": [{"model_config_id": "&lt;playground-settings-uuid&gt;"}]}]}`<br/>
        /// `triggers` is required, with no default: `status_codes` must be a non-empty list (include 502 and 504 for upstream transport failures). `fallbacks` contains an entry whose `model_configs` are tried in priority order (1–5). `subject_matchers` must be a single `workspace_id` entry.<br/>
        /// - `model_fallback`:<br/>
        /// `{"strategy": "priority_fallback", "triggers": {"status_codes": [429, 502, 503, 504]}, "chain": {"selector": {"type": "provider_model", "provider": "openai", "model": "gpt-4o"}, "candidates": [{"type": "provider_model", "provider": "openai", "model": "gpt-4o-mini"}, {"type": "model_config", "model_config_id": "&lt;playground-settings-uuid&gt;"}]}}`<br/>
        /// `chain.candidates` is an ordered list of 1–5 direct provider models or saved workspace model configurations. A non-empty `workspace_id` matcher is required. `provider_model` selectors are workspace-only; `alias` selectors may be narrowed by `user_id` or `api_key_id`. Provider/model selectors are unique within a workspace, while alias names are reserved across the organization and may intentionally shadow a model name.<br/>
        /// - `rate_limit` / `default_rate_limit`:<br/>
        /// `{"version": 1, "limits": [{"metric": "requests"|"tokens", "window": "minute"|"hour", "value": &lt;integer&gt;}]}`<br/>
        /// `limits` must be non-empty; each `metric`/`window` pair may appear at most once. `value` is 1..1000000000000000.<br/>
        /// **subject_matchers** is a list of `{key, value}` pairs. Built-in<br/>
        /// keys are `organization_id`, `workspace_id`, `user_id`, `api_key_id`,<br/>
        /// and `run_rule_id`. Values under the same key are ORed; distinct keys<br/>
        /// are ANDed. A default policy uses an empty built-in matcher value so<br/>
        /// the runtime materializes a child for each subject it sees. A<br/>
        /// `default_spend_cap` and `default_rate_limit` may add one empty custom<br/>
        /// metadata key to bucket each subject by the corresponding<br/>
        /// `X-Gateway-*` request header; the materialized child stores both values.<br/>
        /// **action** is currently always `block`. Spend caps reject the<br/>
        /// request with 402 when the limit is hit; rate limits reject with<br/>
        /// 429 (with a `Retry-After` hint) when a limit is exceeded; guard<br/>
        /// policies redact matched content in-place before forwarding upstream.<br/>
        /// **Upsert by matchers:** for `spend_cap`, `default_spend_cap`,<br/>
        /// `rate_limit`, `default_rate_limit`, and `guard`, if a policy with<br/>
        /// the same `subject_matchers` already exists in this organization,<br/>
        /// the existing policy is updated in place instead of a duplicate<br/>
        /// being created. `id` is preserved. `route_config` and `model_fallback` do not upsert<br/>
        /// by matchers — name must be unique per organization (409 on<br/>
        /// conflict). Returns 201 either way.
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
        /// **policy_type** is one of `spend_cap`, `default_spend_cap`,<br/>
        /// `guard`, `route_config`, `model_fallback`, `rate_limit`, or `default_rate_limit`.<br/>
        /// The shape of `config` depends on policy_type:<br/>
        /// - `spend_cap` / `default_spend_cap`:<br/>
        /// `{"window": "hourly"|"daily"|"weekly"|"monthly", "limit_usd": &lt;number&gt;}`<br/>
        /// - `guard`:<br/>
        /// `{"version": 1, "detect": {"pii": &lt;bool&gt;, "secrets": &lt;bool&gt;}, "timeout_seconds": &lt;number&gt;, "timeout_action": "allow"|"block"}`<br/>
        /// `timeout_seconds` (optional, 0.1–30) caps guard pipeline execution time; defaults to 2s. `timeout_action` defaults to `allow`.<br/>
        /// - `route_config`:<br/>
        /// `{"strategy": "priority_fallback", "triggers": {"status_codes": [&lt;int&gt;]}, "fallbacks": [{"model_configs": [{"model_config_id": "&lt;playground-settings-uuid&gt;"}]}]}`<br/>
        /// `triggers` is required, with no default: `status_codes` must be a non-empty list (include 502 and 504 for upstream transport failures). `fallbacks` contains an entry whose `model_configs` are tried in priority order (1–5). `subject_matchers` must be a single `workspace_id` entry.<br/>
        /// - `model_fallback`:<br/>
        /// `{"strategy": "priority_fallback", "triggers": {"status_codes": [429, 502, 503, 504]}, "chain": {"selector": {"type": "provider_model", "provider": "openai", "model": "gpt-4o"}, "candidates": [{"type": "provider_model", "provider": "openai", "model": "gpt-4o-mini"}, {"type": "model_config", "model_config_id": "&lt;playground-settings-uuid&gt;"}]}}`<br/>
        /// `chain.candidates` is an ordered list of 1–5 direct provider models or saved workspace model configurations. A non-empty `workspace_id` matcher is required. `provider_model` selectors are workspace-only; `alias` selectors may be narrowed by `user_id` or `api_key_id`. Provider/model selectors are unique within a workspace, while alias names are reserved across the organization and may intentionally shadow a model name.<br/>
        /// - `rate_limit` / `default_rate_limit`:<br/>
        /// `{"version": 1, "limits": [{"metric": "requests"|"tokens", "window": "minute"|"hour", "value": &lt;integer&gt;}]}`<br/>
        /// `limits` must be non-empty; each `metric`/`window` pair may appear at most once. `value` is 1..1000000000000000.<br/>
        /// **subject_matchers** is a list of `{key, value}` pairs. Built-in<br/>
        /// keys are `organization_id`, `workspace_id`, `user_id`, `api_key_id`,<br/>
        /// and `run_rule_id`. Values under the same key are ORed; distinct keys<br/>
        /// are ANDed. A default policy uses an empty built-in matcher value so<br/>
        /// the runtime materializes a child for each subject it sees. A<br/>
        /// `default_spend_cap` and `default_rate_limit` may add one empty custom<br/>
        /// metadata key to bucket each subject by the corresponding<br/>
        /// `X-Gateway-*` request header; the materialized child stores both values.<br/>
        /// **action** is currently always `block`. Spend caps reject the<br/>
        /// request with 402 when the limit is hit; rate limits reject with<br/>
        /// 429 (with a `Retry-After` hint) when a limit is exceeded; guard<br/>
        /// policies redact matched content in-place before forwarding upstream.<br/>
        /// **Upsert by matchers:** for `spend_cap`, `default_spend_cap`,<br/>
        /// `rate_limit`, `default_rate_limit`, and `guard`, if a policy with<br/>
        /// the same `subject_matchers` already exists in this organization,<br/>
        /// the existing policy is updated in place instead of a duplicate<br/>
        /// being created. `id` is preserved. `route_config` and `model_fallback` do not upsert<br/>
        /// by matchers — name must be unique per organization (409 on<br/>
        /// conflict). Returns 201 either way.
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