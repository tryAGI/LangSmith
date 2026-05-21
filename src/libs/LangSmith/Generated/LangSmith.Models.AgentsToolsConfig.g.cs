
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsToolsConfig
    {
        /// <summary>
        /// Per-tool interrupt rules keyed by tool name. Use `{}` for no interrupts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupt_config")]
        public object? InterruptConfig { get; set; }

        /// <summary>
        /// MCP tools available to the agent. Serialised to `tools.json`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::LangSmith.AgentsToolSpec>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsToolsConfig" /> class.
        /// </summary>
        /// <param name="interruptConfig">
        /// Per-tool interrupt rules keyed by tool name. Use `{}` for no interrupts.
        /// </param>
        /// <param name="tools">
        /// MCP tools available to the agent. Serialised to `tools.json`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsToolsConfig(
            object? interruptConfig,
            global::System.Collections.Generic.IList<global::LangSmith.AgentsToolSpec>? tools)
        {
            this.InterruptConfig = interruptConfig;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsToolsConfig" /> class.
        /// </summary>
        public AgentsToolsConfig()
        {
        }

    }
}