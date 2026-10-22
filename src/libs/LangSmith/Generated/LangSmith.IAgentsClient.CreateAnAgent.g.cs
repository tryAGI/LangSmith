#nullable enable

namespace LangSmith
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create an Agent<br/>
        /// Creates an Agent with a caller-assigned ID. Returns 409 if the ID already exists. Creates all four environments unless production_only is set for a FLEET agent. agent_type defaults to CUSTOM. The authenticated user becomes the owner when available. Requires permission to create projects. The response does not include runtime bindings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentplatformAgent> CreateAnAgentAsync(

            global::LangSmith.AgentplatformAgentCreate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Agent<br/>
        /// Creates an Agent with a caller-assigned ID. Returns 409 if the ID already exists. Creates all four environments unless production_only is set for a FLEET agent. agent_type defaults to CUSTOM. The authenticated user becomes the owner when available. Requires permission to create projects. The response does not include runtime bindings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AgentplatformAgent>> CreateAnAgentAsResponseAsync(

            global::LangSmith.AgentplatformAgentCreate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Agent<br/>
        /// Creates an Agent with a caller-assigned ID. Returns 409 if the ID already exists. Creates all four environments unless production_only is set for a FLEET agent. agent_type defaults to CUSTOM. The authenticated user becomes the owner when available. Requires permission to create projects. The response does not include runtime bindings.
        /// </summary>
        /// <param name="agentType">
        /// AgentType defaults to CUSTOM when omitted.
        /// </param>
        /// <param name="id">
        /// Unique agent identifier: 1-63 lowercase letters, digits, or hyphens,<br/>
        /// starting with a letter and ending with a letter or digit.
        /// </param>
        /// <param name="name">
        /// Display name. Defaults to the agent ID.
        /// </param>
        /// <param name="productionOnly">
        /// ProductionOnly creates only the PRODUCTION environment. It is accepted<br/>
        /// only when SourceType is FLEET; other sources always get all four<br/>
        /// environments.
        /// </param>
        /// <param name="sourceType">
        /// Agent runtime kind. Use EXTERNAL for an application hosted outside LangSmith.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentplatformAgent> CreateAnAgentAsync(
            string id,
            global::LangSmith.AgentplatformAgentSourceType2 sourceType,
            global::LangSmith.AgentplatformAgentType? agentType = default,
            string? name = default,
            bool? productionOnly = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}