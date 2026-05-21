#nullable enable

namespace LangSmith
{
    public partial interface IFleetAuthClient
    {
        /// <summary>
        /// Revoke an agent's connection<br/>
        /// Removes a single connection from an agent. The underlying token is not revoked.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="connectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task RevokeAnAgentsConnectionAsync(
            string agentId,
            string connectionId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke an agent's connection<br/>
        /// Removes a single connection from an agent. The underlying token is not revoked.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="connectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> RevokeAnAgentsConnectionAsResponseAsync(
            string agentId,
            string connectionId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}