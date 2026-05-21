#nullable enable

namespace LangSmith
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get an agent<br/>
        /// Returns the specified agent: its metadata (name, description,<br/>
        /// permissions, runtime, extras) plus the parsed<br/>
        /// file tree (system prompt, tools, subagents, skills) at the<br/>
        /// latest commit. Pass `include_files=true` to also receive the<br/>
        /// raw file map.<br/>
        /// Responses include `system_prompt` and `instructions` with the<br/>
        /// same value; `instructions` is deprecated.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="includeFiles"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentsAgent> GetAnAgentAsync(
            global::System.Guid agentId,
            bool? includeFiles = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an agent<br/>
        /// Returns the specified agent: its metadata (name, description,<br/>
        /// permissions, runtime, extras) plus the parsed<br/>
        /// file tree (system prompt, tools, subagents, skills) at the<br/>
        /// latest commit. Pass `include_files=true` to also receive the<br/>
        /// raw file map.<br/>
        /// Responses include `system_prompt` and `instructions` with the<br/>
        /// same value; `instructions` is deprecated.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="includeFiles"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AgentsAgent>> GetAnAgentAsResponseAsync(
            global::System.Guid agentId,
            bool? includeFiles = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}