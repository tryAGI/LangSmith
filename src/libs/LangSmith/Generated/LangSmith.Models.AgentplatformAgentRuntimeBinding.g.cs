
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentplatformAgentRuntimeBinding
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_environment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AgentEnvironmentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentplatformAgentRuntimeBinding" /> class.
        /// </summary>
        /// <param name="agentEnvironmentId"></param>
        /// <param name="id"></param>
        /// <param name="sourceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentplatformAgentRuntimeBinding(
            global::System.Guid agentEnvironmentId,
            global::System.Guid id,
            string sourceId)
        {
            this.AgentEnvironmentId = agentEnvironmentId;
            this.Id = id;
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentplatformAgentRuntimeBinding" /> class.
        /// </summary>
        public AgentplatformAgentRuntimeBinding()
        {
        }

    }
}