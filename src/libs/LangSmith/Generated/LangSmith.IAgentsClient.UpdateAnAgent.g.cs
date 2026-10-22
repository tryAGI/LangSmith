#nullable enable

namespace LangSmith
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update an Agent<br/>
        /// Updates an Agent's name, source_type, agent_type, or owner_id. Omitted fields keep their values. Changing or clearing owner_id additionally requires workspaces:manage; assigning an owner also requires workspaces:read and active workspace membership. Fleet ownership cannot be changed through this endpoint. Changing agent_type requires workspaces:manage in addition to project update access; repeating the current type is a no-op. Source type can change only for an EXTERNAL Agent without runtime bindings. The id is immutable and is rejected when present. Requires update permission on every environment project.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentplatformAgent> UpdateAnAgentAsync(
            string agentId,

            global::LangSmith.AgentplatformAgentUpdate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an Agent<br/>
        /// Updates an Agent's name, source_type, agent_type, or owner_id. Omitted fields keep their values. Changing or clearing owner_id additionally requires workspaces:manage; assigning an owner also requires workspaces:read and active workspace membership. Fleet ownership cannot be changed through this endpoint. Changing agent_type requires workspaces:manage in addition to project update access; repeating the current type is a no-op. Source type can change only for an EXTERNAL Agent without runtime bindings. The id is immutable and is rejected when present. Requires update permission on every environment project.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AgentplatformAgent>> UpdateAnAgentAsResponseAsync(
            string agentId,

            global::LangSmith.AgentplatformAgentUpdate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an Agent<br/>
        /// Updates an Agent's name, source_type, agent_type, or owner_id. Omitted fields keep their values. Changing or clearing owner_id additionally requires workspaces:manage; assigning an owner also requires workspaces:read and active workspace membership. Fleet ownership cannot be changed through this endpoint. Changing agent_type requires workspaces:manage in addition to project update access; repeating the current type is a no-op. Source type can change only for an EXTERNAL Agent without runtime bindings. The id is immutable and is rejected when present. Requires update permission on every environment project.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="agentType">
        /// New classification. Omit to keep the current classification.
        /// </param>
        /// <param name="name">
        /// New display name. Omit to keep the current name.
        /// </param>
        /// <param name="ownerId">
        /// Omit to leave the owner unchanged; null clears it.
        /// </param>
        /// <param name="sourceType">
        /// New runtime kind. Only EXTERNAL agents without runtime bindings can change kind.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentplatformAgent> UpdateAnAgentAsync(
            string agentId,
            global::LangSmith.AgentplatformAgentType? agentType = default,
            string? name = default,
            global::System.Guid? ownerId = default,
            global::LangSmith.AgentplatformAgentSourceType2? sourceType = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}