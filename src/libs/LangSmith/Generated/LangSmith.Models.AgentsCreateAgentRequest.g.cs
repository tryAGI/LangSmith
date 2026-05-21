
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsCreateAgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Caller-defined key/value tracking attached to the agent's metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// Raw file map for paths the typed fields don't cover. Setting a typed<br/>
        /// field and the corresponding `files` entry returns 422.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.AgentsFileEntry>? Files { get; set; }

        /// <summary>
        /// Deprecated: use `system_prompt`. Accepted for backwards compatibility;<br/>
        /// `system_prompt` takes precedence when both are set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::LangSmith.AgentsAgentPermissions? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        public global::LangSmith.AgentsAgentRuntime? Runtime { get; set; }

        /// <summary>
        /// Skills. Each entry is written to `skills/&lt;name&gt;/SKILL.md` and supporting files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::LangSmith.AgentsSkillSpec>? Skills { get; set; }

        /// <summary>
        /// Subagents. Each entry is written to `subagents/&lt;name&gt;/AGENTS.md` and `subagents/&lt;name&gt;/tools.json`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subagents")]
        public global::System.Collections.Generic.IList<global::LangSmith.AgentsSubagentSpec>? Subagents { get; set; }

        /// <summary>
        /// Agent system prompt. Written to `AGENTS.md`.<br/>
        /// Example: You are a helpful agent. Use the available tools to answer the user's question.
        /// </summary>
        /// <example>You are a helpful agent. Use the available tools to answer the user's question.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Tool config. Written to `tools.json`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::LangSmith.AgentsToolsConfig? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCreateAgentRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsCreateAgentRequest(
            string name,
            string? description,
            object? extras,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.AgentsFileEntry>? files,
            string? instructions,
            global::LangSmith.AgentsAgentPermissions? permissions,
            global::LangSmith.AgentsAgentRuntime? runtime,
            global::System.Collections.Generic.IList<global::LangSmith.AgentsSkillSpec>? skills,
            global::System.Collections.Generic.IList<global::LangSmith.AgentsSubagentSpec>? subagents,
            string? systemPrompt,
            global::LangSmith.AgentsToolsConfig? tools)
        {
            this.Description = description;
            this.Extras = extras;
            this.Files = files;
            this.Instructions = instructions;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Permissions = permissions;
            this.Runtime = runtime;
            this.Skills = skills;
            this.Subagents = subagents;
            this.SystemPrompt = systemPrompt;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCreateAgentRequest" /> class.
        /// </summary>
        public AgentsCreateAgentRequest()
        {
        }

    }
}