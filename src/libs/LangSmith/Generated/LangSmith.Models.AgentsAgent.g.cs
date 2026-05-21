
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsAgent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// Raw file map. Returned only when `include_files=true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.AgentsFileEntry>? Files { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Deprecated: use `system_prompt`. Echoed alongside `system_prompt` with<br/>
        /// the same value for backwards compatibility.
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
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        public global::System.Guid? OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::LangSmith.AgentsAgentPermissions? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        public string? Revision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        public global::LangSmith.AgentsAgentRuntime? Runtime { get; set; }

        /// <summary>
        /// Skills parsed from `skills/&lt;name&gt;/SKILL.md` and supporting files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::LangSmith.AgentsSkillSpec>? Skills { get; set; }

        /// <summary>
        /// Subagents parsed from `subagents/&lt;name&gt;/AGENTS.md` + `subagents/&lt;name&gt;/tools.json`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subagents")]
        public global::System.Collections.Generic.IList<global::LangSmith.AgentsSubagentSpec>? Subagents { get; set; }

        /// <summary>
        /// Agent system prompt parsed from `AGENTS.md`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Tool config parsed from `tools.json`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::LangSmith.AgentsToolsConfig? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsAgent" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="extras"></param>
        /// <param name="files">
        /// Raw file map. Returned only when `include_files=true`.
        /// </param>
        /// <param name="id"></param>
        /// <param name="instructions">
        /// Deprecated: use `system_prompt`. Echoed alongside `system_prompt` with<br/>
        /// the same value for backwards compatibility.
        /// </param>
        /// <param name="name"></param>
        /// <param name="ownerId"></param>
        /// <param name="permissions"></param>
        /// <param name="revision"></param>
        /// <param name="runtime"></param>
        /// <param name="skills">
        /// Skills parsed from `skills/&lt;name&gt;/SKILL.md` and supporting files.
        /// </param>
        /// <param name="subagents">
        /// Subagents parsed from `subagents/&lt;name&gt;/AGENTS.md` + `subagents/&lt;name&gt;/tools.json`.
        /// </param>
        /// <param name="systemPrompt">
        /// Agent system prompt parsed from `AGENTS.md`.
        /// </param>
        /// <param name="tools">
        /// Tool config parsed from `tools.json`.
        /// </param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsAgent(
            global::System.DateTime? createdAt,
            string? description,
            object? extras,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.AgentsFileEntry>? files,
            global::System.Guid? id,
            string? instructions,
            string? name,
            global::System.Guid? ownerId,
            global::LangSmith.AgentsAgentPermissions? permissions,
            string? revision,
            global::LangSmith.AgentsAgentRuntime? runtime,
            global::System.Collections.Generic.IList<global::LangSmith.AgentsSkillSpec>? skills,
            global::System.Collections.Generic.IList<global::LangSmith.AgentsSubagentSpec>? subagents,
            string? systemPrompt,
            global::LangSmith.AgentsToolsConfig? tools,
            global::System.DateTime? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Extras = extras;
            this.Files = files;
            this.Id = id;
            this.Instructions = instructions;
            this.Name = name;
            this.OwnerId = ownerId;
            this.Permissions = permissions;
            this.Revision = revision;
            this.Runtime = runtime;
            this.Skills = skills;
            this.Subagents = subagents;
            this.SystemPrompt = systemPrompt;
            this.Tools = tools;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsAgent" /> class.
        /// </summary>
        public AgentsAgent()
        {
        }

    }
}