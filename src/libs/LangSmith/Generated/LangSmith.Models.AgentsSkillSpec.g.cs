
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsSkillSpec
    {
        /// <summary>
        /// Short human-readable description shown to the agent.<br/>
        /// Example: Summarise text into a paragraph.
        /// </summary>
        /// <example>Summarise text into a paragraph.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Supporting files keyed by relative path. Each path becomes `skills/&lt;name&gt;/&lt;path&gt;`.<br/>
        /// Paths must be relative — no leading `/`, no `..` segments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.Dictionary<string, string>? Files { get; set; }

        /// <summary>
        /// Skill body. Written to `skills/&lt;name&gt;/SKILL.md`.<br/>
        /// Example: # Summarize<br/>
        /// Given a text, produce a one-paragraph summary.
        /// </summary>
        /// <example>
        /// # Summarize<br/>
        /// Given a text, produce a one-paragraph summary.
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Skill slug. Becomes `skills/&lt;name&gt;/SKILL.md`.<br/>
        /// Example: summarize
        /// </summary>
        /// <example>summarize</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Skill discriminator. Only `inline` is supported today.<br/>
        /// Example: inline
        /// </summary>
        /// <example>inline</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgentsSkillSpecTypeJsonConverter))]
        public global::LangSmith.AgentsSkillSpecType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSkillSpec" /> class.
        /// </summary>
        /// <param name="description">
        /// Short human-readable description shown to the agent.<br/>
        /// Example: Summarise text into a paragraph.
        /// </param>
        /// <param name="files">
        /// Supporting files keyed by relative path. Each path becomes `skills/&lt;name&gt;/&lt;path&gt;`.<br/>
        /// Paths must be relative — no leading `/`, no `..` segments.
        /// </param>
        /// <param name="instructions">
        /// Skill body. Written to `skills/&lt;name&gt;/SKILL.md`.<br/>
        /// Example: # Summarize<br/>
        /// Given a text, produce a one-paragraph summary.
        /// </param>
        /// <param name="name">
        /// Skill slug. Becomes `skills/&lt;name&gt;/SKILL.md`.<br/>
        /// Example: summarize
        /// </param>
        /// <param name="type">
        /// Skill discriminator. Only `inline` is supported today.<br/>
        /// Example: inline
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsSkillSpec(
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? files,
            string? instructions,
            string? name,
            global::LangSmith.AgentsSkillSpecType? type)
        {
            this.Description = description;
            this.Files = files;
            this.Instructions = instructions;
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSkillSpec" /> class.
        /// </summary>
        public AgentsSkillSpec()
        {
        }

    }
}