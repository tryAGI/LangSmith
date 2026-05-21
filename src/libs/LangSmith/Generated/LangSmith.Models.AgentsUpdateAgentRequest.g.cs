
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsUpdateAgentRequest
    {
        /// <summary>
        /// Paths to remove from the file tree. Relative paths only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_paths")]
        public global::System.Collections.Generic.IList<string>? DeletedPaths { get; set; }

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
        /// Raw file entries created or replaced by path. Triggers a new commit.
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
        public string? Name { get; set; }

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
        /// Skills. Each entry is written to `skills/&lt;name&gt;/SKILL.md` and supporting files. Triggers a new commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::LangSmith.AgentsSkillSpec>? Skills { get; set; }

        /// <summary>
        /// Subagents. Each entry is written to `subagents/&lt;name&gt;/AGENTS.md` and `subagents/&lt;name&gt;/tools.json`. Triggers a new commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subagents")]
        public global::System.Collections.Generic.IList<global::LangSmith.AgentsSubagentSpec>? Subagents { get; set; }

        /// <summary>
        /// Agent system prompt. Written to `AGENTS.md`. Triggers a new commit.<br/>
        /// Example: You are a helpful agent. Use the available tools to answer the user's question.
        /// </summary>
        /// <example>You are a helpful agent. Use the available tools to answer the user's question.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Tool config. Written to `tools.json`. Triggers a new commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::LangSmith.AgentsToolsConfig? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsUpdateAgentRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsUpdateAgentRequest(
            global::System.Collections.Generic.IList<string>? deletedPaths,
            string? description,
            object? extras,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.AgentsFileEntry>? files,
            string? instructions,
            string? name,
            global::LangSmith.AgentsAgentPermissions? permissions,
            global::LangSmith.AgentsAgentRuntime? runtime,
            global::System.Collections.Generic.IList<global::LangSmith.AgentsSkillSpec>? skills,
            global::System.Collections.Generic.IList<global::LangSmith.AgentsSubagentSpec>? subagents,
            string? systemPrompt,
            global::LangSmith.AgentsToolsConfig? tools)
        {
            this.DeletedPaths = deletedPaths;
            this.Description = description;
            this.Extras = extras;
            this.Files = files;
            this.Instructions = instructions;
            this.Name = name;
            this.Permissions = permissions;
            this.Runtime = runtime;
            this.Skills = skills;
            this.Subagents = subagents;
            this.SystemPrompt = systemPrompt;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsUpdateAgentRequest" /> class.
        /// </summary>
        public AgentsUpdateAgentRequest()
        {
        }

    }
}