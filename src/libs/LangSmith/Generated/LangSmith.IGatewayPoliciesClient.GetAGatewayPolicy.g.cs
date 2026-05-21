#nullable enable

namespace LangSmith
{
    public partial interface IGatewayPoliciesClient
    {
        /// <summary>
        /// Get a gateway policy<br/>
        /// Returns a single gateway policy by id. Cross-org access is<br/>
        /// rejected with 404<br/>
        /// **Spend tracking:** spend-cap policies include<br/>
        /// `current_spend_usd` for the active window so callers can<br/>
        /// read per-policy cost without hitting a separate endpoint.<br/>
        /// Guard policies leave it null.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GatewayPoliciesGatewayPolicyRecord> GetAGatewayPolicyAsync(
            global::System.Guid id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a gateway policy<br/>
        /// Returns a single gateway policy by id. Cross-org access is<br/>
        /// rejected with 404<br/>
        /// **Spend tracking:** spend-cap policies include<br/>
        /// `current_spend_usd` for the active window so callers can<br/>
        /// read per-policy cost without hitting a separate endpoint.<br/>
        /// Guard policies leave it null.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>> GetAGatewayPolicyAsResponseAsync(
            global::System.Guid id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}