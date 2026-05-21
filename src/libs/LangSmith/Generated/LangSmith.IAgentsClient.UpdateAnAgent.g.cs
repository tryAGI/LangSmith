#nullable enable

namespace LangSmith
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update an agent<br/>
        /// Updates the specified agent. All request fields are optional;<br/>
        /// omitted fields are left unchanged.<br/>
        /// Merge semantics follow PATCH conventions:<br/>
        /// * Top-level scalars (`name`, `description`) merge field-by-field —<br/>
        /// sending one does not affect the other.<br/>
        /// * Nested objects (`runtime`, `permissions`, `tools`,<br/>
        /// `subagents`, `skills`, `extras`) are replaced in full when any<br/>
        /// of their fields is provided. To preserve existing nested values,<br/>
        /// include them in your PATCH.<br/>
        /// * Providing any of `system_prompt`, `tools`, `subagents`, `skills`,<br/>
        /// or `files` triggers a new file tree commit. `instructions` is<br/>
        /// a deprecated alias for `system_prompt` and is still accepted;<br/>
        /// `system_prompt` wins when both are sent.<br/>
        /// Entries under `files` are created or replaced by path. The call is<br/>
        /// atomic per request: if any entry fails validation, no changes are<br/>
        /// applied.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="includeFiles"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentsAgent> UpdateAnAgentAsync(
            global::System.Guid agentId,

            global::LangSmith.AgentsUpdateAgentRequest request,
            bool? includeFiles = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent<br/>
        /// Updates the specified agent. All request fields are optional;<br/>
        /// omitted fields are left unchanged.<br/>
        /// Merge semantics follow PATCH conventions:<br/>
        /// * Top-level scalars (`name`, `description`) merge field-by-field —<br/>
        /// sending one does not affect the other.<br/>
        /// * Nested objects (`runtime`, `permissions`, `tools`,<br/>
        /// `subagents`, `skills`, `extras`) are replaced in full when any<br/>
        /// of their fields is provided. To preserve existing nested values,<br/>
        /// include them in your PATCH.<br/>
        /// * Providing any of `system_prompt`, `tools`, `subagents`, `skills`,<br/>
        /// or `files` triggers a new file tree commit. `instructions` is<br/>
        /// a deprecated alias for `system_prompt` and is still accepted;<br/>
        /// `system_prompt` wins when both are sent.<br/>
        /// Entries under `files` are created or replaced by path. The call is<br/>
        /// atomic per request: if any entry fails validation, no changes are<br/>
        /// applied.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="includeFiles"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AgentsAgent>> UpdateAnAgentAsResponseAsync(
            global::System.Guid agentId,

            global::LangSmith.AgentsUpdateAgentRequest request,
            bool? includeFiles = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent<br/>
        /// Updates the specified agent. All request fields are optional;<br/>
        /// omitted fields are left unchanged.<br/>
        /// Merge semantics follow PATCH conventions:<br/>
        /// * Top-level scalars (`name`, `description`) merge field-by-field —<br/>
        /// sending one does not affect the other.<br/>
        /// * Nested objects (`runtime`, `permissions`, `tools`,<br/>
        /// `subagents`, `skills`, `extras`) are replaced in full when any<br/>
        /// of their fields is provided. To preserve existing nested values,<br/>
        /// include them in your PATCH.<br/>
        /// * Providing any of `system_prompt`, `tools`, `subagents`, `skills`,<br/>
        /// or `files` triggers a new file tree commit. `instructions` is<br/>
        /// a deprecated alias for `system_prompt` and is still accepted;<br/>
        /// `system_prompt` wins when both are sent.<br/>
        /// Entries under `files` are created or replaced by path. The call is<br/>
        /// atomic per request: if any entry fails validation, no changes are<br/>
        /// applied.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="includeFiles"></param>
        /// <param name="deletedPaths">
        /// Paths to remove from the file tree. Relative paths only.
        /// </param>
        /// <param name="description"></param>
        /// <param name="extras">
        /// Caller-defined key/value tracking attached to the agent's metadata.
        /// </param>
        /// <param name="files">
        /// Raw file entries created or replaced by path. Triggers a new commit.
        /// </param>
        /// <param name="instructions">
        /// Deprecated: use `system_prompt`. Accepted for backwards compatibility;<br/>
        /// `system_prompt` takes precedence when both are set.
        /// </param>
        /// <param name="name"></param>
        /// <param name="permissions"></param>
        /// <param name="runtime"></param>
        /// <param name="skills">
        /// Skills. Each entry is written to `skills/&lt;name&gt;/SKILL.md` and supporting files. Triggers a new commit.
        /// </param>
        /// <param name="subagents">
        /// Subagents. Each entry is written to `subagents/&lt;name&gt;/AGENTS.md` and `subagents/&lt;name&gt;/tools.json`. Triggers a new commit.
        /// </param>
        /// <param name="systemPrompt">
        /// Agent system prompt. Written to `AGENTS.md`. Triggers a new commit.<br/>
        /// Example: You are a helpful agent. Use the available tools to answer the user's question.
        /// </param>
        /// <param name="tools">
        /// Tool config. Written to `tools.json`. Triggers a new commit.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentsAgent> UpdateAnAgentAsync(
            global::System.Guid agentId,
            bool? includeFiles = default,
            global::System.Collections.Generic.IList<string>? deletedPaths = default,
            string? description = default,
            object? extras = default,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.AgentsFileEntry>? files = default,
            string? instructions = default,
            string? name = default,
            global::LangSmith.AgentsAgentPermissions? permissions = default,
            global::LangSmith.AgentsAgentRuntime? runtime = default,
            global::System.Collections.Generic.IList<global::LangSmith.AgentsSkillSpec>? skills = default,
            global::System.Collections.Generic.IList<global::LangSmith.AgentsSubagentSpec>? subagents = default,
            string? systemPrompt = default,
            global::LangSmith.AgentsToolsConfig? tools = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}