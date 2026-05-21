
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsSubagentSpec
    {
        /// <summary>
        /// Short human-readable description.<br/>
        /// Example: Researches a topic and summarises findings.
        /// </summary>
        /// <example>Researches a topic and summarises findings.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Subagent system prompt. Written to `subagents/&lt;name&gt;/AGENTS.md`.<br/>
        /// Example: You are a research assistant. Use the available tools to gather information.
        /// </summary>
        /// <example>You are a research assistant. Use the available tools to gather information.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Model ID for this subagent. Inherits the parent runtime when empty.<br/>
        /// Example: claude-sonnet-4-6
        /// </summary>
        /// <example>claude-sonnet-4-6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Subagent slug. Becomes `subagents/&lt;name&gt;/AGENTS.md`.<br/>
        /// Example: researcher
        /// </summary>
        /// <example>researcher</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Subagent tool config. Written to `subagents/&lt;name&gt;/tools.json`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::LangSmith.AgentsToolsConfig? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSubagentSpec" /> class.
        /// </summary>
        /// <param name="description">
        /// Short human-readable description.<br/>
        /// Example: Researches a topic and summarises findings.
        /// </param>
        /// <param name="instructions">
        /// Subagent system prompt. Written to `subagents/&lt;name&gt;/AGENTS.md`.<br/>
        /// Example: You are a research assistant. Use the available tools to gather information.
        /// </param>
        /// <param name="modelId">
        /// Model ID for this subagent. Inherits the parent runtime when empty.<br/>
        /// Example: claude-sonnet-4-6
        /// </param>
        /// <param name="name">
        /// Subagent slug. Becomes `subagents/&lt;name&gt;/AGENTS.md`.<br/>
        /// Example: researcher
        /// </param>
        /// <param name="tools">
        /// Subagent tool config. Written to `subagents/&lt;name&gt;/tools.json`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsSubagentSpec(
            string? description,
            string? instructions,
            string? modelId,
            string? name,
            global::LangSmith.AgentsToolsConfig? tools)
        {
            this.Description = description;
            this.Instructions = instructions;
            this.ModelId = modelId;
            this.Name = name;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSubagentSpec" /> class.
        /// </summary>
        public AgentsSubagentSpec()
        {
        }

    }
}