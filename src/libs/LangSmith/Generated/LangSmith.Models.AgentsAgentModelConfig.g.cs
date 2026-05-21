
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsAgentModelConfig
    {
        /// <summary>
        /// Model ID used to run the agent.<br/>
        /// Example: claude-sonnet-4-6
        /// </summary>
        /// <example>claude-sonnet-4-6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsAgentModelConfig" /> class.
        /// </summary>
        /// <param name="modelId">
        /// Model ID used to run the agent.<br/>
        /// Example: claude-sonnet-4-6
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsAgentModelConfig(
            string? modelId)
        {
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsAgentModelConfig" /> class.
        /// </summary>
        public AgentsAgentModelConfig()
        {
        }

    }
}