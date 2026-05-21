#nullable enable

namespace LangSmith
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create an agent<br/>
        /// Creates an agent with the given metadata, runtime configuration,<br/>
        /// and optional file tree. Returns the agent's identity, ownership,<br/>
        /// and a revision token identifying the initial file tree.<br/>
        /// Creation is atomic — either the agent is fully created or no<br/>
        /// state is persisted.<br/>
        /// The file tree is built from typed fields:<br/>
        /// * `system_prompt` → `AGENTS.md`  (`instructions` is a<br/>
        /// deprecated alias; `system_prompt` wins when both are sent)<br/>
        /// * `tools` → `tools.json`<br/>
        /// * `subagents[i]` → `subagents/&lt;name&gt;/AGENTS.md` + `subagents/&lt;name&gt;/tools.json`<br/>
        /// * `skills[i]` → `skills/&lt;name&gt;/SKILL.md` + supporting files<br/>
        /// All file paths in `skills[i].files` and the top-level `files` map<br/>
        /// must be relative — no leading `/`, no `..` segments.<br/>
        /// `extras` is an arbitrary key/value map for caller-defined tracking<br/>
        /// attached to the agent's metadata.<br/>
        /// Use `files` for paths the typed fields don't cover. Setting both<br/>
        /// a typed field and the corresponding `files` entry returns 422.
        /// </summary>
        /// <param name="includeFiles"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentsAgent> CreateAnAgentAsync(

            global::LangSmith.AgentsCreateAgentRequest request,
            bool? includeFiles = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent<br/>
        /// Creates an agent with the given metadata, runtime configuration,<br/>
        /// and optional file tree. Returns the agent's identity, ownership,<br/>
        /// and a revision token identifying the initial file tree.<br/>
        /// Creation is atomic — either the agent is fully created or no<br/>
        /// state is persisted.<br/>
        /// The file tree is built from typed fields:<br/>
        /// * `system_prompt` → `AGENTS.md`  (`instructions` is a<br/>
        /// deprecated alias; `system_prompt` wins when both are sent)<br/>
        /// * `tools` → `tools.json`<br/>
        /// * `subagents[i]` → `subagents/&lt;name&gt;/AGENTS.md` + `subagents/&lt;name&gt;/tools.json`<br/>
        /// * `skills[i]` → `skills/&lt;name&gt;/SKILL.md` + supporting files<br/>
        /// All file paths in `skills[i].files` and the top-level `files` map<br/>
        /// must be relative — no leading `/`, no `..` segments.<br/>
        /// `extras` is an arbitrary key/value map for caller-defined tracking<br/>
        /// attached to the agent's metadata.<br/>
        /// Use `files` for paths the typed fields don't cover. Setting both<br/>
        /// a typed field and the corresponding `files` entry returns 422.
        /// </summary>
        /// <param name="includeFiles"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AgentsAgent>> CreateAnAgentAsResponseAsync(

            global::LangSmith.AgentsCreateAgentRequest request,
            bool? includeFiles = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent<br/>
        /// Creates an agent with the given metadata, runtime configuration,<br/>
        /// and optional file tree. Returns the agent's identity, ownership,<br/>
        /// and a revision token identifying the initial file tree.<br/>
        /// Creation is atomic — either the agent is fully created or no<br/>
        /// state is persisted.<br/>
        /// The file tree is built from typed fields:<br/>
        /// * `system_prompt` → `AGENTS.md`  (`instructions` is a<br/>
        /// deprecated alias; `system_prompt` wins when both are sent)<br/>
        /// * `tools` → `tools.json`<br/>
        /// * `subagents[i]` → `subagents/&lt;name&gt;/AGENTS.md` + `subagents/&lt;name&gt;/tools.json`<br/>
        /// * `skills[i]` → `skills/&lt;name&gt;/SKILL.md` + supporting files<br/>
        /// All file paths in `skills[i].files` and the top-level `files` map<br/>
        /// must be relative — no leading `/`, no `..` segments.<br/>
        /// `extras` is an arbitrary key/value map for caller-defined tracking<br/>
        /// attached to the agent's metadata.<br/>
        /// Use `files` for paths the typed fields don't cover. Setting both<br/>
        /// a typed field and the corresponding `files` entry returns 422.
        /// </summary>
        /// <param name="includeFiles"></param>
        /// <param name="description"></param>
        /// <param name="extras">
        /// Caller-defined key/value tracking attached to the agent's metadata.
        /// </param>
        /// <param name="files">
        /// Raw file map for paths the typed fields don't cover. Setting a typed<br/>
        /// field and the corresponding `files` entry returns 422.
        /// </param>
        /// <param name="instructions">
        /// Deprecated: use `system_prompt`. Accepted for backwards compatibility;<br/>
        /// `system_prompt` takes precedence when both are set.
        /// </param>
        /// <param name="name"></param>
        /// <param name="permissions"></param>
        /// <param name="runtime"></param>
        /// <param name="skills">
        /// Skills. Each entry is written to `skills/&lt;name&gt;/SKILL.md` and supporting files.
        /// </param>
        /// <param name="subagents">
        /// Subagents. Each entry is written to `subagents/&lt;name&gt;/AGENTS.md` and `subagents/&lt;name&gt;/tools.json`.
        /// </param>
        /// <param name="systemPrompt">
        /// Agent system prompt. Written to `AGENTS.md`.<br/>
        /// Example: You are a helpful agent. Use the available tools to answer the user's question.
        /// </param>
        /// <param name="tools">
        /// Tool config. Written to `tools.json`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentsAgent> CreateAnAgentAsync(
            string name,
            bool? includeFiles = default,
            string? description = default,
            object? extras = default,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.AgentsFileEntry>? files = default,
            string? instructions = default,
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