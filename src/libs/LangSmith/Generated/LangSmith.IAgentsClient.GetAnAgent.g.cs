#nullable enable

namespace LangSmith
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get an Agent<br/>
        /// Returns an Agent with the environments visible to the caller. The path value is the user-assigned Agent ID. Pass include=runtime_bindings to embed each environment's runtime bindings.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentplatformAgent> GetAnAgentAsync(
            string agentId,
            global::LangSmith.GetAgentsInclude? include = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an Agent<br/>
        /// Returns an Agent with the environments visible to the caller. The path value is the user-assigned Agent ID. Pass include=runtime_bindings to embed each environment's runtime bindings.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AgentplatformAgent>> GetAnAgentAsResponseAsync(
            string agentId,
            global::LangSmith.GetAgentsInclude? include = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}