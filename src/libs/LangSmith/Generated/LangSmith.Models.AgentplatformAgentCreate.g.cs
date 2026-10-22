
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentplatformAgentCreate
    {
        /// <summary>
        /// AgentType defaults to CUSTOM when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgentplatformAgentTypeJsonConverter))]
        public global::LangSmith.AgentplatformAgentType? AgentType { get; set; }

        /// <summary>
        /// Unique agent identifier: 1-63 lowercase letters, digits, or hyphens,<br/>
        /// starting with a letter and ending with a letter or digit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name. Defaults to the agent ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// ProductionOnly creates only the PRODUCTION environment. It is accepted<br/>
        /// only when SourceType is FLEET; other sources always get all four<br/>
        /// environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("production_only")]
        public bool? ProductionOnly { get; set; }

        /// <summary>
        /// Agent runtime kind. Use EXTERNAL for an application hosted outside LangSmith.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgentplatformAgentSourceType2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AgentplatformAgentSourceType2 SourceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentplatformAgentCreate" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique agent identifier: 1-63 lowercase letters, digits, or hyphens,<br/>
        /// starting with a letter and ending with a letter or digit.
        /// </param>
        /// <param name="sourceType">
        /// Agent runtime kind. Use EXTERNAL for an application hosted outside LangSmith.
        /// </param>
        /// <param name="agentType">
        /// AgentType defaults to CUSTOM when omitted.
        /// </param>
        /// <param name="name">
        /// Display name. Defaults to the agent ID.
        /// </param>
        /// <param name="productionOnly">
        /// ProductionOnly creates only the PRODUCTION environment. It is accepted<br/>
        /// only when SourceType is FLEET; other sources always get all four<br/>
        /// environments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentplatformAgentCreate(
            string id,
            global::LangSmith.AgentplatformAgentSourceType2 sourceType,
            global::LangSmith.AgentplatformAgentType? agentType,
            string? name,
            bool? productionOnly)
        {
            this.AgentType = agentType;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.ProductionOnly = productionOnly;
            this.SourceType = sourceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentplatformAgentCreate" /> class.
        /// </summary>
        public AgentplatformAgentCreate()
        {
        }

    }
}