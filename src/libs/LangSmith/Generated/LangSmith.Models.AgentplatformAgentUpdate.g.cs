
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentplatformAgentUpdate
    {
        /// <summary>
        /// New classification. Omit to keep the current classification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgentplatformAgentTypeJsonConverter))]
        public global::LangSmith.AgentplatformAgentType? AgentType { get; set; }

        /// <summary>
        /// New display name. Omit to keep the current name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Omit to leave the owner unchanged; null clears it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        public global::System.Guid? OwnerId { get; set; }

        /// <summary>
        /// New runtime kind. Only EXTERNAL agents without runtime bindings can change kind.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgentplatformAgentSourceType2JsonConverter))]
        public global::LangSmith.AgentplatformAgentSourceType2? SourceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentplatformAgentUpdate" /> class.
        /// </summary>
        /// <param name="agentType">
        /// New classification. Omit to keep the current classification.
        /// </param>
        /// <param name="name">
        /// New display name. Omit to keep the current name.
        /// </param>
        /// <param name="ownerId">
        /// Omit to leave the owner unchanged; null clears it.
        /// </param>
        /// <param name="sourceType">
        /// New runtime kind. Only EXTERNAL agents without runtime bindings can change kind.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentplatformAgentUpdate(
            global::LangSmith.AgentplatformAgentType? agentType,
            string? name,
            global::System.Guid? ownerId,
            global::LangSmith.AgentplatformAgentSourceType2? sourceType)
        {
            this.AgentType = agentType;
            this.Name = name;
            this.OwnerId = ownerId;
            this.SourceType = sourceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentplatformAgentUpdate" /> class.
        /// </summary>
        public AgentplatformAgentUpdate()
        {
        }

    }
}