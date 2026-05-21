#nullable enable

namespace LangSmith
{
    public partial interface IGatewayPoliciesClient
    {
        /// <summary>
        /// Delete a gateway policy<br/>
        /// Deletes a gateway policy. Subsequent reads return 404.<br/>
        /// **default_spend_cap cascade:** deleting a `default_spend_cap`<br/>
        /// also deletes every child policy materialized from it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAGatewayPolicyAsync(
            global::System.Guid id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a gateway policy<br/>
        /// Deletes a gateway policy. Subsequent reads return 404.<br/>
        /// **default_spend_cap cascade:** deleting a `default_spend_cap`<br/>
        /// also deletes every child policy materialized from it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> DeleteAGatewayPolicyAsResponseAsync(
            global::System.Guid id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}