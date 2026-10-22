
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentplatformAgent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgentplatformAgentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AgentplatformAgentType AgentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.AgentplatformAgentEnvironment> Environments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Owner is the owner's full name, falling back to email when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        public global::System.Guid? OwnerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgentplatformAgentSourceType2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AgentplatformAgentSourceType2 SourceType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_key_id")]
        public global::System.Guid? TagKeyId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_value_id")]
        public global::System.Guid? TagValueId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentplatformAgent" /> class.
        /// </summary>
        /// <param name="agentType"></param>
        /// <param name="createdAt"></param>
        /// <param name="environments"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="sourceType"></param>
        /// <param name="owner">
        /// Owner is the owner's full name, falling back to email when available.
        /// </param>
        /// <param name="ownerId"></param>
        /// <param name="tagKeyId"></param>
        /// <param name="tagValueId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentplatformAgent(
            global::LangSmith.AgentplatformAgentType agentType,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::LangSmith.AgentplatformAgentEnvironment> environments,
            string id,
            string name,
            global::LangSmith.AgentplatformAgentSourceType2 sourceType,
            string? owner,
            global::System.Guid? ownerId,
            global::System.Guid? tagKeyId,
            global::System.Guid? tagValueId)
        {
            this.AgentType = agentType;
            this.CreatedAt = createdAt;
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Owner = owner;
            this.OwnerId = ownerId;
            this.SourceType = sourceType;
            this.TagKeyId = tagKeyId;
            this.TagValueId = tagValueId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentplatformAgent" /> class.
        /// </summary>
        public AgentplatformAgent()
        {
        }

    }
}