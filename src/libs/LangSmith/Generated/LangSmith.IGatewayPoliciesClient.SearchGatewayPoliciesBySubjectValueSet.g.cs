#nullable enable

namespace LangSmith
{
    public partial interface IGatewayPoliciesClient
    {
        /// <summary>
        /// Search gateway policies by subject value set<br/>
        /// Batch variant of GET /v1/platform/gateway-policies for<br/>
        /// fetching policies that match a set of subject_matcher_values<br/>
        /// under one subject_matcher_key. Accepts the values in a JSON<br/>
        /// body so callers can include hundreds of subject ids without<br/>
        /// bumping into per-server URL-length limits.<br/>
        /// Visibility, response shape, and matcher semantics are<br/>
        /// identical to the GET list. With `subject_matcher_values`<br/>
        /// empty (or omitted) this returns the same result as GET<br/>
        /// with only `policy_type` set.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>> SearchGatewayPoliciesBySubjectValueSetAsync(

            global::LangSmith.GatewayPoliciesSearchGatewayPoliciesRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search gateway policies by subject value set<br/>
        /// Batch variant of GET /v1/platform/gateway-policies for<br/>
        /// fetching policies that match a set of subject_matcher_values<br/>
        /// under one subject_matcher_key. Accepts the values in a JSON<br/>
        /// body so callers can include hundreds of subject ids without<br/>
        /// bumping into per-server URL-length limits.<br/>
        /// Visibility, response shape, and matcher semantics are<br/>
        /// identical to the GET list. With `subject_matcher_values`<br/>
        /// empty (or omitted) this returns the same result as GET<br/>
        /// with only `policy_type` set.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>>> SearchGatewayPoliciesBySubjectValueSetAsResponseAsync(

            global::LangSmith.GatewayPoliciesSearchGatewayPoliciesRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search gateway policies by subject value set<br/>
        /// Batch variant of GET /v1/platform/gateway-policies for<br/>
        /// fetching policies that match a set of subject_matcher_values<br/>
        /// under one subject_matcher_key. Accepts the values in a JSON<br/>
        /// body so callers can include hundreds of subject ids without<br/>
        /// bumping into per-server URL-length limits.<br/>
        /// Visibility, response shape, and matcher semantics are<br/>
        /// identical to the GET list. With `subject_matcher_values`<br/>
        /// empty (or omitted) this returns the same result as GET<br/>
        /// with only `policy_type` set.
        /// </summary>
        /// <param name="policyType"></param>
        /// <param name="subjectMatcherKey"></param>
        /// <param name="subjectMatcherValues"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>> SearchGatewayPoliciesBySubjectValueSetAsync(
            string? policyType = default,
            string? subjectMatcherKey = default,
            global::System.Collections.Generic.IList<string>? subjectMatcherValues = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}