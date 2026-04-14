
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageToolUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_count")]
        public int? AgentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_latency_ms")]
        public double? AvgLatencyMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used")]
        public string? LastUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_count")]
        public int? RunCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        public string? ToolName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageToolUsage" /> class.
        /// </summary>
        /// <param name="agentCount"></param>
        /// <param name="avgLatencyMs"></param>
        /// <param name="lastUsed"></param>
        /// <param name="runCount"></param>
        /// <param name="toolName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageToolUsage(
            int? agentCount,
            double? avgLatencyMs,
            string? lastUsed,
            int? runCount,
            string? toolName)
        {
            this.AgentCount = agentCount;
            this.AvgLatencyMs = avgLatencyMs;
            this.LastUsed = lastUsed;
            this.RunCount = runCount;
            this.ToolName = toolName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageToolUsage" /> class.
        /// </summary>
        public UsageToolUsage()
        {
        }
    }
}