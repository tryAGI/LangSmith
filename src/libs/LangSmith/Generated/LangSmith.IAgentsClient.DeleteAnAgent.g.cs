#nullable enable

namespace LangSmith
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Delete an agent<br/>
        /// Deletes the agent and all of its associated state. The call is<br/>
        /// idempotent — deleting a non-existent agent returns 204.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAnAgentAsync(
            global::System.Guid agentId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an agent<br/>
        /// Deletes the agent and all of its associated state. The call is<br/>
        /// idempotent — deleting a non-existent agent returns 204.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> DeleteAnAgentAsResponseAsync(
            global::System.Guid agentId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}