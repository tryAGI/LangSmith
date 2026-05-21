
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsAgentRuntime
    {
        /// <summary>
        /// Model configuration for the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::LangSmith.AgentsAgentModelConfig? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsAgentRuntime" /> class.
        /// </summary>
        /// <param name="model">
        /// Model configuration for the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsAgentRuntime(
            global::LangSmith.AgentsAgentModelConfig? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsAgentRuntime" /> class.
        /// </summary>
        public AgentsAgentRuntime()
        {
        }

    }
}