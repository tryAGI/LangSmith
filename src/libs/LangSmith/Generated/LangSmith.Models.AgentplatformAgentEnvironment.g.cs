
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentplatformAgentEnvironment
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgentplatformAgentEnvironmentNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AgentplatformAgentEnvironmentName Environment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime_bindings")]
        public global::System.Collections.Generic.IList<global::LangSmith.AgentplatformAgentRuntimeBinding>? RuntimeBindings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracer_session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TracerSessionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracer_session_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TracerSessionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentplatformAgentEnvironment" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="environment"></param>
        /// <param name="id"></param>
        /// <param name="tracerSessionId"></param>
        /// <param name="tracerSessionName"></param>
        /// <param name="runtimeBindings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentplatformAgentEnvironment(
            string agentId,
            global::LangSmith.AgentplatformAgentEnvironmentName environment,
            global::System.Guid id,
            global::System.Guid tracerSessionId,
            string tracerSessionName,
            global::System.Collections.Generic.IList<global::LangSmith.AgentplatformAgentRuntimeBinding>? runtimeBindings)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Environment = environment;
            this.Id = id;
            this.RuntimeBindings = runtimeBindings;
            this.TracerSessionId = tracerSessionId;
            this.TracerSessionName = tracerSessionName ?? throw new global::System.ArgumentNullException(nameof(tracerSessionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentplatformAgentEnvironment" /> class.
        /// </summary>
        public AgentplatformAgentEnvironment()
        {
        }

    }
}